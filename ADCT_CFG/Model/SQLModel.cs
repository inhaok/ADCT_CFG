using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ADCT_CFG.Controller;

namespace ADCT_CFG.Model
{
    class SQLModel
    {
        SqlConnection m_sConnection = null;
        SqlCommand m_sCmd = null;
        OperateIniFile m_IniFile=new OperateIniFile();
        SQLController m_SQLController=new SQLController();
        string m_ConnectStr = "";
        public void GetSQLInit()
        {
           
            m_SQLController.SQLAddress1 = m_IniFile.ReadIniData("SQLSetting", "SQLAddress", "10.10.11.90,6033");
            m_SQLController.SQLUserName1 = m_IniFile.ReadIniData("SQLSetting", "SQLUserName", "sa");
            m_SQLController.SQLPwd1 = m_IniFile.ReadIniData("SQLSetting", "SQLPwd", "jiminewpower");
            m_SQLController.SQLDataBase1 = m_IniFile.ReadIniData("SQLSetting", "SQLDataBase", "GPSTest");
            m_ConnectStr = "server = " + m_SQLController.SQLAddress1 + "; uid = " + m_SQLController.SQLUserName1 + "; pwd = " + m_SQLController.SQLPwd1 + "; database = " + m_SQLController.SQLDataBase1 + "";
        }
        public void SetSQLInit()
        {
            m_IniFile.WriteIniData("SQLSetting", "SQLAddress", m_SQLController.SQLAddress1);
            m_IniFile.WriteIniData("SQLSetting", "SQLUserName", m_SQLController.SQLUserName1);
            m_IniFile.WriteIniData("SQLSetting", "SQLPwd", m_SQLController.SQLPwd1);
            m_IniFile.WriteIniData("SQLSetting", "SQLDataBase", m_SQLController.SQLDataBase1);
        }
        public bool SQLConnect()
        {
            GetSQLInit();
            try
            {
                m_sConnection = new SqlConnection(m_ConnectStr);
                m_sConnection.Open();
                return true;
                //MessageBox.Show("数据库连接成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败:{0}", ex.Message);
                return false;
                //throw;
            }
        }
        public bool SQLCommand(string CommandStr)
        {
            try
            {

                using (m_sCmd = new SqlCommand(CommandStr, m_sConnection))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库执行语句失败:{0}", ex.Message);
                return false;
            }
        }
        public SqlDataReader SQLDataReader()
        {
            try
            {
                SqlDataReader m_Sdr = m_sCmd.ExecuteReader();
                return m_Sdr;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public SqlDataAdapter SQLDataAdapter(string CommandStr)
        {
            GetSQLInit();
            try
            {
                SqlConnection conn = new SqlConnection(m_ConnectStr);
                SqlDataAdapter m_SQLDataAdapter = new SqlDataAdapter(CommandStr,conn);
                DataSet ds = new DataSet();
                m_SQLDataAdapter.Fill(ds);
                return m_SQLDataAdapter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据源获取失败:{0}", ex.Message);
                return null;
            }
        }
        public bool SQLDisconnect()
        {
            try
            {
                m_sConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据源断开失败:{0}", ex.Message);
                return false;
            }
        }

    }
}
