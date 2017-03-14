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
        public DataSet DoSearchBuyBookDiamondCer(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int colorType, int sColor,
            int eColor, int sClearity, int eClearity, int status, int shop, string code2, int mode)
        {
            BuyBookDiamondCerBiz biz = new BuyBookDiamondCerBiz();

            try
            {
                return biz.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, colorType,sColor,eColor,sClearity,eClearity,status,shop, code2, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBuyBookJewelry(string code, string code2, int mode)
        {
            BuyBookJewelryBiz biz = new BuyBookJewelryBiz();

            try
            {
                return biz.DoSearchData(code, code2, mode);
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
        public DataSet DoSearchBuyBookGemstoneCer(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int identification, int comment, 
            int origin, int status, int shop, string code2, int mode)
        {
            BuyBookGemstoneCerBiz biz = new BuyBookGemstoneCerBiz();

            try
            {
                return biz.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, identification, comment, origin, status, shop, code2, mode);
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
        public DataSet DoSearchCatalog(string code, int mode,int Shop)
        {
            CatalogBiz biz = new CatalogBiz();

            try
            {
                return biz.DoSearchData(code, mode,Shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchCatalogByCode(string code, int mode)
        {
            CatalogBiz biz = new CatalogBiz();

            try
            {
                return biz.DoSearchByCode(code, mode);
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
        public DataSet DoSearchBuyBookSetting(string user, DateTime sBuyDate, DateTime eBuyDate)
        {
            BuyBookSettingBiz biz = new BuyBookSettingBiz();

            try
            {
                return biz.DoSearchData(user, sBuyDate, eBuyDate);
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
        public DataSet DoSearchWarning(string refID, int statusType, DateTime sDate, DateTime eDate, int loginID,int isInbox)
        {
            WarningBiz biz = new WarningBiz();

            try
            {
                return biz.DoSearchData(refID, statusType, sDate, eDate, loginID, isInbox);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchTransfer(int sender, int transferStatus, int sShop, int eShop, DateTime sSendDate, DateTime eSendDate,string isBuyBook)
        {
            TransferBiz biz = new TransferBiz();

            try
            {
                return biz.DoSearchData(sender, transferStatus, sShop, eShop, sSendDate, eSendDate, isBuyBook);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchOrder(string custName, string code, int seller, int jewelryType)
        {
            OrderBiz biz = new OrderBiz();

            try
            {
                return biz.DoSearchData(custName, code, seller, jewelryType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchTransferBuyBook(int shop, string code, string code2, int buyBookType)
        {
            TransferBuyBookBiz biz = new TransferBuyBookBiz();

            try
            {
                return biz.DoSearchData(shop, code, code2, buyBookType);
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
        [WebMethod]
        public DataSet DoSearchWarningTransfer(int sender, int receiver, int messageStatus, int factoryStatus, int shop, int loginID)
        {
            WarningTransferBiz biz = new WarningTransferBiz();

            try
            {
                return biz.DoSearchData(sender, receiver, messageStatus, factoryStatus, shop, loginID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchProductionLine(string orderNo, int jewelryType, int shop, int factoryStatus, DateTime sOrderDate, DateTime eOrderDate)
        {
            ProductionLineBiz biz = new ProductionLineBiz();

            try
            {
                return biz.DoSearchData(orderNo, jewelryType, shop, factoryStatus, sOrderDate, eOrderDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchSellBook(string code)
        {
            SellBookBiz biz = new SellBookBiz();

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
        public DataSet DoSearchExpenseGroup(int expenseGroup)
        {
            ExpenseGroupBiz biz = new ExpenseGroupBiz();

            try
            {
                return biz.DoSearchData(expenseGroup);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchExpense(int expenseGroup, int shop, DateTime sMemoDate, DateTime eMemoDate, DateTime sExpenseDate, DateTime eExpenseDate)
        {
            ExpenseBiz biz = new ExpenseBiz();

            try
            {
                return biz.DoSearchData(expenseGroup, shop, sMemoDate, eMemoDate, sExpenseDate, eExpenseDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet DoSearchReceiveDocument(string receiveNo, DateTime sReceiveDate, DateTime eReceiveDate, int receiver, string seller)
        {
            ReceiveDocumentBiz biz = new ReceiveDocumentBiz();

            try
            {
                return biz.DoSearchData(receiveNo, sReceiveDate, eReceiveDate, receiver, seller);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet DoSearchBBSettingDetail(int mode)
        {
            BuyBookSettingDetailBiz biz = GM.GetBuyBookSettingDetailBiz();

            try
            {
                return biz.DoSearchBBSettingDetail(mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int GetShopByUserID(int userID)
        {
            UserBiz biz = GM.GetUserBiz();

            try
            {
                return biz.GetShopByUserID(userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
