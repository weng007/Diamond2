﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DiamondDS.DS;
using DiamondBiz.Biz;

namespace Diamond
{
    /// <summary>
    /// Summary description for Service2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service2 : System.Web.Services.WebService
    {
        [WebMethod]
        public dsUser DoAuthenticate(string userName, string password,string type)
        {
            UserBiz biz = new UserBiz();

            try
            {
                return biz.DoAuthenticate(userName, password, type);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public dsSeller GetSellerName()
        {
            SellerBiz biz = new SellerBiz();

            try
            {
                return biz.GetSellerName();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
