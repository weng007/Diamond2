using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class SellDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsSell ds = new dsSell();
        int flag = 0;

        public dsSell DoSearchData(string code,int jewelryType)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("Type", jewelryType);
                SQL.FillDataSetBySP("SP_Sell_Search", ds.Sell);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsSell DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Sell_Sel", ds.Sell);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsSell tds)
        {
            try
            {
                dsSell.SellRow row = tds.Sell[0];
                SQL.ExecuteSP("SP_Sell_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsSell tds)
        {
            try
            {
                dsSell.SellRow row = tds.Sell[0];
                flag = SQL.ExecuteSP("SP_Sell_Upd", row);
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
                flag = SQL.ExecuteSP("SP_Sell_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
