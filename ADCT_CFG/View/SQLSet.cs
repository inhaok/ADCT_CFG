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
    public partial class SQLSet : Form
    {
        SQLController m_SQLController = new SQLController();
        public SQLSet()
        {
            InitializeComponent();
        }

        private void SQLSet_Load(object sender, EventArgs e)
        {
            m_SQLController.LoadSQLIni();
            SQLAddress_TB.Text = m_SQLController.SQLAddress1;
            SQLUserName_TB.Text = m_SQLController.SQLUserName1;
            SQLPwd_TB.Text = m_SQLController.SQLPwd1;
            SQLDataBase_TB.Text = m_SQLController.SQLDataBase1;
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDOK_Btn_Click(object sender, EventArgs e)
        {
            m_SQLController.SQLAddress1 = SQLAddress_TB.Text;
            m_SQLController.SQLUserName1 = SQLUserName_TB.Text;
            m_SQLController.SQLPwd1 = SQLPwd_TB.Text;
            m_SQLController.SetSQLIni();
            this.Close();
        }
    }
}
