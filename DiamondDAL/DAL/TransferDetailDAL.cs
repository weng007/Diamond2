using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class TransferDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsTransferDetail ds = new dsTransferDetail();
        int flag = 0;
        public dsTransferDetail DoSelectData(int CatID)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("CatID", CatID);
                SQL.FillDataSetBySP("SP_TransferDetail_Sel", ds.TransferDetail);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public bool DoInsertData(dsTransferDetail tds)
        {
            try
            {
                dsTransferDetail.TransferDetailRow row = tds.TransferDetail[0];
                SQL.ExecuteSP("SP_TransferDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsTransferDetail tds)
        {
            try
            {
                dsTransferDetail.TransferDetailRow row = tds.TransferDetail[0];
                flag = SQL.ExecuteSP("SP_TransferDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_TransferDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
