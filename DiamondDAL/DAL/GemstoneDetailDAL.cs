using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class GemstoneDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsGemstoneDetail ds = new dsGemstoneDetail();
        int flag = 0;

        public dsGemstoneDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_GemstoneDetail_Sel", ds.GemstoneDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsGemstoneDetail tds)
        {
            try
            {
                dsGemstoneDetail.GemstoneDetailRow row = tds.GemstoneDetail[0];
                SQL.ExecuteSP("SP_GemstoneDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsGemstoneDetail tds)
        {
            try
            {
                dsGemstoneDetail.GemstoneDetailRow row = tds.GemstoneDetail[0];
                flag = SQL.ExecuteSP("SP_GemstoneDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_GemstoneDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
