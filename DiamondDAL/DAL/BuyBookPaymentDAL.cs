using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookPaymentDAL
    {
        SQLHelper SQL = new SQLHelper();
       dsBuyBookPayment ds = new dsBuyBookPayment();
        int flag = 0;
        public dsBuyBookPayment DoSearchData(string Seller, string tableName, DateTime sBuyDate, DateTime eBuyDate, string IsPaid, DateTime sPayDate, DateTime ePayDate)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Seller", Seller);
                SQL.CreateParameter("tableName", tableName);
                SQL.CreateParameter("sBuyDate", sBuyDate);
                SQL.CreateParameter("eBuyDate", eBuyDate);
                SQL.CreateParameter("IsPaid", IsPaid);
                SQL.CreateParameter("sPayDate", sPayDate);
                SQL.CreateParameter("ePayDate", ePayDate);
                SQL.FillDataSetBySP("SP_BuyBookPayment_Search", ds.BuyBookPayment);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookPayment DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookPayment_Sel", ds.BuyBookPayment);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        //public bool DoInsertData(dsBuyBookPayment tds)
        //{
        //    try
        //    {
        //        DoDeleteData(Convert.ToInt32(tds.BuyBookPayment.Rows[0]["ID"].ToString()));
        //        foreach (dsBuyBookPayment.BuyBookPaymentRow row in tds.BuyBookPayment.Rows)
        //        {
        //            SQL.ExecuteSP("SP_BuyBookPayment_Ins", row);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return true;
        //}

        public bool DoUpdateData(dsBuyBookPayment tds)
        {
            try
            {
                //DoDeleteData(Convert.ToInt32(tds.BuyBookPayment.Rows[0]["ID"].ToString()));
                foreach (dsBuyBookPayment.BuyBookPaymentRow row in tds.BuyBookPayment.Rows)
                {
                    SQL.ExecuteSP("SP_BuyBookPayment_Upd", row);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        //public bool DoDeleteData(int id)
        //{
        //    try
        //    {
        //        SQL.ClearParameter();
        //        SQL.CreateParameter("@ID", id);
        //        flag = SQL.ExecuteSP("SP_BuyBookPayment_Del");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return Convert.ToBoolean(flag);
        //}
    }
}
