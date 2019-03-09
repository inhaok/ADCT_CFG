using ADCT_CFG.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADCT_CFG.View
{
    public partial class FTPSet : Form
    {
        FTPController m_FTPController = new FTPController();
        public FTPSet()
        {
            InitializeComponent();
        }

        private void IDOK_Btn_Click(object sender, EventArgs e)
        {
            m_FTPController.FTPAddress1 = FTPAddress_TB.Text;
            m_FTPController.FTPUserName1 = FTPUserName_TB.Text;
            m_FTPController.FTPPWD1 = FTPPWD_TB.Text;
            m_FTPController.SetFTPInit();
            this.Close();
        }

        private void FTPSet_Load(object sender, EventArgs e)
        {
            m_FTPController.GetFTPInit();
            FTPAddress_TB.Text = m_FTPController.FTPAddress1;
            FTPUserName_TB.Text = m_FTPController.FTPUserName1;
            FTPPWD_TB.Text = m_FTPController.FTPPWD1;
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
