using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ADCT_CFG.Model
{
    public class OperateIniFile
    {
        #region API函数声明

        [DllImport("kernel32",  SetLastError = true)]//返回0表示失败，非0为成功
        private static extern long WritePrivateProfileString(string section, string key,
            string val, string filePath);

        [DllImport("kernel32",  SetLastError = true)]//返回取得字符串缓冲区的长度
        private static extern long GetPrivateProfileString(string section, string key,
            string def, StringBuilder retVal, int size, string filePath);

        [System.Runtime.InteropServices.DllImport("kernel32")]
        public extern static int FormatMessage(int flag, ref IntPtr source, int msgid, int langid, ref string buf, int size, ref IntPtr args);

        /// <summary>
        /// 获取系统错误信息描述
        /// </summary>
        /// <param name="errCode">系统错误码</param>
        /// <returns></returns>
        public static string GetSysErrMsg(int errCode)
        {
            IntPtr tempptr = IntPtr.Zero;
            string msg = null;
            FormatMessage(0x1300, ref tempptr, errCode, 0, ref msg, 255, ref tempptr);
            return msg;
        }

        private static string IniFilePath = AppDomain.CurrentDomain.BaseDirectory + "ADCT_CFG.ini";
        #endregion

        #region 读Ini文件

        public string ReadIniData(string Section, string Key, string NoText)
        {
            if (!File.Exists(IniFilePath))
            {
                CreatDefIni();
            }

            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(Section, Key, NoText, temp, 1024, IniFilePath);
            return temp.ToString();
        }

        #endregion

        #region 写Ini文件

        public bool WriteIniData(string Section, string Key, string Value)
        {
            if (!File.Exists(IniFilePath))
            {
                CreatDefIni();
            }

            long OpStation = WritePrivateProfileString(Section, Key, Value, IniFilePath);
            if (OpStation == 0)
            {
                int errCode = Marshal.GetLastWin32Error();
                MessageBox.Show(GetSysErrMsg(errCode));
                return false;
               
            }
            else
            {
                return true;
            }

        }

        #endregion
        #region 创建默认INI配置
        private void CreatDefIni()
        {
            MessageBox.Show("Ini文件丢失，重新创建默认配置，恢复所有参数");
            FileStream m_IniFile=File.Create(IniFilePath);
            m_IniFile.Close();
            WriteIniData("SQLSetting", "SQLAddress", "10.10.11.90,6033");
            WriteIniData("SQLSetting", "SQLUserName", "sa");
            WriteIniData("SQLSetting", "SQLPwd", "jiminewpower");
            WriteIniData("SQLSetting", "SQLDataBase", "GPSTest");
            WriteIniData("SQLSetting", "SQLAddress", "ftp://120.77.221.153:21/");
            WriteIniData("SQLSetting", "SQLUserName", "jimiftp");
            WriteIniData("SQLSetting", "SQLPwd", "jimiftp");
        }
        #endregion
    }
}