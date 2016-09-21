using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class WarningTransferDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsWarningTransfer ds = new dsWarningTransfer();
        int flag = 0;

        public dsWarningTransfer DoSearchData(int Sender, int Receiver, int MessageStatus, int FactoryStatus, int Shop, int loginID)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Sender", Sender);
                SQL.CreateParameter("Receiver", Receiver);
                SQL.CreateParameter("MessageStatus", MessageStatus);
                SQL.CreateParameter("FactoryStatus", FactoryStatus);
                SQL.CreateParameter("Shop", Shop);
                SQL.CreateParameter("loginID", loginID);
                SQL.FillDataSetBySP("SP_WarningTransfer_Search", ds.WarningTransfer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsWarningTransfer DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_WarningTransfer_Sel", ds.WarningTransfer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsWarningTransfer tds)
        {
            try
            {
                dsWarningTransfer.WarningTransferRow row = tds.WarningTransfer[0];
                SQL.ExecuteSP("SP_WarningTransfer_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsWarningTransfer tds)
        {
            try
            {
                dsWarningTransfer.WarningTransferRow row = tds.WarningTransfer[0];
                flag = SQL.ExecuteSP("SP_WarningTransfer_Upd", row);
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
                flag = SQL.ExecuteSP("SP_WarningTransfer_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
