﻿using System;
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

        static int shop = 0;
        public static int Shop
        {
            get { return shop; }
            set { shop = value; }
        }

        static string shopName = "";
        public static string ShopName
        {
            get { return shopName; }
            set { shopName = value; }
        }

        static string displayName = "";
        public static string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        static string authorized = "";
        public static string Authorized
        {
            get { return authorized; }
            set { authorized = value; }
        }
    }
}
