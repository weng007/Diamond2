using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookDiamondCerDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookDiamondCer ds = new dsBuyBookDiamondCer();
        dsBuyBookDiamondCer_Excel ds2 = new dsBuyBookDiamondCer_Excel();
        int flag = 0;

        public dsBuyBookDiamondCer DoSearchData(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int colorType, int sColor,
            int eColor, int sClearity, int eClearity, int status, int shop,string Code2)
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
                SQL.CreateParameter("ColorType", colorType);
                SQL.CreateParameter("SColor", sColor);
                SQL.CreateParameter("EColor", eColor);
                SQL.CreateParameter("sClearity", sClearity);
                SQL.CreateParameter("eClearity", eClearity);
                SQL.CreateParameter("Status", status);
                SQL.CreateParameter("Shop", shop);
                SQL.CreateParameter("Code2", Code2);
                SQL.FillDataSetBySP("SP_BuyBookDiamondCer_Search", ds.BuyBookDiamondCer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookDiamondCer DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookDiamondCer_Sel", ds.BuyBookDiamondCer);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookDiamondCer tds)
        {
            try
            {
                    dsBuyBookDiamondCer.BuyBookDiamondCerRow row = tds.BuyBookDiamondCer[0];
                    SQL.ExecuteSP("SP_BuyBookDiamondCer_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoInsertData(dsBuyBookDiamondCer_Excel tds)
        {
            try
            {
                //    row["Payment"]

                foreach (dsBuyBookDiamondCer_Excel.BuyBookDiamondCer_ExcelRow row in tds.BuyBookDiamondCer_Excel.Rows)
                {
                    SQL.ExecuteSP("SP_BuyBookDiamondCer_ImpEx", row);
                }
            }
           catch(Exception ex)
           {
                throw ex;
           }

           return true;
        }


        public bool DoUpdateData(dsBuyBookDiamondCer tds)
        {
            try
            {
                dsBuyBookDiamondCer.BuyBookDiamondCerRow row = tds.BuyBookDiamondCer[0];
                flag = SQL.ExecuteSP("SP_BuyBookDiamondCer_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BuyBookDiamondCer_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
