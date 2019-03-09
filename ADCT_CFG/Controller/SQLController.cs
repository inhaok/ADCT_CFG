using ADCT_CFG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADCT_CFG.Controller
{
    public class SQLController
    {
        
        static string SQLAddress;
        static string SQLUserName;
        static string SQLPwd;
        static string SQLDataBase;

        public string SQLAddress1 { get => SQLAddress; set => SQLAddress = value; }
        public string SQLUserName1 { get => SQLUserName; set => SQLUserName = value; }
        public string SQLPwd1 { get => SQLPwd; set => SQLPwd = value; }
        public string SQLDataBase1 { get => SQLDataBase; set => SQLDataBase = value; }

        public void LoadSQLIni()
        {
            SQLModel m_SQLMode = new SQLModel();
            m_SQLMode.GetSQLInit();
        }
        public bool SQLDisconnect()
        {
            SQLModel m_SQLMode = new SQLModel();
            return m_SQLMode.SQLDisconnect();
        }
        public void SetSQLIni()
        {
            SQLModel m_SQLMode = new SQLModel();
            m_SQLMode.SetSQLInit();
        }
    }
}
