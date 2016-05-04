using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class InventoryDiamondDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsInvDiamondCerDetail ds = new dsInvDiamondCerDetail();
        dsInvDiamondDetail ds2 = new dsInvDiamondDetail();
        int flag = 0;

        public dsInvDiamondCerDetail DoSelectDataCer(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_InvDiamondCerDetail_Sel", ds.InvDiamondCerDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsInvDiamondDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_InvDiamondDetail_Sel", ds2.InvDiamondDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds2;
        }

        public bool DoInsertDataCer(dsInvDiamondCerDetail tds)
        {
            try
            {
                dsInvDiamondCerDetail.InvDiamondCerDetailRow row = tds.InvDiamondCerDetail[0];
                SQL.ExecuteSP("SP_InvDiamondCerDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
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


        public bool DoUpdateDataCer(dsInvDiamondCerDetail tds)
        {
            try
            {
                dsInvDiamondCerDetail.InvDiamondCerDetailRow row = tds.InvDiamondCerDetail[0];
                flag = SQL.ExecuteSP("SP_InvDiamondCerDetail_Upd", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
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

        public bool DoDeleteDataCer(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                flag = SQL.ExecuteSP("SP_InvDiamondCerDetail_Del");
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
