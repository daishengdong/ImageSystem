using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ImageSystem.XMLHandle;

namespace ImageSystem
{
    public partial class SettingFrm : Form
    {
        private Account account;
        private Image image;
        private AdminFrm adminFrm;
        private ImagesXMLHandler imagesXMLHandler;

        public SettingFrm(Account account, Image image, AdminFrm adminFrm)
        {
            InitializeComponent();

            this.account = account;
            this.image = image;
            this.adminFrm = adminFrm;
            imagesXMLHandler = new ImagesXMLHandler();
        }

        private void tbTimeLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() != string.Empty)
            {
                image.Name = tbName.Text.Trim();
            }

            if (tbTimeLimit.Text.Trim() != string.Empty)
            {
                image.TimeLimit = Convert.ToInt32(tbTimeLimit.Text.Trim());
            }

            imagesXMLHandler.update(image);
            adminFrm.refreshList();
            Log.write("用户【" + account.Name + "】对图片【" + image.Path + "】的设置进行了更改");
            this.Close();
        }

        private void SettingFrm_Load(object sender, EventArgs e)
        {
            tbName.Text = image.Name;
            tbTimeLimit.Text = image.TimeLimit.ToString();
        }
    }
}
