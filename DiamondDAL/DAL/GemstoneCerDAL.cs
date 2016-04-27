using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class GemstoneCerDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsGemstoneCer ds = new dsGemstoneCer();
        int flag = 0;

        public dsGemstoneCer DoSearchData(double sweight, double eweight, int shape, int origin, int companyCer, int gemstoneType)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("SWeight", sweight);
                SQL.CreateParameter("EWeight", eweight);
                SQL.CreateParameter("Shape", shape);
                SQL.CreateParameter("Origin", origin);
                SQL.CreateParameter("CompanyCer", companyCer);
                SQL.CreateParameter("GemstoneType", gemstoneType);
                SQL.FillDataSetBySP("SP_GemstoneCer_Search", ds.GemstoneCer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsGemstoneCer DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_GemstoneCer_Sel", ds.GemstoneCer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsGemstoneCer tds)
        {
            try
            {
                dsGemstoneCer.GemstoneCerRow row = tds.GemstoneCer[0];
                SQL.ExecuteSP("SP_GemstoneCer_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsGemstoneCer tds)
        {
            try
            {
                dsGemstoneCer.GemstoneCerRow row = tds.GemstoneCer[0];
                flag = SQL.ExecuteSP("SP_GemstoneCer_Upd", row);
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
                flag = SQL.ExecuteSP("SP_GemstoneCer_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
