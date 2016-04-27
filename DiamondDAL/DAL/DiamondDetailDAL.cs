using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class DiamondDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsDiamondDetail ds = new dsDiamondDetail();
        int flag = 0;

        public dsDiamondDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_DiamondDetail_Sel", ds.DiamondDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsDiamondDetail tds)
        {
            try
            {
                dsDiamondDetail.DiamondDetailRow row = tds.DiamondDetail[0];
                SQL.ExecuteSP("SP_DiamondDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsDiamondDetail tds)
        {
            try
            {
                dsDiamondDetail.DiamondDetailRow row = tds.DiamondDetail[0];
                flag = SQL.ExecuteSP("SP_DiamondDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_DiamondDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
