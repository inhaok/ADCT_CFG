using ADCT_CFG.Controller;
using ADCT_CFG.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;

namespace ADCT_CFG.View
{
    public partial class MainForm : Form
    {
        //[DllImport("DgvFilterPopup", EntryPoint = "DgvFilterManager")]
        //public static extern DgvFilterManager DgvFilterManager(DataGridView dataGridView);
        OrderController m_OrderController = new OrderController();
        SQLController m_SQLController = new SQLController();
        FTPController m_FTPController = new FTPController();
        ATEFileController m_ATEFileController = new ATEFileController();

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DgvFilterManager fm = new DgvFilterManager(OrderDGV);
            OrderRefresh();


            //m_OrderController.FindVerionRecord();


        }

        private void OrderRefresh()
        {
            m_OrderController.GetAllZhiDan();
            ds = new DataSet();
            dt = new DataTable();
            m_OrderController.SqlDataAdapter1.Fill(ds);

            dt = ds.Tables[0];
            //ds = m_OrderController.m_DataSet;
            OrderDGV.AutoGenerateColumns = false;

            OrderDGV.Columns["ID"].DataPropertyName = ds.Tables[0].Columns["Id"].ToString();
            OrderDGV.Columns["OrderNum"].DataPropertyName = ds.Tables[0].Columns["ZhiDan"].ToString();
            OrderDGV.Columns["VersionName"].DataPropertyName = ds.Tables[0].Columns["Version"].ToString();
            OrderDGV.Columns["OrderStatus"].DataPropertyName = ds.Tables[0].Columns["Status"].ToString();

            OrderDGV.DataSource = ds.Tables[0];
            for (int i = 0; i < OrderDGV.RowCount; i++)
            {

                if (dt.Rows[i][4].ToString() == "true")
                {
                    OrderDGV.Rows[i].Cells[4].Value = true;
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLSet m_SQLSet = new SQLSet();
            m_SQLSet.ShowDialog();
            OrderRefresh();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出程序？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;

            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void OrderDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            Path_LB.Text = ds.Tables[0].Rows[e.RowIndex][5].ToString();
        }

        private void PathSelect_Btn_Click(object sender, EventArgs e)
        {
            PathSelect_OFD.Filter = "压缩文件 | *.zip; *.rar";
            var SelectRes = PathSelect_OFD.ShowDialog();
            if (SelectRes == DialogResult.OK)
            {
                LocalPath_LB.Text = PathSelect_OFD.FileName;
                UploadSoftware_PB.Value = 0;
            }
        }

        private void Upload_Btn_Click(object sender, EventArgs e)
        {
            if (LocalVersionName_TB.Text.Length == 0)
            {
                MessageBox.Show("软件名不能为空");
                return;
            }
            if (LocalPath_LB.Text.Length == 0)
            {
                MessageBox.Show("软件包路径不能为空");
                return;
            }

            //if (m_ATEFileController.CFGPath1 == null || m_ATEFileController.SetupPath1 == null)
            //{
            //    MessageBox.Show("ATE文件路径不能为空");
            //    return;
            //}

            //if (m_ATEFileController.IniPath1 == null)
            //{
            //    MessageBox.Show("ATE文件路径不能为空");
            //    return;
            //}




            string[] ListText = new string[4];
            ListText[0] = LocalPath_LB.Text;
            ListText[1] = INI_TB.Text;
            ListText[2] = CFG_TB.Text;
            ListText[3] = Setup_TB.Text;
            ProgressBar[] PBList = new ProgressBar[4];
            PBList[0] = UploadSoftware_PB;
            PBList[1] = CFG_PB;
            PBList[2] = INI_PB;
            PBList[3] = Setup_PB;
            //ListText[1] = m_ATEFileController.IniPath1;
            //for (int i = 2; i < 6; i++)
            //{
            //    ListText[i] = m_ATEFileController.CFGPath1[i - 2];
            //    ListText[i + 4] = m_ATEFileController.SetupPath1[i - 2];
            //}
            int[] LastOfIndex = new int[4];
            //string FtpPath;
            string[] FileName = new string[4];
            for (int i = 0; i < 4; i++)
            {
                LastOfIndex[i] = ListText[i].LastIndexOf("\\");
                //FtpPath = LocalPath_LB.Text.Substring(0, LastOfIndex[i]);
                FileName[i] = ListText[i].Substring(LastOfIndex[i] + 1, ListText[i].Length - LastOfIndex[i] - 1);
            }




            if (m_OrderController.FindVerionRecord(LocalVersionName_TB.Text))
            {
                if (MessageBox.Show("版本已存在，是否更新", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (m_FTPController.CheckFTPDirStatus(LocalVersionName_TB.Text))
                    {
                        if (m_FTPController.FTPRemoveDir(LocalVersionName_TB.Text))
                        {
                            FTPUpdateFileAndSQL(ListText, PBList, FileName);
                        }

                    }
                    else
                    {
                        FTPUpdateFileAndSQL(ListText, PBList, FileName);
                    }
                }
            }
            else
            {
                if (m_FTPController.CheckFTPDirStatus(LocalVersionName_TB.Text))
                {
                    if (MessageBox.Show("文件已存在，是否上传", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (m_FTPController.FTPRemoveDir(LocalVersionName_TB.Text))
                        {
                            FTPUploadFileAndSQL(ListText, PBList, FileName);
                        }
                    }
                }
                else
                {
                    FTPUploadFileAndSQL(ListText, PBList, FileName);
                }
            }
            OrderRefresh();
        }

        private void FTPUploadFileAndSQL(string[] ListText, ProgressBar[] PBList, string[] FileName)
        {
            if (m_FTPController.FTPMakeDir(LocalVersionName_TB.Text))
            {
                if (m_FTPController.UploadList(LocalVersionName_TB.Text, ListText, FileName, PBList))
                {
                    if (!m_OrderController.UploadVerion(LocalVersionName_TB.Text, FileName, ListText))
                    {
                        MessageBox.Show("数据库添加版本和配置数据发生错误");
                        return;
                    }
                    MessageBox.Show("上传成功");
                }
                else
                {
                    MessageBox.Show("文件上传失败");
                }
            }
        }

        private void FTPUpdateFileAndSQL(string[] ListText, ProgressBar[] PBList, string[] FileName)
        {
            if (m_FTPController.FTPMakeDir(LocalVersionName_TB.Text))
            {
                if (m_FTPController.UploadList(LocalVersionName_TB.Text, ListText, FileName, PBList))
                {
                    if (!m_OrderController.UpdateVerion(LocalVersionName_TB.Text, "/"+LocalVersionName_TB.Text + "/" + FileName[0], ListText))
                    {
                        MessageBox.Show("更新版本表失败");
                        return;
                    }
                    if (!m_OrderController.UpdateConfig(LocalVersionName_TB.Text, "/" + LocalVersionName_TB.Text + "/"+FileName[1], "/" + LocalVersionName_TB.Text + "/"+FileName[2], "/" + LocalVersionName_TB.Text + "/"+FileName[3], ListText))
                    {
                        MessageBox.Show("更新配置表失败");
                        return;
                    }
                    MessageBox.Show("上传成功");
                }
                else
                {
                    MessageBox.Show("文件上传失败");
                }
            }
        }

        private void OrderDGV_CellMouseClick(object sender, MouseEventArgs e)
        {

        }

        private void MultiDownloadSet_Btn_Click(object sender, EventArgs e)
        {
        }

        private void fTP配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTPSet m_FTPSet = new FTPSet();
            m_FTPSet.ShowDialog();
            OrderRefresh();
        }

        private void UploadDownloadParam_Click(object sender, EventArgs e)
        {

        }



        private void INI_Btn_Click(object sender, EventArgs e)
        {

        }

        private void ATEDlg_Btn_Click(object sender, EventArgs e)
        {
            ATESet Form = new ATESet();
            Form.ShowDialog();
        }

        private void CFG_Btn_Click(object sender, EventArgs e)
        {
            PathSelect_OFD.Filter = "CFG文件 | *.cfg";
            var SelectRes = PathSelect_OFD.ShowDialog();
            if (SelectRes == DialogResult.OK)
            {
                CFG_TB.Text = PathSelect_OFD.FileName;
                CFG_PB.Value = 0;
            }
        }

        private void INI_Btn_Click_1(object sender, EventArgs e)
        {
            PathSelect_OFD.Filter = ".ini|*.ini";
            var SelectRes = PathSelect_OFD.ShowDialog();
            if (SelectRes == DialogResult.OK)
            {
                INI_TB.Text = PathSelect_OFD.FileName;
                INI_PB.Value = 0;
            }
        }

        private void Setup_Btn_Click(object sender, EventArgs e)
        {
            PathSelect_OFD.Filter = "Setup文件 | *.ini";
            var SelectRes = PathSelect_OFD.ShowDialog();
            if (SelectRes == DialogResult.OK)
            {
                Setup_TB.Text = PathSelect_OFD.FileName;
                Setup_PB.Value = 0;
            }
        }
    }
}
