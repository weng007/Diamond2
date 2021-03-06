﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using System.Data;

namespace DiamondDAL.DAL
{
    public class GeneralDAL
    {
        SQLHelper SQL = new SQLHelper();
        DataSet ds = new DataSet();
        int flag = 0;

        public string GetRunningNumber(string subject)
        {
            string code = "";

            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@Result", "");
                SQL.CreateParameter("@Subject", subject);
                SQL.CreateParameter("@Arg1", DateTime.Today.Year);
                SQL.CreateParameter("@Arg2", DateTime.Today.Month);
                SQL.CreateParameter("@Arg3", "");
                SQL.FillDataSetBySP2("SP_GetRunningNo", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                code = subject + "-" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString().PadLeft(2,'0') + ds.Tables[1].Rows[0][0].ToString().PadLeft(3,'0');
            }

            return code;
        }

        public DataSet GetJewelryDetail(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@RefID", id);
                SQL.FillDataSetBySP2("SP_Sell_Detail", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public int UpdateJewelryStatus(int id, int status,int shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@Status", status);
                SQL.CreateParameter("@Shop", shop);
                flag = SQL.ExecuteSP("SP_Sell_Upd_JewelryStatus");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return flag;
        }

        public DataSet GetPriceDaimondAndGemstone(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.FillDataSet(string.Format("Select * FROM dbo.fn_GetPriceDiamondAndGemstone('{0}')", id), ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public DataSet GetReportJewelry(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.FillDataSetBySP2("SP_RPT_Jewelry", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public DataSet GetReportBuying(int TableName, DateTime SBuyDate, DateTime EBuyDate, float SWeight, float EWeight,int Shape,int Status,DateTime SDueDate, DateTime EDueDate,int IsPaid)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@TableName", TableName);
                SQL.CreateParameter("@SBuyDate", SBuyDate);
                SQL.CreateParameter("@EBuyDate", EBuyDate);
                SQL.CreateParameter("@SWeight", SWeight);
                SQL.CreateParameter("@EWeight", EWeight);
                SQL.CreateParameter("@Shape", Shape);
                SQL.CreateParameter("@Status", Status);
                SQL.CreateParameter("@SDueDate", SDueDate);
                SQL.CreateParameter("@EDueDate", EDueDate);
                SQL.CreateParameter("@IsPaid", IsPaid);
                SQL.FillDataSetBySP2("SP_Rpt_Buying", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public DataSet GetReportSelling(int JewelryType, int Seller, DateTime SSellDate, DateTime ESellDate)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@JewelryType", JewelryType);
                SQL.CreateParameter("@Seller", Seller);
                SQL.CreateParameter("@SSellDate", SSellDate);
                SQL.CreateParameter("@ESellDate", ESellDate);
                SQL.FillDataSetBySP2("SP_Rpt_Selling", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public DataSet GetReportInventory(int Status, DateTime SImpDate, DateTime EImpDate, float SPriceTag,float EPricetag)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@Status", Status);
                SQL.CreateParameter("@SImpDate", SImpDate);
                SQL.CreateParameter("@EImpDate", EImpDate);
                SQL.CreateParameter("@SPriceTag", SPriceTag);
                SQL.CreateParameter("@EPricetag", EPricetag);
                SQL.FillDataSetBySP2("SP_Rpt_Inventory", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public DataSet GetReportDebt(int TableName, string Seller, DateTime SDueDate, DateTime EDueDate)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@TableName", TableName);
                SQL.CreateParameter("@Seller", Seller);
                SQL.CreateParameter("@SDueDate", SDueDate);
                SQL.CreateParameter("@EDueDate", EDueDate);
                SQL.FillDataSetBySP2("SP_Rpt_Debt", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public DataSet GetReportCustomer(DateTime SBirthDate, DateTime EBirthDate, DateTime SAnniDate, DateTime EAnniDate, string DisplayName)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@SBirthDate", SBirthDate);
                SQL.CreateParameter("@EBirthDate", EBirthDate);
                SQL.CreateParameter("@SAnniDate", SAnniDate);
                SQL.CreateParameter("@EAnniDate", EAnniDate);
                SQL.CreateParameter("@DisplayName", DisplayName);
                SQL.FillDataSetBySP2("SP_Rpt_Customer", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public DataSet GetReportOrder(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.FillDataSetBySP2("SP_Rpt_Order", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public DataSet GetReportCertificate(int id,string isPrice)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@IsPrice", isPrice);
                SQL.FillDataSetBySP2("SP_Rpt_Certificate", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public int UpdateMessageStatus(int id, string StatusType, string Flag)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@StatusType", StatusType);
                SQL.CreateParameter("@Flag", Flag);
                flag = SQL.ExecuteSP("SP_Warning_Upd_MessageStatus");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return flag;
        }

        public int DoDeleteDataReference(int id,int flag)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@Flag", flag);
                flag = SQL.ExecuteSP("SP_Reference_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return flag;
        }
        public int DoUpdateProductionLine(int id,int FactoryStatus,int EditBy)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@FactoryStatus", FactoryStatus);
                SQL.CreateParameter("@EditBy", EditBy);
                flag = SQL.ExecuteSP("SP_ProductionLine_Upd");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return flag;
        }
        public DataSet GetReportReceiveDocument(int ID)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", ID);
                SQL.FillDataSetBySP2("SP_Rpt_ReceiveDocument", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public DataSet CountUnReadMessage(int userID)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@UserID", userID);
                SQL.FillDataSet(string.Format("Select dbo.fns_CountUnRead('{0}')", userID), ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public byte[] GetCertificate(int id, int mode)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@Mode", mode);
                SQL.FillDataSetBySP("SP_GetCertificate", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                return (byte[])ds.Tables[0].Rows[0][0];
            }
            else
            {
                return null;
            }
        }
        public DataSet GetDeliveryOrder(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.FillDataSetBySP2("SP_Rpt_Delivery", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public DataSet GetDeliveryInventory(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.FillDataSetBySP2("SP_Rpt_Delivery_Inventory", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
