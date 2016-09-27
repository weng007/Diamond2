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
        dsSellbook ds = new dsSellbook();
        int flag = 0;

        public dsSellbook DoSearchData(string code)
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
        public dsSellbook DoSelectData(int id)
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

        public bool DoInsertData(dsSellbook tds)
        {
            try
            {
                dsSellbook.SellBookRow row = tds.SellBook[0];
                SQL.ExecuteSP("SP_SellBook_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsSellbook tds)
        {
            try
            {
                dsSellbook.SellBookRow row = tds.SellBook[0];
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
    }
}
