using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;



public class ManageFile
{
    const int BYTES_TO_READ = sizeof(Int64);

    /// <summary>
    /// เปรียบเทียบไฟล์สองไฟล์ ภายใน
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public bool FilesDiff(FileInfo first, FileInfo second)
    {
        if (first.Length != second.Length)
            return true;

        int iterations = (int)Math.Ceiling((double)first.Length / BYTES_TO_READ);

        using (FileStream fs1 = first.OpenRead())
        using (FileStream fs2 = second.OpenRead())
        {
            byte[] one = new byte[BYTES_TO_READ];
            byte[] two = new byte[BYTES_TO_READ];

            for (int i = 0; i < iterations; i++)
            {
                fs1.Read(one, 0, BYTES_TO_READ);
                fs2.Read(two, 0, BYTES_TO_READ);

                if (BitConverter.ToInt64(one, 0) != BitConverter.ToInt64(two, 0))
                    return true;
            }
        }

        return true;
    }
    // Adds an ACL entry on the specified directory for the specified account. 
    public void AddDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
    {
        // Create a new DirectoryInfo object.
        DirectoryInfo dInfo = new DirectoryInfo(FileName);

        // Get a DirectorySecurity object that represents the  
        // current security settings.
        DirectorySecurity dSecurity = dInfo.GetAccessControl();

        // Add the FileSystemAccessRule to the security settings. 
        dSecurity.AddAccessRule(new FileSystemAccessRule(Account,
                                                        Rights,
                                                        ControlType));

        // Set the new access settings.
        dInfo.SetAccessControl(dSecurity);

    }
    // Removes an ACL entry on the specified directory for the specified account. 
    public void RemoveDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
    {
        // Create a new DirectoryInfo object.
        DirectoryInfo dInfo = new DirectoryInfo(FileName);

        // Get a DirectorySecurity object that represents the  
        // current security settings.
        DirectorySecurity dSecurity = dInfo.GetAccessControl();

        // Add the FileSystemAccessRule to the security settings. 
        dSecurity.RemoveAccessRule(new FileSystemAccessRule(Account,
                                                        Rights,
                                                        ControlType));

        // Set the new access settings.
        dInfo.SetAccessControl(dSecurity);

    }

}
