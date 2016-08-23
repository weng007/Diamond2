using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookPaymentBiz
    {
        dsBuyBookPayment ds = new dsBuyBookPayment();
        BuyBookPaymentDAL dal = new BuyBookPaymentDAL();

        public dsBuyBookPayment DoSearchData(string Seller, string tableName, DateTime sBuyDate, DateTime eBuyDate, string IsPaid, DateTime sPayDate, DateTime ePayDate)
        {
            try
            {
                return dal.DoSearchData(Seller, tableName, sBuyDate, eBuyDate, IsPaid, sPayDate, ePayDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsBuyBookPayment DoSelectData(int id)
        {
            try
            {
                return dal.DoSelectData(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoUpdateData(dsBuyBookPayment tds)
        {
            try
            {
                return dal.DoUpdateData(tds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public bool DoDeleteData(int id)
        //{
        //    try
        //    {
        //        return dal.DoDeleteData(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
