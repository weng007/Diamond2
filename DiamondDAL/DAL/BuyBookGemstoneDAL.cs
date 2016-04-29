using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookGemstoneDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookGemstone ds = new dsBuyBookGemstone();
        int flag = 0;

        public dsBuyBookGemstone DoSearchData(string Code, double Size, string Shape)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", Code);
                SQL.CreateParameter("Size", Size);
                SQL.CreateParameter("Shape", Shape);
                SQL.FillDataSetBySP("SP_BuyBookGemstone_Search", ds.BuyBookGemstone);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookGemstone DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookGemstone_Sel", ds.BuyBookGemstone);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookGemstone tds)
        {
            try
            {
                dsBuyBookGemstone.BuyBookGemstoneRow row = tds.BuyBookGemstone[0];
                SQL.ExecuteSP("SP_BuyBookGemstone_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookGemstone tds)
        {
            try
            {
                dsBuyBookGemstone.BuyBookGemstoneRow row = tds.BuyBookGemstone[0];
                flag = SQL.ExecuteSP("SP_BuyBookGemstone_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BuyBookGemstone_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
