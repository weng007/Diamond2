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

        public dsGemstoneCer DoSearchData(int identification, string code, string reportnumber, double sweight,double eweight, int shape, int comment,int lab,int origin, int status, int shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Identification", identification);
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("Reportnumber", reportnumber);
                SQL.CreateParameter("Sweight", sweight);
                SQL.CreateParameter("Eweight", eweight);
                SQL.CreateParameter("Shape", shape);
                SQL.CreateParameter("Comment", comment);
                SQL.CreateParameter("Lab", lab);
                SQL.CreateParameter("Origin", origin);
                SQL.CreateParameter("Status", status);
                SQL.CreateParameter("Shop", shop);
                SQL.FillDataSetBySP("SP_BuyBookGemstoneCer_Search", ds.GemstoneCer);
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
