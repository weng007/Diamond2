using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookSpecialDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookSpecial ds = new dsBuyBookSpecial();
        int flag = 0;

        public dsBuyBookSpecial DoSearchData(string search)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Detail", search);
                SQL.FillDataSetBySP("SP_BuyBookSpecial_Search", ds.BuyBookSpecial);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookSpecial DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookSpecial_Sel", ds.BuyBookSpecial);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookSpecial tds)
        {
            try
            {
                dsBuyBookSpecial.BuyBookSpecialRow row = tds.BuyBookSpecial[0];
                SQL.ExecuteSP("SP_BuyBookSpecial_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookSpecial tds)
        {
            try
            {
                dsBuyBookSpecial.BuyBookSpecialRow row = tds.BuyBookSpecial[0];
                flag = SQL.ExecuteSP("SP_BuyBookSpecial_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BuyBookSpecial_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
