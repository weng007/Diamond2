using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookETCDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookETC ds = new dsBuyBookETC();
        int flag = 0;

        public dsBuyBookETC DoSearchData(string Seller)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Seller", Seller);
                SQL.FillDataSetBySP("SP_BuyBookETC_Search", ds.BuyBookETC);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookETC DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookETC_Sel", ds.BuyBookETC);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookETC tds)
        {
            try
            {
                dsBuyBookETC.BuyBookETCRow row = tds.BuyBookETC[0];
                SQL.ExecuteSP("SP_BuyBookETC_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookETC tds)
        {
            try
            {
                dsBuyBookETC.BuyBookETCRow row = tds.BuyBookETC[0];
                flag = SQL.ExecuteSP("SP_BuyBookETC_Upd", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public bool DoDeleteData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                flag = SQL.ExecuteSP("SP_BuyBookJewelry_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
