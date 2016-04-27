using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookGoldDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookGold ds = new dsBuyBookGold();
        int flag = 0;

        public dsBuyBookGold DoSearchData(double sSize, double eSize,int status)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("SSize", sSize);
                SQL.CreateParameter("ESize", eSize);
                SQL.CreateParameter("Status", status);
                SQL.FillDataSetBySP("SP_BuyBookGold_Search", ds.BuyBookGold);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookGold DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookGold_Sel", ds.BuyBookGold);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookGold tds)
        {
            try
            {
                dsBuyBookGold.BuyBookGoldRow row = tds.BuyBookGold[0];
                SQL.ExecuteSP("SP_BuyBookGold_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookGold tds)
        {
            try
            {
                dsBuyBookGold.BuyBookGoldRow row = tds.BuyBookGold[0];
                flag = SQL.ExecuteSP("SP_BuyBookGold_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BuyBookGold_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
