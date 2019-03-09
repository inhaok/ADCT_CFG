using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADCT_CFG.Controller;

namespace ADCT_CFG.View
{
    public partial class ATESet : Form
    {
        ATEFileController m_ATEFileController = new ATEFileController();
        public ATESet()
        {
            InitializeComponent();
        }

        private void INI_Btn_Click(object sender, EventArgs e)
        {
            PathSelect_OFD.Filter = ".ini|*.ini";
            var SelectRes = PathSelect_OFD.ShowDialog();
            if (SelectRes == DialogResult.OK)
            {
                INI_TB.Text = PathSelect_OFD.FileName;
                //ATE2_PB.Value = 0;
            }
        }

        private void ATESetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn m_Column = ATESetDGV.Columns[e.ColumnIndex];
            if (m_Column is DataGridViewButtonColumn)
            {
                if (e.ColumnIndex == 2)
                {
                    PathSelect_OFD.Filter = "CFG文件 | *.cfg";
                }
                else if (e.ColumnIndex == 4)
                {
                    PathSelect_OFD.Filter = "Setup文件 | *.ini";
                }
                var SelectRes = PathSelect_OFD.ShowDialog();
                if (SelectRes == DialogResult.OK)
                {
                    ATESetDGV.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = PathSelect_OFD.FileName;
                }
            }
        }

        private void ATESet_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                int RowsIndex = ATESetDGV.Rows.Add() + 1;
                ATESetDGV.Rows[i].Cells[0].Value = RowsIndex.ToString();
                ATESetDGV.Rows[i].Cells[1].Value = m_ATEFileController.CFGPath1[i];
                ATESetDGV.Rows[i].Cells[3].Value = m_ATEFileController.SetupPath1[i];
            }
            INI_TB.Text = m_ATEFileController.IniPath1;

        }

        private void OK_Btn_Click(object sender, EventArgs e)
        {

            if (INI_TB.Text.Length == 0)
            {
                MessageBox.Show("文件路径不能为空");
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                if (ATESetDGV.Rows[i].Cells[1].Value == null || ATESetDGV.Rows[i].Cells[3].Value == null)
                {
                    MessageBox.Show("文件路径不能为空");
                    return;
                }
                m_ATEFileController.CFGPath1[i] = ATESetDGV.Rows[i].Cells[1].Value.ToString();
                m_ATEFileController.SetupPath1[i] = ATESetDGV.Rows[i].Cells[3].Value.ToString();
            }
            m_ATEFileController.IniPath1 = INI_TB.Text;

            this.DialogResult = DialogResult.OK;
        }


    }
}
