﻿using System;
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
        public dsUser DoAuthenticate(string userName, string password, int Shop)
        {
            UserBiz biz = new UserBiz();

            try
            {
                return biz.DoAuthenticate(userName, password,Shop);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public dsUser GetSeller()
        {
            UserBiz biz = new UserBiz();

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
        public dsUser GetBuyer()
        {
            UserBiz biz = new UserBiz();

            try
            {
                return biz.GetBuyer();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public dsOrder GetFactoryStatus(int id)
        {
            OrderBiz biz = new OrderBiz();

            try
            {
                return biz.GetFactoryStatus(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public string GetRunningNumber(string subject)
        {
            GeneralBiz biz = new GeneralBiz();
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
            GeneralBiz biz = new GeneralBiz();
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
        public int UpdateJewelryStatus(int id, string status,int shop)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.UpdateJewelryStatus(id,status,shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int UpdateTransferReceive(int id, int eShop)
        {
            TransferBiz biz = GM.GetTransferBiz();
            try
            {
                return biz.UpdateTransferReceive(id, eShop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool UpdateSellBookStatus(int id, string status)
        {
            SellBookBiz biz = GM.GetSellBookBiz();
            try
            {
                return biz.UpdateSellBookStatus(id, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool UpdateNoteStatus(int id, int note, string noteStatus,int sender)
        {
            OrderBiz biz = GM.GetOrderBiz();
            try
            {
                return biz.UpdateNoteStatus(id, note, noteStatus,sender);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool UpdateNote(int id, string note, int noteOrd, int editBy)
        {
            OrderBiz biz = GM.GetOrderBiz();
            try
            {
                return biz.UpdateNote(id, note, noteOrd, editBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetPriceDaimondAndGemstone(int id)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetPriceDaimondAndGemstone(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportJewelry(int id)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportJewelry(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportBuying(int TableName, DateTime SBuyDate, DateTime EBuyDate, float SWeight, float EWeight, int Shape, int Status, DateTime SDueDate, DateTime EDueDate, int IsPaid)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportBuying(TableName, SBuyDate, EBuyDate, SWeight, EWeight, Shape, Status, SDueDate, EDueDate, IsPaid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportSelling(int JewelryType, int Seller , DateTime SSellDate, DateTime ESellDate )
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportSelling(JewelryType, Seller, SSellDate, ESellDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportDebt(int TableName , string Seller, DateTime SDueDate, DateTime EDueDate)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportDebt(TableName, Seller, SDueDate, EDueDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportCustomer(DateTime SBirthDate, DateTime EBirthDate, DateTime SAnniDate, DateTime EAnniDate, string DisplayName)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportCustomer(SBirthDate, EBirthDate, SAnniDate, EAnniDate, DisplayName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportInventory(int Status, DateTime SImpDate, DateTime EImpDate, float SPriceTag, float EPricetag)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportInventory(Status, SImpDate, EImpDate, SPriceTag, EPricetag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportOrder(int ID)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportOrder(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportReceiveDocument(int ID)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportReceiveDocument(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetReportCertificate(int id, string isPrintPrice)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetReportCertificate(id, isPrintPrice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet GetDeliveryOrder(int id)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetDeliveryOrder(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public DataSet GetDeliveryInventory(int id)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.GetDeliveryInventory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int UpdateMessageStatus(int id, string StatusType,string Flag )
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.UpdateMessageStatus(id, StatusType,Flag );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int UpdateIsPrintPrice(int id, string isPrintPrice)
        {
            SellBiz biz = new SellBiz();
            try
            {
                return biz.UpdateIsPrintPrice(id, isPrintPrice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int UpdateIsPrintCer(int id)
        {
            SellBiz biz = new SellBiz();
            try
            {
                return biz.UpdateIsPrintCer(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int DeleteDataReference(int id, int flag)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.DoDeleteDataReference(id, flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int UpdateProductionLine(int id, int FactoryStatus, int EditBy)
        {
            GeneralBiz biz = new GeneralBiz();
            try
            {
                return biz.DoUpdateProductionLine(id, FactoryStatus, EditBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool UpdateReceiveMaterial(int id, string isReceive)
        {
            OrderBiz biz = new OrderBiz();
            try
            {
                return biz.UpdateReceiveMaterial(id, isReceive);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public dsExpenseGroup GetExpenseGroup()
        {
            ExpenseGroupBiz biz = new ExpenseGroupBiz();

            try
            {
                return biz.GetExpenseGroup();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int CountUnReadMessage(int userID)
        {
            GeneralBiz biz = new GeneralBiz();

            try
            {
                DataSet ds = new DataSet();
                ds = biz.CountUnReadMessage(userID);
                return (int)ds.Tables[0].Rows[0][0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int CheckOrderNoExist(string orderNo)
        {
            InventoryBiz biz = GM.GetInventoryBiz();

            try
            {
                return biz.CheckOrderNoExist(orderNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int DoSearchInventoryByCode(string code)
        {
            InventoryBiz biz = GM.InventoryBiz();
            try
            {
                return biz.DoSearchByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int DoSearchOrderByCode(string code)
        {
            OrderBiz biz = GM.GetOrderBiz();
            try
            {
                return biz.DoSearchByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int DoSearchTransferByCode(string code)
        {
            TransferBiz biz = GM.GetTransferBiz();
            try
            {
                return biz.DoSearchByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int DoSearchSellByCode(string code)
        {
            SellBiz biz = GM.SellBiz();
            try
            {
                return biz.DoSearchByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int DoSearchSellBookByCode(string code)
        {
            SellBookBiz biz = GM.GetSellBookBiz();
            try
            {
                return biz.DoSearchByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public int DoSearchBBSettingByCode(string code)
        {
            BuyBookSettingBiz biz = GM.BuyBookSettingBiz();
            try
            {
                return biz.DoSearchByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public dsBuyBookSettingDetail DoSearchBBSettingDetail(int mode)
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
        public int DoSearchJewelryByCode(string code)
        {
            BuyBookJewelryBiz biz = GM.GetBuyBookJewelryBiz();
            try
            {
                return biz.DoSearchByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetSellBookDetail(string idSelected, int buyBookType)
        {
            SellBookDetailBiz biz = GM.GetSellBookDetailBiz();
            try
            {
                return biz.GetSellBookDetail(idSelected,buyBookType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetTransferBuyBookDetail(string codeSelected)
        {
            TransferBuyBookBiz biz = GM.GetTransferBuyBookBiz();
            try
            {
                return biz.GetTransferBuyBookDetail(codeSelected);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetTransferInventoryDetail(string idSelected)
        {
            TransferInventoryBiz biz = GM.GetTransferInventoryBiz();
            try
            {
                return biz.GetTransferInventoryDetail(idSelected);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public byte[] GetCertificate(int id, int mode)
        {
            GeneralBiz biz = new GeneralBiz();

            try
            {
                return biz.GetCertificate(id, mode);       
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
