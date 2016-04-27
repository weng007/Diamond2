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
        int flag = 0;

        public dsDiamondCer DoSearchData(string GIANumber, double sweight, double eweight, int shape,int colorGrade, int color, int clarity)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("GIANumber", GIANumber);
                SQL.CreateParameter("SWeight", sweight);
                SQL.CreateParameter("EWeight", eweight);
                SQL.CreateParameter("Shape", shape);
                SQL.CreateParameter("ColorGrade", colorGrade);
                SQL.CreateParameter("Color", color);
                SQL.CreateParameter("Clarity", clarity);
                SQL.FillDataSetBySP("SP_DiamondCer_Search", ds.DiamondCer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
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
