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
        public int UpdateOrderStatus(int id, int Flag)
        {
            GeneralCBiz biz = new GeneralCBiz();
            try
            {
                return biz.UpdateOrderStatus(id, Flag);
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

        [WebMethod]
        public DataSet GetReportJewelry(int id)
        {
            GeneralCBiz biz = new GeneralCBiz();
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
            GeneralCBiz biz = new GeneralCBiz();
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
            GeneralCBiz biz = new GeneralCBiz();
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
            GeneralCBiz biz = new GeneralCBiz();
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
            GeneralCBiz biz = new GeneralCBiz();
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
            GeneralCBiz biz = new GeneralCBiz();
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
        public DataSet GetReportCertificate(int id)
        {
            GeneralCBiz biz = new GeneralCBiz();
            try
            {
                return biz.GetReportCertificate(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public int UpdateMessageStatus(int id, string Flag)
        {
            GeneralCBiz biz = new GeneralCBiz();
            try
            {
                return biz.UpdateMessageStatus(id, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public int DeleteDataReference(int id, int flag)
        {
            GeneralCBiz biz = new GeneralCBiz();
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
            GeneralCBiz biz = new GeneralCBiz();
            try
            {
                return biz.DoUpdateProductionLine(id, FactoryStatus, EditBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
