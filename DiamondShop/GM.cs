using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DiamondShop.DiamondService;
using DiamondShop.DiamondService1;
using DiamondShop.DiamondService2;
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

            return ds;
        }

        public static DataSet GetSellerName()
        {
            DataSet ds = new DataSet();
            ser2 = new Service2();
            ds = ser2.GetSellerName().Copy();

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
            if (txt.Text != "")
            {
                return string.Format("{0:#,##0.00}", double.Parse(txt.Text));
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
    }
}
