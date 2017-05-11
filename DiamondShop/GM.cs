using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DiamondShop.DiamondService;
using DiamondShop.DiamondService1;
using DiamondShop.DiamondService2;
using DiamondShop.DiamondService3;
using System.Data;
using DiamondDS.DS;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace DiamondShop
{   
    public static class GM
    {
        private static Service1 ser1;
        private static Service2 ser2;
        private static Service3 ser3;
        private static Service4 ser4;

        //Path For Save Temp File
        public static string Path = "C:\\Certificate";

        //Encrypt
        static readonly string PasswordHash = "IamPassword";
        static readonly string SaltKey = "unIcKeY@@";
        static readonly string VIKey = "@8Bfe3d4e5F62799";//"@1B2c3D4e5F6g7H8";

        public static DataSet GetMasterTableDetail(string TypeID)
        {
            DataSet ds= new DataSet();
            ser1 = new Service1();
            ds = ser1.GetMasterTableDetail(TypeID).Copy();

            return ds;
        }

        public static DataSet GetMasterTableDetail(string TypeID, bool isSearch)
        {
            DataSet ds = new DataSet();
            ser1 = new Service1();
            ds = ser1.GetMasterTableDetail(TypeID).Copy();

            if (isSearch)
            {
                ds.Tables[0].Rows.Add("0", "All");
                ds.Tables[0].DefaultView.Sort = "ID";

                DataTable table = ds.Tables[0];
                DataView view = table.DefaultView;
                view.Sort = "Seq";          
            }
            else
            {
                ds.Tables[0].Rows.Add("0", "-");
                ds.Tables[0].DefaultView.Sort = "ID";

                DataTable table = ds.Tables[0];
                DataView view = table.DefaultView;
                view.Sort = "Seq";
            }

            return ds;
        }

        public static DataSet GetSeller()
        {
            DataSet ds = new DataSet();
            ser2 = new Service2();
            ds = ser2.GetSeller().Copy();

            return ds;
        }
        public static DataSet GetBuyer()
        {
            DataSet ds = new DataSet();
            ser2 = new Service2();
            ds = ser2.GetBuyer().Copy();

            return ds;
        }
        public static DataSet GetExpenseGroup()
        {
            DataSet ds = new DataSet();
            ser2 = new Service2();
            ds = ser2.GetExpenseGroup().Copy();

            return ds;
        }
        public static Service1 GetService()
        {
            if (ser1 != null) { return ser1; }
            else { return new Service1(); }
        }

        public static Service2 GetService1()
        {
            if (ser2 != null) { return ser2; }
            else { return new Service2(); }
        }

        public static Service3 GetService2()
        {
            if (ser3 != null) { return ser3; }
            else { return new Service3(); }
        }

        public static Service4 GetService3()
        {
            if (ser4 != null) { return ser4; }
            else { return new Service4(); }
        }

        public static bool CheckLetter(string mes)
        {
            return Regex.IsMatch(mes, @"^[\p{L}]+$");
        }
        public static bool CheckNumber(string num)
        {
            return Regex.IsMatch(num, @"^[0-9,\.]+$");
        }

        public static double ConvertStringToDouble(TextBox txt)
        {
            if (txt.Text == "") { return 0; }
            return Convert.ToDouble(txt.Text);
        }
        
        public static string ConvertDoubleToString(TextBox txt)
        {
            if (txt.Text != "" && !txt.Text.Contains("-"))
            {
                return string.Format("{0:#,##0.00}", double.Parse(txt.Text));
            }
            else if(txt.Text.Contains("-"))
            {
                return txt.Text;
            }

            return "0";
        }

        public static string ConvertDoubleToString(TextBox txt, int digit)
        {
            if (digit == 0)
            { 
                if (txt.Text != "" && !txt.Text.Contains("-"))
                {
                    return string.Format("{0:#,###,0}", double.Parse(txt.Text));
                }
                else if (txt.Text.Contains("-"))
                {
                    return txt.Text;
                }
            }

            return "0";
        }

        public static string Encrypt(string str)
        {
            try
            {
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(str);

                byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

                byte[] cipherTextBytes;

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memoryStream.ToArray();
                        cryptoStream.Close();
                    }
                    memoryStream.Close();
                }
                return Convert.ToBase64String(cipherTextBytes);
            }
            catch
            {
                return "";
            }
        }

        public static string Decrypt(string encryptedText)
        {
            try
            {
                byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
                byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

                var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
                var memoryStream = new MemoryStream(cipherTextBytes);
                var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
            }
            catch
            {
                return "";
            }
        }

        public static Form SetBackgroundColor(int mode,Form frm)
        {
            if(mode == 0)
            {
                foreach(Control ctr in frm.Controls)
                {
                    if(ctr is TextBox)
                    {
                        if(((TextBox)ctr).AccessibleDescription.ToString() == "RW")
                        {
                            ((TextBox)ctr).BackColor = Color.LightPink;
                            ((TextBox)ctr).ReadOnly = false;
                        }
                        else
                        {
                            ((TextBox)ctr).BackColor = Color.LightGreen;
                            ((TextBox)ctr).ReadOnly = true;
                        }
                    }
                    else if(ctr is ComboBox)
                    {
                        ((ComboBox)ctr).BackColor = Color.LightBlue;
                    }          
                }
            }
            else
            {
                foreach (Control ctr in frm.Controls)
                {
                    if (ctr is TextBox)
                    {
                        ((TextBox)ctr).BackColor = Color.LightGreen;
                        ((TextBox)ctr).ReadOnly = true;
                    }
                    else if (ctr is ComboBox)
                    {
                        ((ComboBox)ctr).BackColor = Color.LightGreen;
                        ((ComboBox)ctr).Enabled = false;
                    }
                }
            }
            return frm;
        }
        public static string GetRunningNumber(string subject)
        {
            string Code = "";
            ser2 = new Service2();
            Code = ser2.GetRunningNumber(subject);

            return Code;
        }

        public static bool CheckIsEdit(int shop, int shop1)
        {
            if(shop == shop1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static byte[] GetCertificate(int id, int mode)
        {
            DataSet ds = new DataSet();

            //ds = ser2.GetCertificate(id, mode);
            //if (ds.Tables[0].Rows[0]["Certificate"].ToString() != "")
            //{
            //    return (byte[])ds.Tables[0].Rows[0]["Certificate"];
            //}

            return null;
        }

        public static bool IsOwner(string str)
        {
            if (str == "Owner")
            { return true; }
            else { return false; }
        }

        public static int GetShopByUserID(int userID)
        {
            int shop = 0;

            ser3 = new Service3();
            shop = ser3.GetShopByUserID(userID);

            return shop;
        }
    }
}
