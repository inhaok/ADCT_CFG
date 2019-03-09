namespace ADCT_CFG.View
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据库配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTP配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PathSelect_OFD = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Path_LB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Setup_PB = new System.Windows.Forms.ProgressBar();
            this.INI_PB = new System.Windows.Forms.ProgressBar();
            this.CFG_PB = new System.Windows.Forms.ProgressBar();
            this.Setup_Btn = new System.Windows.Forms.Button();
            this.Setup_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.INI_Btn = new System.Windows.Forms.Button();
            this.INI_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CFG_Btn = new System.Windows.Forms.Button();
            this.CFG_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ATEDlg_Btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocalPath_LB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalVersionName_TB = new System.Windows.Forms.TextBox();
            this.PathSelect_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UploadSoftware_PB = new System.Windows.Forms.ProgressBar();
            this.Upload_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDGV
            // 
            this.OrderDGV.AllowUserToAddRows = false;
            this.OrderDGV.AllowUserToDeleteRows = false;
            this.OrderDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDGV.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDGV.ColumnHeadersHeight = 25;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.OrderNum,
            this.VersionName,
            this.OrderStatus,
            this.VersionStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDGV.EnableHeadersVisualStyles = false;
            this.OrderDGV.Location = new System.Drawing.Point(12, 28);
            this.OrderDGV.MultiSelect = false;
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.ReadOnly = true;
            this.OrderDGV.RowHeadersVisible = false;
            this.OrderDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderDGV.RowTemplate.Height = 23;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(836, 172);
            this.OrderDGV.TabIndex = 0;
            this.OrderDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrderDGV_CellMouseClick);
            this.OrderDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrderDGV_CellMouseClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 42;
            // 
            // OrderNum
            // 
            this.OrderNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OrderNum.Frozen = true;
            this.OrderNum.HeaderText = "订单号";
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.ReadOnly = true;
            this.OrderNum.Width = 166;
            // 
            // VersionName
            // 
            this.VersionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VersionName.Frozen = true;
            this.VersionName.HeaderText = "软件名";
            this.VersionName.Name = "VersionName";
            this.VersionName.ReadOnly = true;
            this.VersionName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VersionName.Width = 200;
            // 
            // OrderStatus
            // 
            this.OrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OrderStatus.Frozen = true;
            this.OrderStatus.HeaderText = "订单状态";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            this.OrderStatus.Width = 78;
            // 
            // VersionStatus
            // 
            this.VersionStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VersionStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VersionStatus.Frozen = true;
            this.VersionStatus.HeaderText = "软件状态";
            this.VersionStatus.Name = "VersionStatus";
            this.VersionStatus.ReadOnly = true;
            this.VersionStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VersionStatus.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库配置ToolStripMenuItem,
            this.fTP配置ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据库配置ToolStripMenuItem
            // 
            this.数据库配置ToolStripMenuItem.Name = "数据库配置ToolStripMenuItem";
            this.数据库配置ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.数据库配置ToolStripMenuItem.Text = "数据库配置";
            this.数据库配置ToolStripMenuItem.Click += new System.EventHandler(this.数据库配置ToolStripMenuItem_Click);
            // 
            // fTP配置ToolStripMenuItem
            // 
            this.fTP配置ToolStripMenuItem.Name = "fTP配置ToolStripMenuItem";
            this.fTP配置ToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.fTP配置ToolStripMenuItem.Text = "FTP配置";
            this.fTP配置ToolStripMenuItem.Click += new System.EventHandler(this.fTP配置ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Enabled = false;
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "文件路径：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Path_LB
            // 
            this.Path_LB.BackColor = System.Drawing.Color.White;
            this.Path_LB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Path_LB.Location = new System.Drawing.Point(93, 17);
            this.Path_LB.Name = "Path_LB";
            this.Path_LB.Size = new System.Drawing.Size(433, 23);
            this.Path_LB.TabIndex = 2;
            this.Path_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Path_LB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.ATEDlg_Btn);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.Upload_Btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 410);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置上传";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Setup_PB);
            this.groupBox4.Controls.Add(this.INI_PB);
            this.groupBox4.Controls.Add(this.CFG_PB);
            this.groupBox4.Controls.Add(this.Setup_Btn);
            this.groupBox4.Controls.Add(this.Setup_TB);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.INI_Btn);
            this.groupBox4.Controls.Add(this.INI_TB);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.CFG_Btn);
            this.groupBox4.Controls.Add(this.CFG_TB);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(824, 223);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "射频文件";
            // 
            // Setup_PB
            // 
            this.Setup_PB.ForeColor = System.Drawing.Color.Green;
            this.Setup_PB.Location = new System.Drawing.Point(9, 185);
            this.Setup_PB.Name = "Setup_PB";
            this.Setup_PB.Size = new System.Drawing.Size(727, 10);
            this.Setup_PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Setup_PB.TabIndex = 13;
            // 
            // INI_PB
            // 
            this.INI_PB.ForeColor = System.Drawing.Color.Green;
            this.INI_PB.Location = new System.Drawing.Point(8, 120);
            this.INI_PB.Name = "INI_PB";
            this.INI_PB.Size = new System.Drawing.Size(728, 10);
            this.INI_PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.INI_PB.TabIndex = 12;
            // 
            // CFG_PB
            // 
            this.CFG_PB.ForeColor = System.Drawing.Color.Green;
            this.CFG_PB.Location = new System.Drawing.Point(8, 59);
            this.CFG_PB.Name = "CFG_PB";
            this.CFG_PB.Size = new System.Drawing.Size(727, 10);
            this.CFG_PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CFG_PB.TabIndex = 11;
            // 
            // Setup_Btn
            // 
            this.Setup_Btn.Location = new System.Drawing.Point(743, 158);
            this.Setup_Btn.Name = "Setup_Btn";
            this.Setup_Btn.Size = new System.Drawing.Size(75, 23);
            this.Setup_Btn.TabIndex = 10;
            this.Setup_Btn.Text = "选择文件";
            this.Setup_Btn.UseVisualStyleBackColor = true;
            this.Setup_Btn.Click += new System.EventHandler(this.Setup_Btn_Click);
            // 
            // Setup_TB
            // 
            this.Setup_TB.Location = new System.Drawing.Point(8, 158);
            this.Setup_TB.Name = "Setup_TB";
            this.Setup_TB.ReadOnly = true;
            this.Setup_TB.Size = new System.Drawing.Size(728, 21);
            this.Setup_TB.TabIndex = 9;
            this.Setup_TB.Text = "D:\\ADCT\\SMT_ADCT-3in1\\Release\\config\\MTK_6260_Setup_20140726.ini";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Test Steup File Location(Setup File)";
            // 
            // INI_Btn
            // 
            this.INI_Btn.Location = new System.Drawing.Point(743, 93);
            this.INI_Btn.Name = "INI_Btn";
            this.INI_Btn.Size = new System.Drawing.Size(75, 23);
            this.INI_Btn.TabIndex = 7;
            this.INI_Btn.Text = "选择文件";
            this.INI_Btn.UseVisualStyleBackColor = true;
            this.INI_Btn.Click += new System.EventHandler(this.INI_Btn_Click_1);
            // 
            // INI_TB
            // 
            this.INI_TB.Location = new System.Drawing.Point(8, 93);
            this.INI_TB.Name = "INI_TB";
            this.INI_TB.ReadOnly = true;
            this.INI_TB.Size = new System.Drawing.Size(728, 21);
            this.INI_TB.TabIndex = 6;
            this.INI_TB.Text = "D:\\ADCT\\SMT_ADCT-3in1\\Release\\config\\MT6261+RF7198_20150625.ini";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Calibration File Location(ini file)";
            // 
            // CFG_Btn
            // 
            this.CFG_Btn.Location = new System.Drawing.Point(743, 32);
            this.CFG_Btn.Name = "CFG_Btn";
            this.CFG_Btn.Size = new System.Drawing.Size(75, 23);
            this.CFG_Btn.TabIndex = 4;
            this.CFG_Btn.Text = "选择文件";
            this.CFG_Btn.UseVisualStyleBackColor = true;
            this.CFG_Btn.Click += new System.EventHandler(this.CFG_Btn_Click);
            // 
            // CFG_TB
            // 
            this.CFG_TB.Location = new System.Drawing.Point(8, 32);
            this.CFG_TB.Name = "CFG_TB";
            this.CFG_TB.ReadOnly = true;
            this.CFG_TB.Size = new System.Drawing.Size(728, 21);
            this.CFG_TB.TabIndex = 1;
            this.CFG_TB.Text = "D:\\ADCT\\SMT_ADCT-3in1\\Release\\config\\MT6261+RF7198_20141015(1).CFG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Config File Location(CFG file)";
            // 
            // ATEDlg_Btn
            // 
            this.ATEDlg_Btn.Location = new System.Drawing.Point(734, 381);
            this.ATEDlg_Btn.Name = "ATEDlg_Btn";
            this.ATEDlg_Btn.Size = new System.Drawing.Size(96, 23);
            this.ATEDlg_Btn.TabIndex = 10;
            this.ATEDlg_Btn.Text = "ATE文件设置";
            this.ATEDlg_Btn.UseVisualStyleBackColor = true;
            this.ATEDlg_Btn.Visible = false;
            this.ATEDlg_Btn.Click += new System.EventHandler(this.ATEDlg_Btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LocalPath_LB);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.LocalVersionName_TB);
            this.groupBox3.Controls.Add(this.PathSelect_Btn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.UploadSoftware_PB);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(824, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "软件";
            // 
            // LocalPath_LB
            // 
            this.LocalPath_LB.Location = new System.Drawing.Point(86, 56);
            this.LocalPath_LB.Name = "LocalPath_LB";
            this.LocalPath_LB.ReadOnly = true;
            this.LocalPath_LB.Size = new System.Drawing.Size(650, 21);
            this.LocalPath_LB.TabIndex = 8;
            this.LocalPath_LB.Text = "C:\\Users\\zhk\\Desktop\\配置文件\\GT02F_32_61DM2R1_D23_R0_V15_20171111_1540.rar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "软件包路径：";
            // 
            // LocalVersionName_TB
            // 
            this.LocalVersionName_TB.Location = new System.Drawing.Point(86, 24);
            this.LocalVersionName_TB.Name = "LocalVersionName_TB";
            this.LocalVersionName_TB.Size = new System.Drawing.Size(392, 21);
            this.LocalVersionName_TB.TabIndex = 7;
            this.LocalVersionName_TB.Text = "GT02F_32_61DM2R1_D23_R0_V15";
            // 
            // PathSelect_Btn
            // 
            this.PathSelect_Btn.Location = new System.Drawing.Point(743, 54);
            this.PathSelect_Btn.Name = "PathSelect_Btn";
            this.PathSelect_Btn.Size = new System.Drawing.Size(75, 23);
            this.PathSelect_Btn.TabIndex = 3;
            this.PathSelect_Btn.Text = "选择文件";
            this.PathSelect_Btn.UseVisualStyleBackColor = true;
            this.PathSelect_Btn.Click += new System.EventHandler(this.PathSelect_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "软件名：";
            // 
            // UploadSoftware_PB
            // 
            this.UploadSoftware_PB.ForeColor = System.Drawing.Color.Green;
            this.UploadSoftware_PB.Location = new System.Drawing.Point(86, 81);
            this.UploadSoftware_PB.Name = "UploadSoftware_PB";
            this.UploadSoftware_PB.Size = new System.Drawing.Size(650, 10);
            this.UploadSoftware_PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.UploadSoftware_PB.TabIndex = 5;
            // 
            // Upload_Btn
            // 
            this.Upload_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Upload_Btn.Location = new System.Drawing.Point(382, 381);
            this.Upload_Btn.Name = "Upload_Btn";
            this.Upload_Btn.Size = new System.Drawing.Size(75, 23);
            this.Upload_Btn.TabIndex = 4;
            this.Upload_Btn.Text = "上传";
            this.Upload_Btn.UseVisualStyleBackColor = true;
            this.Upload_Btn.Click += new System.EventHandler(this.Upload_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(860, 754);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrderDGV);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "软件配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据库配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog PathSelect_OFD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Path_LB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PathSelect_Btn;
        private System.Windows.Forms.Button Upload_Btn;
        private System.Windows.Forms.ProgressBar UploadSoftware_PB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LocalVersionName_TB;
        private System.Windows.Forms.TextBox LocalPath_LB;
        public System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.ToolStripMenuItem fTP配置ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VersionStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ATEDlg_Btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CFG_Btn;
        private System.Windows.Forms.TextBox CFG_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Setup_Btn;
        private System.Windows.Forms.TextBox Setup_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button INI_Btn;
        private System.Windows.Forms.TextBox INI_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar Setup_PB;
        private System.Windows.Forms.ProgressBar INI_PB;
        private System.Windows.Forms.ProgressBar CFG_PB;
    }
}

