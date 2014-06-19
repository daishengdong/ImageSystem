namespace ImageSystem
{
    partial class LoginFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.切换账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.txtBoxName);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelAccount);
            this.panel1.Location = new System.Drawing.Point(129, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 206);
            this.panel1.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(120, 134);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(165, 20);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(120, 58);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(165, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(65, 137);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(31, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "密码";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(65, 61);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(31, 13);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "账户";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(423, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(504, 367);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 23);
            this.btnRegist.TabIndex = 2;
            this.btnRegist.Text = "注册";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换账号ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 54);
            // 
            // 切换账号ToolStripMenuItem
            // 
            this.切换账号ToolStripMenuItem.Name = "切换账号ToolStripMenuItem";
            this.切换账号ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.切换账号ToolStripMenuItem.Text = "切换账号";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // LoginFrm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 402);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginFrm";
            this.Text = "登录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegist;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 切换账号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

