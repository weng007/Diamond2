using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class DiamondCerDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsDiamondCer ds = new dsDiamondCer();
        dsBuyBookDiamondCer ds2 = new dsBuyBookDiamondCer();
        int flag = 0;

        public dsBuyBookDiamondCer DoSearchData(string reportNumber, int shape, int lab, double sWeight, double eWeight, int sColor,int eColor, int sClearity, int eClearity, int status, int shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ReportNumber", reportNumber);
                SQL.CreateParameter("Shape", shape);
                SQL.CreateParameter("Lab", lab);
                SQL.CreateParameter("SWeight", sWeight);
                SQL.CreateParameter("EWeight", eWeight);
                SQL.CreateParameter("SColor", sColor);
                SQL.CreateParameter("EColor", eColor);
                SQL.CreateParameter("sClearity", sClearity);
                SQL.CreateParameter("eClearity", eClearity);
                SQL.CreateParameter("Status", status);
                SQL.CreateParameter("Shop", shop);
                SQL.FillDataSetBySP("SP_BuyBookDiamondCer_Search", ds2.BuyBookDiamondCer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds2;
        }

        public dsDiamondCer DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_DiamondCer_Sel", ds.DiamondCer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsDiamondCer tds)
        {
            try
            {
                dsDiamondCer.DiamondCerRow row = tds.DiamondCer[0];
                SQL.ExecuteSP("SP_DiamondCer_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsDiamondCer tds)
        {
            try
            {
                dsDiamondCer.DiamondCerRow row = tds.DiamondCer[0];
                flag = SQL.ExecuteSP("SP_DiamondCer_Upd", row);
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
                flag = SQL.ExecuteSP("SP_DiamondCer_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
