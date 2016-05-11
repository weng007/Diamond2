using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class InvDiamondDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        //dsInvDiamondCerDetail ds = new dsInvDiamondCerDetail();
        dsInvDiamondDetail ds = new dsInvDiamondDetail();
        int flag = 0;


        public dsInvDiamondDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_InvDiamondDetail_Sel", ds.InvDiamondDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsInvDiamondDetail tds)
        {
            try
            {
                dsInvDiamondDetail.InvDiamondDetailRow row = tds.InvDiamondDetail[0];
                SQL.ExecuteSP("SP_InvDiamondDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public bool DoUpdateData(dsInvDiamondDetail tds)
        {
            try
            {
                dsInvDiamondDetail.InvDiamondDetailRow row = tds.InvDiamondDetail[0];
                flag = SQL.ExecuteSP("SP_InvDiamondDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_InvDiamondDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
