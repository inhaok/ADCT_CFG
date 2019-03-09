namespace ADCT_CFG.View
{
    partial class FTPSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTPSet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FTPAddress_TB = new System.Windows.Forms.TextBox();
            this.FTPUserName_TB = new System.Windows.Forms.TextBox();
            this.FTPPWD_TB = new System.Windows.Forms.TextBox();
            this.IDOK_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FTP服务器地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "FTP服务器用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "FTP服务器密码：";
            // 
            // FTPAddress_TB
            // 
            this.FTPAddress_TB.Location = new System.Drawing.Point(152, 23);
            this.FTPAddress_TB.Name = "FTPAddress_TB";
            this.FTPAddress_TB.Size = new System.Drawing.Size(184, 21);
            this.FTPAddress_TB.TabIndex = 3;
            // 
            // FTPUserName_TB
            // 
            this.FTPUserName_TB.Location = new System.Drawing.Point(152, 65);
            this.FTPUserName_TB.Name = "FTPUserName_TB";
            this.FTPUserName_TB.Size = new System.Drawing.Size(184, 21);
            this.FTPUserName_TB.TabIndex = 4;
            // 
            // FTPPWD_TB
            // 
            this.FTPPWD_TB.Location = new System.Drawing.Point(152, 107);
            this.FTPPWD_TB.Name = "FTPPWD_TB";
            this.FTPPWD_TB.Size = new System.Drawing.Size(184, 21);
            this.FTPPWD_TB.TabIndex = 5;
            // 
            // IDOK_Btn
            // 
            this.IDOK_Btn.Location = new System.Drawing.Point(64, 177);
            this.IDOK_Btn.Name = "IDOK_Btn";
            this.IDOK_Btn.Size = new System.Drawing.Size(75, 23);
            this.IDOK_Btn.TabIndex = 6;
            this.IDOK_Btn.Text = "确定";
            this.IDOK_Btn.UseVisualStyleBackColor = true;
            this.IDOK_Btn.Click += new System.EventHandler(this.IDOK_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(203, 177);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Btn.TabIndex = 7;
            this.Cancel_Btn.Text = "取消";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // FTPSet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(359, 216);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.IDOK_Btn);
            this.Controls.Add(this.FTPPWD_TB);
            this.Controls.Add(this.FTPUserName_TB);
            this.Controls.Add(this.FTPAddress_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FTPSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FTPSet";
            this.Load += new System.EventHandler(this.FTPSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FTPAddress_TB;
        private System.Windows.Forms.TextBox FTPUserName_TB;
        private System.Windows.Forms.TextBox FTPPWD_TB;
        private System.Windows.Forms.Button IDOK_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}