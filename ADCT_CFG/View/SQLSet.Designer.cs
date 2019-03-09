namespace ADCT_CFG.View
{
    partial class SQLSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLSet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SQLAddress_TB = new System.Windows.Forms.TextBox();
            this.SQLUserName_TB = new System.Windows.Forms.TextBox();
            this.SQLPwd_TB = new System.Windows.Forms.TextBox();
            this.SQLDataBase_TB = new System.Windows.Forms.TextBox();
            this.IDOK_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据库名称：";
            // 
            // SQLAddress_TB
            // 
            this.SQLAddress_TB.Location = new System.Drawing.Point(132, 23);
            this.SQLAddress_TB.Name = "SQLAddress_TB";
            this.SQLAddress_TB.Size = new System.Drawing.Size(161, 21);
            this.SQLAddress_TB.TabIndex = 4;
            // 
            // SQLUserName_TB
            // 
            this.SQLUserName_TB.Location = new System.Drawing.Point(132, 65);
            this.SQLUserName_TB.Name = "SQLUserName_TB";
            this.SQLUserName_TB.Size = new System.Drawing.Size(161, 21);
            this.SQLUserName_TB.TabIndex = 5;
            // 
            // SQLPwd_TB
            // 
            this.SQLPwd_TB.Location = new System.Drawing.Point(132, 104);
            this.SQLPwd_TB.Name = "SQLPwd_TB";
            this.SQLPwd_TB.Size = new System.Drawing.Size(161, 21);
            this.SQLPwd_TB.TabIndex = 6;
            // 
            // SQLDataBase_TB
            // 
            this.SQLDataBase_TB.Location = new System.Drawing.Point(132, 142);
            this.SQLDataBase_TB.Name = "SQLDataBase_TB";
            this.SQLDataBase_TB.Size = new System.Drawing.Size(161, 21);
            this.SQLDataBase_TB.TabIndex = 7;
            // 
            // IDOK_Btn
            // 
            this.IDOK_Btn.Location = new System.Drawing.Point(68, 197);
            this.IDOK_Btn.Name = "IDOK_Btn";
            this.IDOK_Btn.Size = new System.Drawing.Size(75, 23);
            this.IDOK_Btn.TabIndex = 8;
            this.IDOK_Btn.Text = "确定";
            this.IDOK_Btn.UseVisualStyleBackColor = true;
            this.IDOK_Btn.Click += new System.EventHandler(this.IDOK_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(202, 197);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Btn.TabIndex = 9;
            this.Cancel_Btn.Text = "取消";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // SQLSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(342, 237);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.IDOK_Btn);
            this.Controls.Add(this.SQLDataBase_TB);
            this.Controls.Add(this.SQLPwd_TB);
            this.Controls.Add(this.SQLUserName_TB);
            this.Controls.Add(this.SQLAddress_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SQLSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SQLSet";
            this.Load += new System.EventHandler(this.SQLSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SQLAddress_TB;
        private System.Windows.Forms.TextBox SQLUserName_TB;
        private System.Windows.Forms.TextBox SQLPwd_TB;
        private System.Windows.Forms.TextBox SQLDataBase_TB;
        private System.Windows.Forms.Button IDOK_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}