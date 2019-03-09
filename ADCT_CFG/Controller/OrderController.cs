using ADCT_CFG.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace ADCT_CFG.Controller
{
    class OrderController
    {
        static string ZhiDan;
        static string Version;
        static int Status;
        static SqlDataReader sqlDataReader;
        static SqlDataAdapter sqlDataAdapter;
        static List<string> VerionList;
        public SqlDataReader SqlDataReader1 { get => sqlDataReader; set => sqlDataReader = value; }
        public string ZhiDan1 { get => ZhiDan; set => ZhiDan = value; }
        public string Version1 { get => Version; set => Version = value; }
        public int Status1 { get => Status; set => Status = value; }
        public SqlDataAdapter SqlDataAdapter1 { get => sqlDataAdapter; set => sqlDataAdapter = value; }
        public List<string> VerionList1 { get => VerionList; set => VerionList = value; }

        public void GetAllZhiDan()
        {
            SQLModel m_SQLModel = new SQLModel();
            const string CommandStr = "select a.Id, a.ZhiDan,a.Version, a.Status, 'IFhave' = CASE WHEN a.Version=b.VersionName THEN 'true' ELSE 'false' END," +
                " b.Path from(SELECT dbo.Gps_ManuOrderParam.Id, dbo.Gps_ManuOrderParam.ZhiDan, dbo.Gps_ManuOrderParam.Version, dbo.Gps_ManuOrderParam.Status " +
                "FROM dbo.Gps_ManuOrderParam WHERE dbo.Gps_ManuOrderParam.Status = 0 OR dbo.Gps_ManuOrderParam.Status = 1) a " +
                "left join dbo.ADCT_Version b on a.Version = b.VersionName";
            SqlDataAdapter1 = null;
            SqlDataAdapter1 = m_SQLModel.SQLDataAdapter(CommandStr);

            //m_SQLModel.SQLDisconnect();
        }
        public bool FindVerionRecord(string VersionStr)
        {
            SQLModel m_SQLModel = new SQLModel();
            if (m_SQLModel.SQLConnect())
            {
                string CommandStr = "SELECT ADCT_Version.VersionName" +
                " FROM ADCT_Version,ADCT_Config WHERE ADCT_Version.VersionName= '" + VersionStr + "' AND ADCT_Version.VersionName=ADCT_Config.Version";
                m_SQLModel.SQLCommand(CommandStr);
                SqlDataReader1 = m_SQLModel.SQLDataReader();
                bool ReadRes = SqlDataReader1.Read();
                m_SQLModel.SQLDisconnect();
                return ReadRes;
            }
            return false;
        }
        #region 上传文件添加版本表和配置表
        public bool UploadVerion(string VersionName, string[] FtpFilePath, string[] LocalPath)
        {
            try
            {
                FileInfo SoftwareInfo = new FileInfo(LocalPath[0]);
                FileInfo IniInfo = new FileInfo(LocalPath[1]);
                FileInfo CFGInfo = new FileInfo(LocalPath[2]);
                FileInfo SetupInfo = new FileInfo(LocalPath[3]);
                SQLModel m_SQLModel = new SQLModel();
                if (m_SQLModel.SQLConnect())
                {
                    string CommandStr = "INSERT INTO ADCT_Version (VersionName, Path, [Size]) VALUES('" + VersionName + "', '/" + VersionName + "/" + FtpFilePath[0] + "', " + SoftwareInfo.Length + ")" +
    "INSERT INTO ADCT_Config(Version, IniPath, CFGPath, SetupPath,IniSize,CFGSize,SetupSize) VALUES('" + VersionName + "', '/" + VersionName + "/" + FtpFilePath[1] + "', '/" + VersionName + "/" + FtpFilePath[2] + "', '/" + VersionName + "/" + FtpFilePath[3] + "'," +
    ""+IniInfo.Length+","+CFGInfo.Length+","+SetupInfo.Length+")";
                    m_SQLModel.SQLCommand(CommandStr);
                    SqlDataReader1 = m_SQLModel.SQLDataReader();
                    if (SqlDataReader1 == null)
                    {
                        SqlDataReader1.Close();
                        m_SQLModel.SQLDisconnect();
                        return false;
                    }
                    else
                    {
                        SqlDataReader1.Close();
                        m_SQLModel.SQLDisconnect();
                        return true;
                    }

                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion
        #region 更改版本表
        public bool UpdateVerion(string VersionName, string FtpSoftwarePath, string[] LocalPath)
        {
            try
            {
                FileInfo SoftwareInfo = new FileInfo(LocalPath[0]);
                SQLModel m_SQLModel = new SQLModel();
                string CommandStr = "SELECT ID,VersionName,Path,[Size] FROM dbo.ADCT_Version";
                SqlDataAdapter1 = m_SQLModel.SQLDataAdapter(CommandStr);
                SqlCommandBuilder sqlBulider = new SqlCommandBuilder(SqlDataAdapter1);
                //SqlDataAdapter1.UpdateCommand()
                DataSet ds = new DataSet();
                SqlDataAdapter1.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    return false;
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][1].ToString() == VersionName)
                    {
                        ds.Tables[0].Rows[i][2] = FtpSoftwarePath;
                        ds.Tables[0].Rows[i][3] = SoftwareInfo.Length;
                    }
                }
                SqlDataAdapter1.Update(ds);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion
        #region 更改配置表
        public bool UpdateConfig(string VersionName, string IniPath, string CFGPath, string SetupPath,string[] LocalPath)
        {
            try
            {

                FileInfo IniInfo = new FileInfo(LocalPath[1]);
                FileInfo CFGInfo = new FileInfo(LocalPath[2]);
                FileInfo SetupInfo = new FileInfo(LocalPath[3]);
                SQLModel m_SQLModel = new SQLModel();
                string CommandStr = "SELECT\n" +
                "dbo.ADCT_Config.Version,\n" +
                "dbo.ADCT_Config.IniPath,\n" +
                "dbo.ADCT_Config.CFGPath,\n" +
                "dbo.ADCT_Config.SetupPath,\n" +
                "dbo.ADCT_Config.IniSize,\n" +
                "dbo.ADCT_Config.CFGSize,\n" +
                "dbo.ADCT_Config.SetupSize\n" +
                "FROM\n" +
                "dbo.ADCT_Config";
                SqlDataAdapter1 = m_SQLModel.SQLDataAdapter(CommandStr);
                SqlCommandBuilder sqlBulider = new SqlCommandBuilder(SqlDataAdapter1);
                //SqlDataAdapter1.UpdateCommand()
                DataSet ds = new DataSet();
                SqlDataAdapter1.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    return false;
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][0].ToString() == VersionName)
                    {
                        ds.Tables[0].Rows[i][1] = IniPath;
                        ds.Tables[0].Rows[i][2] = CFGPath;
                        ds.Tables[0].Rows[i][3] = SetupPath;
                        ds.Tables[0].Rows[i][4] = IniInfo.Length;
                        ds.Tables[0].Rows[i][5] = CFGInfo.Length;
                        ds.Tables[0].Rows[i][6] = SetupInfo.Length;
                    }
                }
               SqlDataAdapter1.Update(ds);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion
    }
}
