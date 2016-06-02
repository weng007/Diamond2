using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using System.Data;

namespace DiamondDAL.DAL
{
    public class GeneralDAL
    {
        SQLHelper SQL = new SQLHelper();
        DataSet ds = new DataSet();
        int flag = 0;

        public string GetRunningNumber(string subject)
        {
            string code = "";

            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@Result", "");
                SQL.CreateParameter("@Subject", subject);
                SQL.CreateParameter("@Arg1", DateTime.Today.Year);
                SQL.CreateParameter("@Arg2", DateTime.Today.Month);
                SQL.CreateParameter("@Arg3", "");
                SQL.FillDataSetBySP2("SP_GetRunningNo", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                code = subject + "-" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString().PadLeft(2,'0') + ds.Tables[1].Rows[0][0].ToString().PadLeft(3,'0');
            }

            return code;
        }

        public DataSet GetJewelryDetail(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@RefID", id);
                SQL.FillDataSetBySP2("SP_Sell_Detail", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public int UpdateJewelryStatus(int id, int status)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@Status", status);
                flag = SQL.ExecuteSP("SP_Sell_Upd_JewelryStatus");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return flag;
        }

        public DataSet GetPriceDaimondAndGemstone(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.FillDataSet(string.Format("Select * FROM dbo.fn_GetPriceDiamondAndGemstone('{0}')", id), ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
