namespace ImageSystem
{
    partial class SettingFrm
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
            this.tbTimeLimit = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "显示名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "浏览时限";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(88, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(134, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbTimeLimit
            // 
            this.tbTimeLimit.Location = new System.Drawing.Point(88, 77);
            this.tbTimeLimit.Name = "tbTimeLimit";
            this.tbTimeLimit.Size = new System.Drawing.Size(134, 20);
            this.tbTimeLimit.TabIndex = 3;
            this.tbTimeLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTimeLimit_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(88, 134);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SettingFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 186);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbTimeLimit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingFrm";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SettingFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTimeLimit;
        private System.Windows.Forms.Button btnOK;
    }
}