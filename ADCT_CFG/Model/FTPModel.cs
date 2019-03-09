using ADCT_CFG.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ADCT_CFG.Model
{
    class FTPModel
    {
        OperateIniFile m_IniFile = new OperateIniFile();
        FTPController m_FTPController = new FTPController();
        private static string m_FTPAddress = "";
        private static string m_FTPUserName = "";
        private static string m_FTPPWD = "";

        #region FTP配置初始化
        public void GetFTPInit()
        {
            m_FTPController.FTPAddress1 = m_IniFile.ReadIniData("FTPSetting", "FTPAddress", "ftp://120.77.221.153:21/");
            m_FTPController.FTPUserName1 = m_IniFile.ReadIniData("FTPSetting", "FTPUserName", "jimiftp");
            m_FTPController.FTPPWD1 = m_IniFile.ReadIniData("FTPSetting", "FTPPWD", "jimiftp");
            m_FTPAddress = m_FTPController.FTPAddress1;
            m_FTPUserName = m_FTPController.FTPUserName1;
            m_FTPPWD = m_FTPController.FTPPWD1;
        }

        #endregion
        #region 设置FTP配置
        public void SetFTPInit()
        {
            m_IniFile.WriteIniData("FTPSetting", "FTPAddress", m_FTPController.FTPAddress1);
            m_IniFile.WriteIniData("FTPSetting", "FTPUserName", m_FTPController.FTPUserName1);
            m_IniFile.WriteIniData("FTPSetting", "FTPPWD", m_FTPController.FTPPWD1);
        }
        #endregion

        #region 本地文件上传到FTP服务器
        /// <summary>
        /// 上传文件到远程ftp
        /// </summary>
        /// <param name="path">本地的文件目录</param>
        /// <param name="name">文件名称</param>
        /// <returns></returns>
        public static bool UploadFile(string path, string name)
        {
            string erroinfo = "";
            FileInfo f = new FileInfo(path);
            path = path.Replace("\\", "/");
            path = m_FTPAddress + "/data/uploadFile/photo/" + name;//这个路径是我要传到ftp目录下的这个目录下
            FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(path));
            reqFtp.UseBinary = true;
            reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
            reqFtp.KeepAlive = false;
            reqFtp.Method = WebRequestMethods.Ftp.UploadFile;
            reqFtp.ContentLength = f.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = f.OpenRead();
            try
            {
                Stream strm = reqFtp.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                strm.Close();
                fs.Close();
                erroinfo = "完成";
                return true;
            }
            catch (Exception ex)
            {
                erroinfo = string.Format("因{0},无法完成上传", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 上传文件到远程ftp
        /// </summary>
        /// <param name="ftpPath">ftp上的文件路径</param>
        /// <param name="path">本地的文件目录</param>
        /// <param name="id">文件名</param>
        /// <returns></returns>
        public static bool UploadFile(string ftpPath, string path, string id)
        {
            string erroinfo = "";
            FileInfo f = new FileInfo(path);
            path = path.Replace("\\", "/");
            bool b = MakeDir(ftpPath);
            if (b == false)
            {
                return false;
            }
            path = m_FTPAddress + ftpPath + id;
            FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(path));
            reqFtp.UseBinary = true;
            reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
            reqFtp.KeepAlive = false;
            reqFtp.Method = WebRequestMethods.Ftp.UploadFile;
            reqFtp.ContentLength = f.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = f.OpenRead();
            try
            {
                Stream strm = reqFtp.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                strm.Close();
                fs.Close();
                erroinfo = "完成";
                return true;
            }
            catch (Exception ex)
            {
                erroinfo = string.Format("因{0},无法完成上传", ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="path">本地的文件目录</param>
        /// <param name="name">文件名称</param>
        /// <param name="pb">进度条</param>
        /// <returns></returns>
        public static bool UploadFile(string path, string name, ProgressBar pb)
        {
            string erroinfo = "";
            float percent = 0;
            FileInfo f = new FileInfo(path);
            path = path.Replace("\\", "/");
            path = m_FTPAddress + name;
            FtpWebRequest reqFtp = (FtpWebRequest)WebRequest.Create(new Uri(path));
            reqFtp.UseBinary = true;
            reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
            reqFtp.KeepAlive = false;
            reqFtp.UsePassive = false;
            reqFtp.Method = WebRequestMethods.Ftp.UploadFile;
            reqFtp.ContentLength = f.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = f.OpenRead();
            int allbye = (int)f.Length;
            if (pb != null)
            {
                pb.Maximum = (int)allbye;

            }
            int startbye = 0;
            try
            {
                Stream strm = reqFtp.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    startbye = contentLen + startbye;
                    if (pb != null)
                    {
                        pb.Value = (int)startbye;
                    }
                    contentLen = fs.Read(buff, 0, buffLength);
                    percent = (float)startbye / (float)allbye * 100;
                }
                strm.Close();
                fs.Close();
                erroinfo = "完成";
                //MessageBox.Show(erroinfo);
                return true;
            }
            catch (Exception ex)
            {
                erroinfo = string.Format(ex.Message);
                //MessageBox.Show(erroinfo);
                return false;
            }
        }
        /// <summary>
        /// 文件上传到ftp
        /// </summary>
        /// <param name="ftpPath">ftp的文件路径</param>
        /// <param name="path">本地的文件目录</param>
        /// <param name="name">文件名称</param>
        /// <param name="pb">进度条</param>
        /// <returns></returns>
        public static bool UploadFile(string ftpPath, string path, string name, ProgressBar pb)
        {
            //path = "ftp://" + UserUtil.serverip + path;
            string erroinfo = "";
            float percent = 0;
            FileInfo f = new FileInfo(path);
            path = path.Replace("\\", "/");
            bool b = MakeDir(ftpPath);
            if (b == false)
            {
                return false;
            }
            path = m_FTPAddress + ftpPath+"/"+name;
            FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(path));
            reqFtp.UseBinary = true;
            reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
            reqFtp.KeepAlive = false;
            reqFtp.UsePassive = false;
            reqFtp.Method = WebRequestMethods.Ftp.UploadFile;
            reqFtp.ContentLength = f.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = f.OpenRead();
            int allbye = (int)f.Length;
            //if (pb != null)
            //{
            //    pb.Maximum = (int)allbye;

            //}
            int startbye = 0;
            try
            {
                Stream strm = reqFtp.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    startbye = contentLen + startbye;
                    percent = (float)startbye / (float)allbye * 100;
                    if (percent <= 100)
                    {
                        int i = (int)percent;
                        if (pb != null)
                        {
                            pb.BeginInvoke(new updateui(upui), new object[] { allbye, i, pb });
                        }
                    }

                    contentLen = fs.Read(buff, 0, buffLength);

                    //  Console.WriteLine(percent);
                }
                strm.Close();
                fs.Close();
                erroinfo = "完成";
                return true;
            }
            catch (Exception ex)
            {
                erroinfo = string.Format("因"+ ex.Message + ",无法完成上传");
                return false;
            }
        }
        private delegate void updateui(long rowCount, int i, ProgressBar PB);
        public static void upui(long rowCount, int i, ProgressBar PB)
        {
            try
            {
                PB.Value = i;
            }
            catch { }
        }
        ////上面的代码实现了从ftp服务器下载文件的功能
        public static Stream Download(string ftpfilepath)
        {
            Stream ftpStream = null;
            FtpWebResponse response = null;
            try
            {
                ftpfilepath = ftpfilepath.Replace("\\", "/");
                string url = m_FTPAddress + ftpfilepath;
                FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                response = (FtpWebResponse)reqFtp.GetResponse();
                ftpStream = response.GetResponseStream();
            }
            catch (Exception ee)
            {
                if (response != null)
                {
                    response.Close();
                }
                MessageBox.Show("文件读取出错，请确认FTP服务器服务开启并存在该文件");
            }
            return ftpStream;
        }
        #endregion

        #region 从ftp服务器下载文件

        /// <summary>
        /// 从ftp服务器下载文件的功能
        /// </summary>
        /// <param name="ftpfilepath">ftp下载的地址</param>
        /// <param name="filePath">存放到本地的路径</param>
        /// <param name="fileName">保存的文件名称</param>
        /// <returns></returns>
        public static bool Download(string ftpfilepath, string filePath, string fileName)
        {
            try
            {
                filePath = filePath.Replace("我的电脑\\", "");
                String onlyFileName = Path.GetFileName(fileName);
                string newFileName = filePath + onlyFileName;
                if (File.Exists(newFileName))
                {
                    //errorinfo = string.Format("本地文件{0}已存在,无法下载", newFileName);                   
                    File.Delete(newFileName);
                    //return false;
                }
                ftpfilepath = ftpfilepath.Replace("\\", "/");
                string url = m_FTPAddress + ftpfilepath;
                FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                FtpWebResponse response = (FtpWebResponse)reqFtp.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                FileStream outputStream = new FileStream(newFileName, FileMode.Create);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //
        /// <summary>
        /// 从ftp服务器下载文件的功能----带进度条
        /// </summary>
        /// <param name="ftpfilepath">ftp下载的地址</param>
        /// <param name="filePath">保存本地的地址</param>
        /// <param name="fileName">保存的名字</param>
        /// <param name="pb">进度条引用</param>
        /// <returns></returns>
        public static bool Download(string ftpfilepath, string filePath, string fileName, ProgressBar pb)
        {
            FtpWebRequest reqFtp = null;
            FtpWebResponse response = null;
            Stream ftpStream = null;
            FileStream outputStream = null;
            try
            {
                filePath = filePath.Replace("我的电脑\\", "");
                String onlyFileName = Path.GetFileName(fileName);
                string newFileName = filePath + onlyFileName;
                if (File.Exists(newFileName))
                {
                    try
                    {
                        File.Delete(newFileName);
                    }
                    catch { }

                }
                ftpfilepath = ftpfilepath.Replace("\\", "/");
                string url = m_FTPAddress + ftpfilepath;
                reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                response = (FtpWebResponse)reqFtp.GetResponse();
                ftpStream = response.GetResponseStream();
                long cl = GetFileSize(url);
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                outputStream = new FileStream(newFileName, FileMode.Create);

                float percent = 0;
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                    percent = (float)outputStream.Length / (float)cl * 100;
                    if (percent <= 100)
                    {
                        if (pb != null)
                        {
                            pb.Invoke(new updateui(upui), new object[] { cl, (int)percent, pb });
                        }
                    }
                    // pb.Invoke(new updateui(upui), new object[] { cl, outputStream.Length, pb });

                }

                //MessageBoxEx.Show("Download0");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                //MessageBoxEx.Show("Download2");
                if (reqFtp != null)
                {
                    reqFtp.Abort();
                }
                if (response != null)
                {
                    response.Close();
                }
                if (ftpStream != null)
                {
                    ftpStream.Close();
                }
                if (outputStream != null)
                {
                    outputStream.Close();
                }
            }
        }
        #endregion

        #region 获得文件的大小
        /// <summary>
        /// 获得文件大小
        /// </summary>
        /// <param name="url">FTP文件的完全路径</param>
        /// <returns></returns>
        public static long GetFileSize(string url)
        {

            long fileSize = 0;
            try
            {
                FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                reqFtp.Method = WebRequestMethods.Ftp.GetFileSize;
                FtpWebResponse response = (FtpWebResponse)reqFtp.GetResponse();
                fileSize = response.ContentLength;

                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return fileSize;
        }
        #endregion

        #region 在ftp服务器上创建文件目录

        /// <summary>
        ///在ftp服务器上创建文件目录
        /// </summary>
        /// <param name="dirName">文件目录</param>
        /// <returns></returns>
        public static bool MakeDir(string dirName)
        {
            try
            {
                bool b = RemoteFtpDirExists(dirName);
                if (b)
                {
                    return true;
                }
                string url = m_FTPAddress + dirName;
                FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                // reqFtp.KeepAlive = false;
                reqFtp.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                FtpWebResponse response = (FtpWebResponse)reqFtp.GetResponse();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        #endregion

        #region 在ftp服务器上删除文件目录

        /// <summary>
        ///在ftp服务器上删除文件目录
        /// </summary>
        /// <param name="dirName">文件目录</param>
        /// <returns></returns>
        public static bool RemoveDir(string dirName)
        {
            try
            {
                bool b = RemoteFtpDirExists(dirName);
                if(!b)
                {
                    return true;
                }
                string url = m_FTPAddress + dirName;
                FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                // reqFtp.KeepAlive = false;
                reqFtp.Method = WebRequestMethods.Ftp.RemoveDirectory;
                reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                FtpWebResponse response = (FtpWebResponse)reqFtp.GetResponse();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        #endregion

        #region 判断目录是否存在
        /// <summary>
        /// 判断ftp上的文件目录是否存在
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool RemoteFtpDirExists(string path)
        {
            string[] dirList;
            if (path.LastIndexOf("\\")>-1)
            {
                path.Substring(path.LastIndexOf("\\"));
                dirList = GetDirectoryList(path);
            }
            else
            {
                dirList = GetDirectoryList("");
            }
            if (dirList==null)
            {
                return false;
            }
            foreach (string str in dirList)
            {
                if (str.Trim() == path.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region 从ftp服务器删除文件的功能
        /// <summary>
        /// 从ftp服务器删除文件的功能
        /// </summary>
        /// <param name="fileName">路径加文件名</param>
        /// <returns></returns>
        public static bool DeleteFile(string fileName)
        {
            try
            {
                string url = m_FTPAddress + fileName;
                FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                reqFtp.KeepAlive = false;
                reqFtp.UsePassive = false;
                reqFtp.Method = WebRequestMethods.Ftp.DeleteFile;
                reqFtp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                FtpWebResponse response = (FtpWebResponse)reqFtp.GetResponse();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
        /// <summary>
                /// 文件存在检查
                /// </summary>
                /// <param name="ftpPath"></param>
                /// <param name="ftpName"></param>
                /// <returns></returns>
        public static bool fileCheckExist(string fileName)
        {
            bool success = false;
            FtpWebRequest ftpWebRequest = null;
            WebResponse webResponse = null;
            StreamReader reader = null;
            try
            {
                string url = m_FTPAddress + fileName;

                ftpWebRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                ftpWebRequest.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpWebRequest.KeepAlive = false;
                ftpWebRequest.UsePassive = false;
                webResponse = ftpWebRequest.GetResponse();
                reader = new StreamReader(webResponse.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line == fileName)
                    {
                        success = true;
                        break;
                    }
                    line = reader.ReadLine();
                }
            }
            catch (Exception)
            {
                success = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (webResponse != null)
                {
                    webResponse.Close();
                }
            }
            return success;
        }
        // 获取指定目录下所有的文件夹列表(仅文件夹)
        public static string[] GetDirectoryList(string urlpath)
        {
            try
            {
                string[] drectory = GetFilesDetailList(urlpath);
                string m = string.Empty;
                foreach (string str in drectory)
                {
                    if (str == "")
                        continue;
                    int dirPos = str.IndexOf("<DIR>");
                    if (dirPos > 0)
                    {
                        /*判断 Windows 风格*/
                        m += str.Substring(dirPos + 5).Trim() + "\n";
                    }
                    else if (str.Trim().Substring(0, 1).ToUpper() == "D")
                    {
                        /*判断 Unix 风格*/
                        string dir = str.Substring(56).Trim();
                        if (dir != "." && dir != "..")
                        {
                            m += dir + "\n";
                        }
                    }
                }
                if (m.Length == 0)
                {
                    return null;
                }
                if (m[m.Length - 1] == '\n')
                    m.Remove(m.Length - 1);
                char[] n = new char[] { '\n' };
                return m.Split(n);   //这样最后一个始终是空格了
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
           
        }

        // 获取指定目录下所有的文件列表(仅文件)
        public static string[] GetFileList(string urlpath)
        {
            try
            {
                string[] drectory = GetFilesDetailList(urlpath);
                string m = string.Empty;
                foreach (string str in drectory)
                {
                    if (str == "")
                        continue;
                    if (str.Trim().Substring(0, 1).ToUpper() == "-")
                    {
                        /*判断 Unix 风格*/
                        string dir = str.Substring(56).Trim();
                        if (dir != "." && dir != "..")
                        {
                            m += dir + "\n";
                        }
                    }
                }
                if (m.Length == 0)
                {
                    return null;
                }
                if (m[m.Length - 1] == '\n')
                    m.Remove(m.Length - 1);
                char[] n = new char[] { '\n' };
                return m.Split(n);   //这样最后一个始终是空格了
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            
        }

        //获取路径下所有文件和文件夹
        public static string[] GetFilesDetailList(string urlpath)
        {
            string[] downloadFiles;
            try
            {
                bool getin = false;
                string uri = m_FTPAddress +urlpath;
                StringBuilder result = new StringBuilder();
                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                ftp.UsePassive = false;
                ftp.Credentials = new NetworkCredential(m_FTPUserName, m_FTPPWD);
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
                string line = reader.ReadLine();
                while (line != null)
                {
                    getin = true;
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                if (getin)
                    result.Remove(result.ToString().LastIndexOf("\n"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                downloadFiles = null;
                MessageBox.Show(ex.Message);
                return downloadFiles;
            }
        }
    }
}


