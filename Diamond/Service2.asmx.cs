using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DiamondDS.DS;
using DiamondBiz.Biz;
using System.Data;

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
        public dsSeller GetSeller()
        {
            SellerBiz biz = new SellerBiz();

            try
            {
                return biz.GetSeller();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public string GetRunningNumber(string subject)
        {
            GeneralCBiz biz = new GeneralCBiz();
            try
            {
                return biz.GetRunningNumber(subject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetJewelryDetail(int id)
        {
            GeneralCBiz biz = new GeneralCBiz();
            try
            {
                return biz.GetJewelryDetail(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int UpdateJewelryStatus(int id, string status)
        {
            GeneralCBiz biz = new GeneralCBiz();
            try
            {
                return biz.UpdateJewelryStatus(id,status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetPriceDaimondAndGemstone(int id)
        {
            GeneralCBiz biz = new GeneralCBiz();
            try
            {
                return biz.GetPriceDaimondAndGemstone(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
