using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ImageSystem.XMLHandle;
using ImageSystem.CommonStaticVar;

namespace ImageSystem
{
    public partial class RegistFrm : Form
    {
        private AccountsXMLHandler accountsXMLHandler;

        public RegistFrm()
        {
            InitializeComponent();

            accountsXMLHandler = new AccountsXMLHandler();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string password = tbPassword.Text.Trim();
            string rePassword = tbRePassword.Text.Trim();
            string authority = null;
            if (password != rePassword)
            {
                MessageBox.Show("两次输入的密码不相同!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (accountsXMLHandler.exits(name))
            {
                MessageBox.Show("用户【" + name + "】已存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (rbAdmin.Checked)
            {
                authority = CommonStaticVariables.AUTHORITY.ADMINISTRATOR.ToString();
            }
            else
            {
                authority = CommonStaticVariables.AUTHORITY.OPERATOR.ToString();
            }

            accountsXMLHandler.add(new Account(name, password, authority));
            MessageBox.Show("用户【" + name + "】注册成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Log.write("用户【" + name + "】注册");
            this.Close();
        }
    }
}
