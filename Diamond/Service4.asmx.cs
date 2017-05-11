using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using DiamondDS.DS;
using DiamondBiz.Biz;
using System.IO;
using System.Security.Cryptography;

namespace Diamond
{
    /// <summary>
    /// Summary description for Service4
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service4 : System.Web.Services.WebService
    {
        [WebMethod]
        public List<FileDes> GetDocument(string[] listSumFile)
        {
            //ดึงไฟล์จาก folder ทั้งหมด
            //string[] filePaths = Directory.GetFiles(@"D:\Wealth\uApplication\bin\Debug", "*", SearchOption.AllDirectories);
            DirectoryInfo oDirInfo;
            oDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "\\Software\\");
            FileInfo[] filePaths = oDirInfo.GetFiles("*", SearchOption.AllDirectories);
            List<FileDes> list = new List<FileDes>();
            string sumFileSv = string.Empty;
            bool haveFile = true;
            string[] tmpSum;
            for (int i = 0; i < filePaths.Length; i++)
            {
                haveFile = true;
                FileDes filedes = new FileDes();
                string strdocPath = filePaths[i].FullName;

                sumFileSv = GetChecksum(strdocPath, Algorithms.MD5);
                for (int j = 0; j < listSumFile.Length; j++)
                {
                    tmpSum = listSumFile[j].Split('|');
                    if (tmpSum[0] == filePaths[i].Name)
                    {
                        haveFile = true;
                        if (tmpSum[1] != sumFileSv)
                        {
                            FileInfo fileInfo = new FileInfo(strdocPath);
                            FileStream objfilestream = new FileStream(strdocPath, FileMode.Open, FileAccess.Read);
                            int len = (int)objfilestream.Length;
                            filedes.fileContent = fileInfo.Extension;
                            filedes.Documentcontents = new Byte[len];
                            filedes.fileName = fileInfo.Name;
                            filedes.DirectoryName = fileInfo.Directory.ToString().Replace(AppDomain.CurrentDomain.BaseDirectory, "");
                            objfilestream.Read(filedes.Documentcontents, 0, len);
                            objfilestream.Close();
                            filedes.LastModified = System.IO.File.GetLastWriteTime(strdocPath);
                            list.Add(filedes);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        haveFile = false;
                    }
                }

                if (!haveFile)
                {
                    FileInfo fileInfo = new FileInfo(strdocPath);
                    FileStream objfilestream = new FileStream(strdocPath, FileMode.Open, FileAccess.Read);
                    int len = (int)objfilestream.Length;
                    filedes.fileContent = fileInfo.Extension;
                    filedes.Documentcontents = new Byte[len];
                    filedes.fileName = fileInfo.Name;
                    filedes.DirectoryName = fileInfo.Directory.ToString().Replace(AppDomain.CurrentDomain.BaseDirectory, "");
                    objfilestream.Read(filedes.Documentcontents, 0, len);
                    objfilestream.Close();
                    filedes.LastModified = System.IO.File.GetLastWriteTime(strdocPath);
                    list.Add(filedes);
                }
            }

            return list;
        }

        [WebMethod]
        public int GetVersion()
        {
            VersionProgramBiz biz = new VersionProgramBiz();

            return biz.GetVersion();
        }

        public static class Algorithms
        {
            public static readonly HashAlgorithm MD5 = new MD5CryptoServiceProvider();
            public static readonly HashAlgorithm SHA1 = new SHA1Managed();
            public static readonly HashAlgorithm SHA256 = new SHA256Managed();
            public static readonly HashAlgorithm SHA384 = new SHA384Managed();
            public static readonly HashAlgorithm SHA512 = new SHA512Managed();
            public static readonly HashAlgorithm RIPEMD160 = new RIPEMD160Managed();
        }

        public static string GetChecksum(string filePath, HashAlgorithm algorithm)
        {
            using (var stream = new BufferedStream(File.OpenRead(filePath), 100000))
            {
                byte[] hash = algorithm.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
    }

    public class FileDes
    {
        public Byte[] Documentcontents { get; set; }
        public DateTime LastModified { get; set; }
        public string fileContent { get; set; }
        public string fileName { get; set; }
        public string DirectoryName { get; set; }
        public string Summary { get; set; }
    }
}
