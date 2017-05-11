using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using WealthUpdate.SendUpdateFile;
using System.Security.Cryptography;

namespace WealthUpdate
{
    class Program
    {
        static int softwareVersion;
        static string pathNewFile = "";

        static void Main(string[] args)
        {
            string path = Crypto.AesDecrypt(args[0]);
            Console.WriteLine();
            //string path = "F:\\DiamondShop\\bin\\Debug";
            //string FileName = "\\uApplication.exe";

            string appPath = path;
            Console.WriteLine(appPath);
            Console.WriteLine("Please waitting for update. Do not close this windows until finished");
            update(path);
        }

        static void update(string path)
        {
            ManageFile manageFile = new ManageFile();

            try
            {   //File ใน Server
                Service4 ws = new Service4();

                //ฝั่ง Server
                softwareVersion = Convert.ToInt32(ws.GetVersion());

                DirectoryInfo oDirInfo;
                oDirInfo = new DirectoryInfo(path);
                FileInfo[] arrFileInfo = oDirInfo.GetFiles("*", SearchOption.AllDirectories);
                string checksumMd5 = "";
                string[] fileSum = new string[arrFileInfo.Length];

                for (int i = 0; i < arrFileInfo.Length; i++)
                {
                    checksumMd5 = GetChecksum(arrFileInfo[i].FullName, Algorithms.MD5);
                    fileSum[i] = arrFileInfo[i].Name + "|" + checksumMd5;
                }

                FileDes[] fileDesList = ws.GetDocument(fileSum); // โหลดไฟล์จาก Server เก็บ  
                bool chkDiff = true;

                //สร้างโฟลเดอร์ tmp
                createTmpDirectory();
                for (int i = 0; i < fileDesList.Length; i++)
                {
                    string Dirfile = fileDesList[i].DirectoryName;
                    //Copy ไฟล์บน Server มาไว้ที่ Folder Temp ใน PC   Documentcontents = จำนวน byte , fileContent = FileType , fileName = ชื่อไฟล์
                    pathNewFile = CreateTmpFileByByte(fileDesList[i].Documentcontents, fileDesList[i].fileContent, fileDesList[i].fileName, fileDesList[i].DirectoryName);

                    //File ในเครื่อง PC
                    arrFileInfo = oDirInfo.GetFiles();

                    //ดึงไฟล์ใน PC Check กับ ไฟล์บน Server
                    for (int j = 0; j < arrFileInfo.Length; j++)
                    {
                        //Check ไฟล์ในเครื่องว่ามีใน Directory หรือไม่
                        if (checkFileInDirectory(fileDesList[i].fileName, path))
                        {
                            //Check ชื่อไฟล์ว่าตรงกันป่าว
                            if (fileDesList[i].fileName == arrFileInfo[j].Name)
                            {
                                FileInfo file1 = new FileInfo(pathNewFile); //ไฟล์จาก Server

                                //check in file
                                chkDiff = manageFile.FilesDiff(file1, arrFileInfo[j]); // Check ว่าข้างในไฟล์เหมือนกันรึป่าว โดยเช็คเป็นระดับไบต์
                                //chkDiff = false;
                                if (chkDiff) //ถ้าไฟล์ไม่ตรงกัน
                                {
                                    CreateDirectoryAndFile(fileDesList[i].DirectoryName, fileDesList[i].fileName, path);  // สร้างโฟลเดอร์และไฟล์ใน pc
                                }
                                break;
                            }
                        }
                        else // กรณีไม่มีไฟล์ที่ตรงกัน ให้สร้างโฟลเดอร์และไฟล์ใน pc
                        {
                            CreateDirectoryAndFile(fileDesList[i].DirectoryName, fileDesList[i].fileName, path);
                            break;
                        }
                    }
                   
                    Updateversion(softwareVersion); // อัพเดต Version Software
                    Console.WriteLine("Software Version " + softwareVersion + " Is Success");

                    Console.WriteLine("Please enter for exit....");
                    Console.ReadLine();
                }
            }
            catch (Exception exe)
            {
                Console.WriteLine("Can not update software == " + exe.Message);
                Console.ReadLine();
            }
        }

        static bool checkFileInDirectory(string FileName, string startPath)
        {
            bool chk = true;
            string pathFile = startPath;
            chk = File.Exists(pathFile + "\\" + FileName);

            return chk;
        }

        static string CreateTmpFileByByte(Byte[] b, string fileContent, string fileName, string fileDirectory)
        {
            string path = "";
            string DirPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\tmp";
            string[] tmp = fileDirectory.Split('\\');
            for (int i = 1; i < tmp.Length; i++)
            {
                DirPath += "\\" + tmp[i];
            }

            bool exists = File.Exists(DirPath);

            if (!exists)
                Directory.CreateDirectory(DirPath);
            FileStream fs = File.Create(DirPath + "\\" + fileName, 2048, FileOptions.None);
            ////FileStream fs = File.Create(appPath + "\\tmp\\" + fileName, 2048, FileOptions.None);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(b);
            bw.Close();
            fs.Close();
            path = DirPath + "\\" + fileName;

            return path;
        }

        static void clearTmpFolder()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "tmp";
            Directory.Delete(path, true);
            path = AppDomain.CurrentDomain.BaseDirectory + "Script";
            Directory.Delete(path, true);  
        }

        static void createTmpDirectory()
        {
            bool exists = File.Exists(AppDomain.CurrentDomain.BaseDirectory + "tmp");

            if (!exists)
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "tmp");
        }

        static void Updateversion(int SoftwareVersion)
        {
            using (StreamWriter writetext = new StreamWriter("VersionProgram.txt"))
            {
                writetext.WriteLine(softwareVersion);
            }
        }

        static void CopyFileAndOverWrite(string SourceFileName, string TargetFileName)
        {
            ////Copy File ที่เราต้องการแบบเขียนทับ File Target ในกรณีที่มี File Target อยู่แล้ว
            File.Copy(SourceFileName, TargetFileName, true);
        }

        static void CreateDirectoryAndFile(string directoryName, string fileName, string path)
        {
            string[] tmp = directoryName.Split('\\');
            //Application.StartupPath ;

            //เช็คว่าเป็นไฟล์ SQL หรือไม่
            if(tmp.Length >1)
            {
                if (tmp[1] == "Script" ||tmp[1] == "Reports" || tmp[1] == "Report2" || tmp[1] == "User Manual")
                {
                   path += "\\" + tmp[1];
                }
            }

            bool exists = File.Exists(path);

            if (!exists)
                Directory.CreateDirectory(path);
            File.Copy(pathNewFile, path + "\\" + fileName, true);
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
}
