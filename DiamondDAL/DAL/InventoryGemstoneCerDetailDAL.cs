using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class InventoryGemstoneCerDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        //dsInvDiamondCerDetail ds = new dsInvDiamondCerDetail();
        dsInvGemstoneCerDetail ds = new dsInvGemstoneCerDetail();
        int flag = 0;


        public dsInvGemstoneCerDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_InvGemstoneCerDetail_Sel", ds.InvGemstoneCerDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsInvGemstoneCerDetail tds)
        {
            try
            {
                dsInvGemstoneCerDetail.InvGemstoneCerDetailRow row = tds.InvGemstoneCerDetail[0];
                SQL.ExecuteSP("SP_InvGemstoneCerDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public bool DoUpdateData(dsInvGemstoneCerDetail tds)
        {
            try
            {
                dsInvGemstoneCerDetail.InvGemstoneCerDetailRow row = tds.InvGemstoneCerDetail[0];
                flag = SQL.ExecuteSP("SP_InvGemstoneCerDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_InvGemstoneCerDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
