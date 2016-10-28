using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class SellBookDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsSellBook ds = new dsSellBook();
        int flag = 0;

        public dsSellBook DoSearchData(string code)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.FillDataSetBySP("SP_SellBook_Search", ds.SellBook);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsSellBook DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_SellBook_Sel", ds.SellBook);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsSellBook tds)
        {
            try
            {
                dsSellBook.SellBookRow row = tds.SellBook[0];
                SQL.ExecuteSP("SP_SellBook_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsSellBook tds)
        {
            try
            {
                dsSellBook.SellBookRow row = tds.SellBook[0];
                flag = SQL.ExecuteSP("SP_SellBook_Upd", row);
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
                flag = SQL.ExecuteSP("SP_SellBook_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public bool UpdateSellBookStatus(int id, int status)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.CreateParameter("Status", status);
                flag = SQL.ExecuteSP("SP_SellBook_Upd_SellStatus");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }      
    }
}
