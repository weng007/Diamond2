using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using DiamondDS.DS;
using DiamondBiz.Biz;

namespace Diamond
{
    /// <summary>
    /// Summary description for Service3
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service3 : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet DoSearchCustomer(string search, int shop)
        {
            CustomerBiz biz = new CustomerBiz();

            try
            {
                return biz.DoSearchData(search, shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchUser(string search, int shop)
        {
            UserBiz biz = new UserBiz();

            try
            {
                return biz.DoSearchData(search, shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchSeller(string search, int shop)
        {
            SellerBiz biz = new SellerBiz();

            try
            {
                return biz.DoSearchData(search, shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookDiamondCer(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int colorType, int sColor,
            int eColor, int sClearity, int eClearity, int status, int shop)
        {
            BuyBookDiamondCerBiz biz = new BuyBookDiamondCerBiz();

            try
            {
                return biz.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, colorType,sColor,eColor,sClearity,eClearity,status,shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchGemstoneCer(double sweight, double eweight, int shape, int origin, int companyCer, int gemstoneType)
        {
            GemstoneCerBiz biz = new GemstoneCerBiz();

            try
            {
                return biz.DoSearchData(sweight, eweight, shape, origin, companyCer, gemstoneType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookDiamond(double sSize, double eSize, int colorGrade, int color, int clarity)
        {
            BuyBookDiamondBiz biz = new BuyBookDiamondBiz();

            try
            {
                return biz.DoSearchData(sSize, eSize, colorGrade, color, clarity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookGemstone(int gemstoneType, int status, double sSize, double eSize)
        {
            BuyBookGemstoneBiz biz = new BuyBookGemstoneBiz();

            try
            {
                return biz.DoSearchData(gemstoneType,status,sSize, eSize);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookGold(double sSize, double eSize, int status)
        {
            BuyBookGoldBiz biz = new BuyBookGoldBiz();

            try
            {
                return biz.DoSearchData(sSize, eSize, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [WebMethod]
        public DataSet DoSearchBuyBookSpecial(string search)
        {
            BuyBookSpecialBiz biz = new BuyBookSpecialBiz();

            try
            {
                return biz.DoSearchData(search);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchProduct(string code, int shop, int status, int jewelryType)
        {
            ProductBiz biz = new ProductBiz();

            try
            {
                return biz.DoSearchData(code, shop, status, jewelryType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
