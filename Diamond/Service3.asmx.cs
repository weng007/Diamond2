﻿using System;
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

        //[WebMethod]
        //public DataSet DoSearchSeller(string search, int shop)
        //{
        //    SellerBiz biz = new SellerBiz();

        //    try
        //    {
        //        return biz.DoSearchData(search, shop);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        [WebMethod]
        public DataSet DoSearchBuyBookDiamondCer(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int colorType, int sColor,
            int eColor, int sClearity, int eClearity, int status, int shop, string code2)
        {
            BuyBookDiamondCerBiz biz = new BuyBookDiamondCerBiz();

            try
            {
                return biz.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, colorType,sColor,eColor,sClearity,eClearity,status,shop, code2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookJewelry(string code, string code2)
        {
            BuyBookJewelryBiz biz = new BuyBookJewelryBiz();

            try
            {
                return biz.DoSearchData(code, code2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookETC(string User)
        {
            BuyBookETCBiz biz = new BuyBookETCBiz();

            try
            {
                return biz.DoSearchData(User);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookDiamond(string code, double sSize, double eSize, int shape, string code2)
        {
            BuyBookDiamondBiz biz = new BuyBookDiamondBiz();

            try
            {
                return biz.DoSearchData(code, sSize, eSize,shape, code2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookGemstone(string Code, double Size, double ESize, string Shape, string Code2)
        {
            BuyBookGemstoneBiz biz = new BuyBookGemstoneBiz();

            try
            {
                return biz.DoSearchData(Code, Size, ESize,Shape, Code2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookGemstoneCer(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int identification, int comment, int origin, int status, int shop, string code2)
        {
            BuyBookGemstoneCerBiz biz = new BuyBookGemstoneCerBiz();

            try
            {
                return biz.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, identification, comment, origin, status, shop, code2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookGold(DateTime sBuyDate, DateTime eBuyDate)
        {
            BuyBookGoldBiz biz = new BuyBookGoldBiz();

            try
            {
                return biz.DoSearchData(sBuyDate, eBuyDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookSettingDetail(int settingtype, DateTime sSBuydate, DateTime eBuydate)
        {
            BuyBookSettingDetailBiz biz = new BuyBookSettingDetailBiz();

            try
            {
                return biz.DoSearchData(settingtype, sSBuydate, eBuydate);
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
        public DataSet DoSearchCatalog(string code, int mode)
        {
            CatalogBiz biz = new CatalogBiz();

            try
            {
                return biz.DoSearchData(code, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchCatalogByType(string prefix, int mode)
        {
            CatalogBiz biz = new CatalogBiz();

            try
            {
                return biz.DoSearchByType(prefix, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchDiamondCer(string code,string reportNumber, int shape, int lab, double sWeight, double eWeight, int colorType,int sColor,
            int eColor, int sClearity, int eClearity, int status, int shop, int mode)
        {
            DiamondCerBiz biz = new DiamondCerBiz();

            try
            {
                return biz.DoSearchData(code,reportNumber, shape, lab, sWeight, eWeight, colorType, sColor,
            eColor, sClearity, eClearity, status, shop, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchGemstoneCer(int identification, string code, string reportnumber, double sweight, 
            double eweight, int shape, int comment, int lab, int origin, int status, int shop, int mode)
        {
            GemstoneCerBiz biz = new GemstoneCerBiz();

            try
            {
                return biz.DoSearchData(identification, code, reportnumber, sweight, eweight,shape, comment, lab, origin, status, shop,mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchInventory(string code)
        {
            InventoryBiz biz = new InventoryBiz();

            try
            {
                return biz.DoSearchData(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchInventoryByType(string prefix)
        {
            InventoryBiz biz = new InventoryBiz();

            try
            {
                return biz.DoSearchByType(prefix);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchSell(string code, int jewelryType)
        {
            SellBiz biz = new SellBiz();

            try
            {
                return biz.DoSearchData(code, jewelryType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookSetting(string User, DateTime sBuyDate, DateTime eBuyDate)
        {
            BuyBookSettingBiz biz = new BuyBookSettingBiz();

            try
            {
                return biz.DoSearchData(User, sBuyDate, eBuyDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookPayment(string User, string tableName, DateTime sBuyDate, DateTime eBuyDate, string IsPaid, DateTime sPayDate, DateTime ePayDate)
        {
            BuyBookPaymentBiz biz = new BuyBookPaymentBiz();

            try
            {
                return biz.DoSearchData(User, tableName, sBuyDate, eBuyDate, IsPaid, sPayDate, ePayDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchWarning(int Sender, int Receiver, int MessageStatus, int FactoryStatus, int Shop, int loginID)
        {
            WarningBiz biz = new WarningBiz();

            try
            {
                return biz.DoSearchData(Sender, Receiver, MessageStatus, FactoryStatus, Shop, loginID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchTransfer(int Sender, int TransferStatus, int SShop, int EShop, DateTime SSendDate, DateTime ESendDate, DateTime SReceiveDate, DateTime EReceiveDate)
        {
            TransferBiz biz = new TransferBiz();

            try
            {
                return biz.DoSearchData(Sender, TransferStatus, SShop, EShop, SSendDate, ESendDate, SReceiveDate, EReceiveDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchOrder(string CustName, string Code, int Seller, int JewelryType)
        {
            OrderBiz biz = new OrderBiz();

            try
            {
                return biz.DoSearchData(CustName, Code, Seller, JewelryType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchTransferBuyBook(int shop, string code, string code2, int buybooktype)
        {
            TransferBuyBookBiz biz = new TransferBuyBookBiz();

            try
            {
                return biz.DoSearchData(shop, code, code2, buybooktype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchTransferInventory(int shop, string code, int jewelrytype)
        {
            TransferInventoryBiz biz = new TransferInventoryBiz();

            try
            {
                return biz.DoSearchData(shop, code, jewelrytype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
