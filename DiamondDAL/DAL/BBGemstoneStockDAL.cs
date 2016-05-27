using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BBGemstoneStockDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBBGemstoneStock ds = new dsBBGemstoneStock();
        int flag = 0;

        public dsBBGemstoneStock DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBGemstoneStock_Sel", ds.BBGemstoneStock);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBBGemstoneStock tds)
        {
            try
            {
                DoDeleteData(Convert.ToInt32(tds.BBGemstoneStock.Rows[0]["RefID"].ToString()));
                foreach (dsBBGemstoneStock.BBGemstoneStockRow row in tds.BBGemstoneStock.Rows)
                {
                    SQL.ExecuteSP("SP_BBGemstoneStock_Ins", row);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBBGemstoneStock tds)
        {
            try
            {
                dsBBGemstoneStock.BBGemstoneStockRow row = tds.BBGemstoneStock[0];
                flag = SQL.ExecuteSP("SP_BBGemstoneStock_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BBGemstoneStock_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
