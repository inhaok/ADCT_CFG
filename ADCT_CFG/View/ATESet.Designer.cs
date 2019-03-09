namespace ADCT_CFG.View
{
    partial class ATESet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ATESetDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFGPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFGSelectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SetupPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetupSelectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.INI_Btn = new System.Windows.Forms.Button();
            this.INI_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PathSelect_OFD = new System.Windows.Forms.OpenFileDialog();
            this.OK_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ATESetDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ATESetDGV
            // 
            this.ATESetDGV.AllowUserToAddRows = false;
            this.ATESetDGV.AllowUserToDeleteRows = false;
            this.ATESetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ATESetDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CFGPath,
            this.CFGSelectBtn,
            this.SetupPath,
            this.SetupSelectBtn});
            this.ATESetDGV.Location = new System.Drawing.Point(12, 58);
            this.ATESetDGV.Name = "ATESetDGV";
            this.ATESetDGV.ReadOnly = true;
            this.ATESetDGV.RowHeadersVisible = false;
            this.ATESetDGV.RowTemplate.Height = 23;
            this.ATESetDGV.Size = new System.Drawing.Size(818, 268);
            this.ATESetDGV.TabIndex = 24;
            this.ATESetDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ATESetDGV_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CFGPath
            // 
            this.CFGPath.HeaderText = "CFG文件路径";
            this.CFGPath.Name = "CFGPath";
            this.CFGPath.ReadOnly = true;
            this.CFGPath.Width = 300;
            // 
            // CFGSelectBtn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "选择";
            this.CFGSelectBtn.DefaultCellStyle = dataGridViewCellStyle3;
            this.CFGSelectBtn.HeaderText = "";
            this.CFGSelectBtn.Name = "CFGSelectBtn";
            this.CFGSelectBtn.ReadOnly = true;
            this.CFGSelectBtn.Text = "选择";
            this.CFGSelectBtn.UseColumnTextForButtonValue = true;
            this.CFGSelectBtn.Width = 40;
            // 
            // SetupPath
            // 
            this.SetupPath.HeaderText = "Setup文件路径";
            this.SetupPath.Name = "SetupPath";
            this.SetupPath.ReadOnly = true;
            this.SetupPath.Width = 300;
            // 
            // SetupSelectBtn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "选择";
            this.SetupSelectBtn.DefaultCellStyle = dataGridViewCellStyle4;
            this.SetupSelectBtn.HeaderText = "";
            this.SetupSelectBtn.Name = "SetupSelectBtn";
            this.SetupSelectBtn.ReadOnly = true;
            this.SetupSelectBtn.Text = "选择";
            this.SetupSelectBtn.UseColumnTextForButtonValue = true;
            this.SetupSelectBtn.Width = 40;
            // 
            // INI_Btn
            // 
            this.INI_Btn.Location = new System.Drawing.Point(755, 29);
            this.INI_Btn.Name = "INI_Btn";
            this.INI_Btn.Size = new System.Drawing.Size(75, 23);
            this.INI_Btn.TabIndex = 27;
            this.INI_Btn.Text = "选择文件";
            this.INI_Btn.UseVisualStyleBackColor = true;
            this.INI_Btn.Click += new System.EventHandler(this.INI_Btn_Click);
            // 
            // INI_TB
            // 
            this.INI_TB.Location = new System.Drawing.Point(20, 29);
            this.INI_TB.Name = "INI_TB";
            this.INI_TB.ReadOnly = true;
            this.INI_TB.Size = new System.Drawing.Size(728, 21);
            this.INI_TB.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "Calibration File Location(ini file)：";
            // 
            // OK_Btn
            // 
            this.OK_Btn.Location = new System.Drawing.Point(305, 340);
            this.OK_Btn.Name = "OK_Btn";
            this.OK_Btn.Size = new System.Drawing.Size(75, 23);
            this.OK_Btn.TabIndex = 28;
            this.OK_Btn.Text = "确定";
            this.OK_Btn.UseVisualStyleBackColor = true;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(463, 340);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Btn.TabIndex = 29;
            this.Cancel_Btn.Text = "取消";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // ATESet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Btn;
            this.ClientSize = new System.Drawing.Size(842, 375);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.OK_Btn);
            this.Controls.Add(this.INI_Btn);
            this.Controls.Add(this.INI_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ATESetDGV);
            this.Name = "ATESet";
            this.Text = "ATESet";
            this.Load += new System.EventHandler(this.ATESet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ATESetDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ATESetDGV;
        private System.Windows.Forms.Button INI_Btn;
        private System.Windows.Forms.TextBox INI_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog PathSelect_OFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFGPath;
        private System.Windows.Forms.DataGridViewButtonColumn CFGSelectBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetupPath;
        private System.Windows.Forms.DataGridViewButtonColumn SetupSelectBtn;
        private System.Windows.Forms.Button OK_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}