using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using ImageSystem.CommonStaticVar;

namespace ImageSystem
{
    public partial class ViewFrm : Form
    {
        int time = 0;
        private Image image;
        private Account account;
        public ViewFrm(Image image, Account account)
        {
            InitializeComponent();

            this.image = image;
            this.account = account;
        }

        private void ViewFrm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(image.Path))
            {
                MessageBox.Show("图片文件不存在！\n请确认 " + image.Path + " 存在于本地磁盘上", "致命错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Text = image.Name;
            System.Drawing.Image img = System.Drawing.Image.FromFile(image.Path);
            this.Height = img.Height;
            this.Width = img.Width;
            pictureBox1.Image = img;

            if (account.Authority == CommonStaticVariables.AUTHORITY.OPERATOR.ToString())
            {
                timer1.Start();
            }
            Log.write("用户【" + account.Name + "】查看了图片【" + image.Name + "】");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++time;
            if (time > image.TimeLimit)
            {
                this.Close();
            }
        }
    }
}
