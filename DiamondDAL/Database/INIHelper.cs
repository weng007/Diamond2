using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Web;
using System.Windows.Forms;


public class INIHelper
{
    string path = "";
   
    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section,
        string key, string val, string filePath);
    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section,
             string key, string def, StringBuilder retVal,
        int size, string filePath);

    public INIHelper()
    {
        this.path = Application.StartupPath+"/config.ini";
        //this.path = HttpContext.Current.Server.MapPath("config.ini");
    }

    public INIHelper(string path)
    {
        this.path = path;
    }

    public void Write(string Section, string Key, string Value, bool isencoding)
    {
        if (isencoding)
        {
            Value = EncryptHelper.Encrypt(Value);
        }
        Write(Section, Key, Value);
    }
    public void Write(string Section, string Key, string Value)
    {
        WritePrivateProfileString(Section, Key, Value, this.path);
    }

    public string Read(string Section, string Key)
    {
        return Read(Section, Key, false);
    }
    public string Read(string Section, string Key, bool isencoding)
    {
        StringBuilder temp = new StringBuilder(255);
        int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
        string value = temp.ToString();
        if (isencoding)
        {
            value = EncryptHelper.Decrypt(value);
        }
        return value;
    }

}
