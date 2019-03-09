using ADCT_CFG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADCT_CFG.Controller
{
    class FTPController
    {
        private static string FTPAddress = "ftp://120.77.221.153:21/";//FTP的服务器地址，格式为ftp://192.168.1.234:8021/。ip地址和端口换成自己的，这些建议写在配置文件中，方便修改
        private static string FTPUserName = "jimiftp";//FTP服务器的用户名
        private static string FTPPWD = "jimiftp";//FTP服务器的密码

        public string FTPAddress1 { get => FTPAddress; set => FTPAddress = value; }
        public string FTPUserName1 { get => FTPUserName; set => FTPUserName = value; }
        public string FTPPWD1 { get => FTPPWD; set => FTPPWD = value; }
        #region 上传文件
        public bool Upload(string FtpPath, string path, string name, ProgressBar pb)
        {
            GetFTPInit();
            if (FTPModel.UploadFile(FtpPath,path, name, pb))
            {
                return true;
            }
            return false;
        }
        #endregion
        #region 上传多个文件
        public bool UploadList(string FtpPath, string[] path, string[] name, ProgressBar [] progressBars)
        {
            GetFTPInit();
            for (int i = 0; i < 4; i++)
            {
                if (FTPModel.UploadFile(FtpPath, path[i], name[i], progressBars[i]))
                {
                    if (i==3)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        #endregion
        #region 初始化FTP
        public void GetFTPInit()
        {
            FTPModel m_FTPModel = new FTPModel();
            m_FTPModel.GetFTPInit();
        }
        #endregion
        #region 设置配置
        public void SetFTPInit()
        {
            FTPModel m_FTPModel = new FTPModel();
            m_FTPModel.SetFTPInit();
        }
        #endregion
        #region 判断文件是否存在
        public bool CheckFileStatus(string FileName)
        {
            GetFTPInit();
            return FTPModel.fileCheckExist(FileName);
        }
        #endregion
        #region 删除文件
        public bool Delete(string FileName)
        {
            GetFTPInit();
            return FTPModel.DeleteFile(FileName);
        }
        #endregion
        #region 判断目录是否存在
        public bool CheckFTPDirStatus(string path)
        {
            GetFTPInit();
            return FTPModel.RemoteFtpDirExists(path);
        }
        #endregion
        #region 创建目录(如果存在或创建成功 返回true)
        public bool FTPMakeDir(string path)
        {
            GetFTPInit();
            return FTPModel.MakeDir(path);
        }
        #endregion
        #region 删除目录(如果不存在或删除成功 返回true)
        public bool FTPRemoveDir(string path)
        {
            GetFTPInit();
            //获取所有文件 删除后再删目录
            string[] FileList = FTPModel.GetFileList(path);
            if (FileList!=null)
            {
                for (int i = 0; i < FileList.Length; i++)
                {
                    if (FileList[i] == "")
                    {
                        continue;
                    }
                    if (!FTPModel.DeleteFile(path + "\\" + FileList[i]))
                    {
                        return false;
                    }

                }
            }
            return FTPModel.RemoveDir(path);
        }
        #endregion
    }
}
