using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShop.FormMaster
{
    public static class ApplicationInfo
    {
        static int userID = 0;
        public static int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        static string userName = "";
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        static string displayName = "";
        public static string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
    }
}
