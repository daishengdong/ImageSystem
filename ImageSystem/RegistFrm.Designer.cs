namespace ImageSystem
{
    partial class RegistFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbRePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbOperator = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(122, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(214, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(122, 85);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(214, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // tbRePassword
            // 
            this.tbRePassword.Location = new System.Drawing.Point(122, 134);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.PasswordChar = '*';
            this.tbRePassword.Size = new System.Drawing.Size(214, 20);
            this.tbRePassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认密码";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(139, 191);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(61, 17);
            this.rbAdmin.TabIndex = 6;
            this.rbAdmin.Text = "管理员";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbOperator
            // 
            this.rbOperator.AutoSize = true;
            this.rbOperator.Checked = true;
            this.rbOperator.Location = new System.Drawing.Point(221, 191);
            this.rbOperator.Name = "rbOperator";
            this.rbOperator.Size = new System.Drawing.Size(61, 17);
            this.rbOperator.TabIndex = 7;
            this.rbOperator.TabStop = true;
            this.rbOperator.Text = "操作员";
            this.rbOperator.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(162, 233);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // RegistFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 301);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbOperator);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistFrm";
            this.Text = "注册用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbRePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbOperator;
        private System.Windows.Forms.Button btnOK;
    }
}