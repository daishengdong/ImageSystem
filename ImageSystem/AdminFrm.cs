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
using ImageSystem.XMLHandle;

namespace ImageSystem
{
    public partial class AdminFrm : Form
    {
        Bundle bundle = null;
        Account account;
        LoginFrm loginFrm;
        ImageList imgList;
        ImagesXMLHandler imagesXMLHandler;

        public AdminFrm(Bundle bundle)
        {
            InitializeComponent();

            this.bundle = bundle;
            this.account = bundle._Account;
            this.loginFrm = bundle.LoginFrm;

            if (account.Authority == CommonStaticVariables.AUTHORITY.OPERATOR.ToString())
            {
                this.Text = "欢迎您【" + account.Name + "】您的权限是【操作员】";
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnSetting.Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
            }
            else
            {
                this.Text = "欢迎您【" + account.Name + "】您的权限是【管理员】";
            }

            if (!File.Exists(CommonStaticVariables.imagesFilePath))
            {
                StreamWriter sw = new StreamWriter(CommonStaticVariables.imagesFilePath);
                sw.Write("<images>\n</images>");
                sw.Close();
            }
            imagesXMLHandler = new ImagesXMLHandler();
            imgList = new ImageList();
            imgList.ImageSize = new Size(30, 30);// 设置行高 30 分别是宽和高  
            lvImages.SmallImageList = imgList; //这里设置listView的SmallImageList ,用imgList将其撑大  
        }

        private void AdminFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginFrm.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();                  // 打开文件对话框

            ofd.AddExtension = true;
            ofd.CheckFileExists = true;
            ofd.Filter = "Images (*.jpg;*.tif)|*.jpg;*.tif|JPEGs (*.jpg)|*.jpg|TIFs (*.tif)|*.tif|All Files (*.*)|*.*"; 
            ofd.FilterIndex = 1;
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            ofd.ShowReadOnly = true;
            ofd.Title = "添加图片";

            ofd.ShowDialog();
            string[] files = ofd.FileNames;

            int i = imgList.Images.Count;
            foreach (string fileName in files)
            {
                FileInfo fi = new FileInfo(fileName);
                string name = fi.Name;
                string dateAdded = DateTime.Now.ToShortDateString();
                string type = null;
                if (fi.Extension == ".jpg")
                {
                    type = "JPEG";
                }
                else if (fi.Extension == ".tif")
                {
                    type = "TIF";
                }
                long size = fi.Length / 1024;
                int timeLimit = 30;
                string path = fileName;

                if (imagesXMLHandler.exits(path))
                {
                    MessageBox.Show(path + "已添加过！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }

                Image newImage = new Image(name, dateAdded, type, size, path, timeLimit);
                imagesXMLHandler.add(newImage);

                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Clear();

                imgList.Images.Add(System.Drawing.Image.FromFile(newImage.Path));  //为listview项添加照片。
                lvi.ImageIndex = i++;     //通过与imageList绑定，显示imageList中第i项图标  

                lvi.SubItems.Add(newImage.Name);
                lvi.SubItems.Add(newImage.DateAdded);
                lvi.SubItems.Add(newImage.Type);
                lvi.SubItems.Add(newImage.Size.ToString() + " kb");
                lvi.SubItems.Add(newImage.TimeLimit.ToString() + " s");
                lvi.SubItems.Add(newImage.Path);
                lvImages.Items.Add(lvi);
            }
            string entry = "用户【" + account.Name + "】添加了图片：" + Environment.NewLine;
            foreach (string fileName in files)
            {
                entry += fileName + Environment.NewLine;
            }
            Log.write(entry);
        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            Log.write("用户【" + account.Name + "】登录");
            refreshList();
        }

        public void refreshList()
        {
            this.lvImages.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
            lvImages.Items.Clear();
            imgList.Images.Clear();
            imagesXMLHandler.reload();
            List<Image> imageList = imagesXMLHandler.getAllImages();

            int i = 0;
            foreach (Image image in imageList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Clear();

                if (!File.Exists(image.Path))
                {
                    MessageBox.Show("图片文件不存在！\n请确认 " + image.Path + " 存在于本地磁盘上\n缩略图加载已跳过", "致命错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lvi.SubItems[0].Text = "图片缺失";
                }
                else
                {
                    imgList.Images.Add(System.Drawing.Image.FromFile(image.Path));  //为listview项添加照片。
                    lvi.ImageIndex = i++;     //通过与imageList绑定，显示imageList中第i项图标  
                }

                lvi.SubItems.Add(image.Name);
                lvi.SubItems.Add(image.DateAdded);
                lvi.SubItems.Add(image.Type);
                lvi.SubItems.Add(image.Size.ToString() + " kb");
                lvi.SubItems.Add(image.TimeLimit.ToString() + " s");
                lvi.SubItems.Add(image.Path);
                lvImages.Items.Add(lvi);
            }
            this.lvImages.EndUpdate();  //结束数据处理，UI界面一次性绘制。  
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvImages.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选中要删除的图片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string path = lvImages.SelectedItems[0].SubItems[6].Text;
            imagesXMLHandler.delete(path);

            lvImages.Items.RemoveAt(lvImages.SelectedItems[0].Index); // 按索引移除

            Log.write("用户【" + account.Name + "】对图片【" + path + "】的设置进行了更改");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lvImages.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选中要查看的图片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string path = lvImages.SelectedItems[0].SubItems[6].Text;

            ViewFrm viewFrm = new ViewFrm(imagesXMLHandler.search(path), account);
            viewFrm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (lvImages.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选中要设置的图片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string path = lvImages.SelectedItems[0].SubItems[6].Text;

            SettingFrm settingFrm = new SettingFrm(account, imagesXMLHandler.search(path), this);
            settingFrm.Show();
        }
    }
}
