using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BBDiamondStockCDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBBDiamondStock ds = new dsBBDiamondStock();
        int flag = 0;

        public dsBBDiamondStock DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBDiamondStock_Sel", ds.BBDiamondStock);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBBDiamondStock tds)
        {
            try
            {
                DoDeleteData(Convert.ToInt32(tds.BBDiamondStock.Rows[0]["RefID"].ToString()));
                foreach (dsBBDiamondStock.BBDiamondStockRow row in tds.BBDiamondStock.Rows)
                {
                    SQL.ExecuteSP("SP_BBDiamondStock_Ins", row);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBBDiamondStock tds)
        {
            try
            {
                dsBBDiamondStock.BBDiamondStockRow row = tds.BBDiamondStock[0];
                flag = SQL.ExecuteSP("SP_BBDiamondStock_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BBDiamondStock_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
