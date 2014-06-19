using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Data.SqlClient;

using ImageSystem.CommonStaticVar;
using ImageSystem.XMLHandle;

namespace ImageSystem
{
    public partial class LoginFrm : Form
    {
        private AccountsXMLHandler accountsXMLHandler;

        public LoginFrm()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;

            if (!File.Exists(CommonStaticVariables.accountsFilePath))
            {
                StreamWriter sw = new StreamWriter(CommonStaticVariables.accountsFilePath);
                sw.Write("<accounts>\n</accounts>");
                sw.Close();
            }
            accountsXMLHandler = new AccountsXMLHandler();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtBoxName.Text.Trim();
                string password = txtBoxPassword.Text.Trim();

                Account account = accountsXMLHandler.search(name, password);
                if (account == null)
                {
                    MessageBox.Show("登录失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.write("试图用账户【" + name + "】登录失败");
                    return;
                }

                AdminFrm adminFrm = new AdminFrm(new Bundle(account, this));
                this.Visible = false;
                adminFrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            try
            {
                RegistFrm registFrm = new RegistFrm();
                registFrm.ShowDialog();
                accountsXMLHandler.reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
