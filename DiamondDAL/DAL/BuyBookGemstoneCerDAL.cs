using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookGemstoneCerDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookGemstoneCer ds = new dsBuyBookGemstoneCer();
        dsBuyBookGemstoneCer_Excel ds2 = new dsBuyBookGemstoneCer_Excel();
        int flag = 0;

        public dsBuyBookGemstoneCer DoSearchData(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int identification, int comment, int origin,int status, int shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("ReportNumber", reportNumber);
                SQL.CreateParameter("Shape", shape);
                SQL.CreateParameter("Lab", lab);
                SQL.CreateParameter("SWeight", sWeight);
                SQL.CreateParameter("EWeight", eWeight);
                SQL.CreateParameter("Identification", identification);
                SQL.CreateParameter("Comment", comment);
                SQL.CreateParameter("Origin", origin);
                SQL.CreateParameter("Status", status);
                SQL.CreateParameter("Shop", shop);
                SQL.FillDataSetBySP("SP_BuyBookGemstoneCer_Search", ds.BuyBookGemstoneCer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookGemstoneCer DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookGemstoneCer_Sel", ds.BuyBookGemstoneCer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookGemstoneCer tds)
        {
            try
            {
                dsBuyBookGemstoneCer.BuyBookGemstoneCerRow row = tds.BuyBookGemstoneCer[0];
                SQL.ExecuteSP("SP_BuyBookGemstoneCer_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
        public bool DoInsertData(dsBuyBookGemstoneCer_Excel tds)
        {
            try
            {
                //    row["Payment"]

                foreach (dsBuyBookGemstoneCer_Excel.BuyBookGemstoneCer_ExcelRow row in tds.BuyBookGemstoneCer_Excel.Rows)
                {
                    SQL.ExecuteSP("SP_BuyBookGemstoneCer_ImpEx", row);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookGemstoneCer tds)
        {
            try
            {
                dsBuyBookGemstoneCer.BuyBookGemstoneCerRow row = tds.BuyBookGemstoneCer[0];
                flag = SQL.ExecuteSP("SP_BuyBookGemstoneCer_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BuyBookGemstoneCer_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
