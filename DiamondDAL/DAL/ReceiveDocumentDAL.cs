using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class ReceiveDocumentDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsReceiveDocument ds = new dsReceiveDocument();
        int flag = 0;

        public dsReceiveDocument DoSearchData(string ReceiveNo,DateTime SReceiveDate, DateTime EReceiveDate, int Receiver, string Seller)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ReceiveNo", ReceiveNo);
                SQL.CreateParameter("SReceiveDate", SReceiveDate);
                SQL.CreateParameter("EReceiveDate", EReceiveDate);
                SQL.CreateParameter("Receiver", Receiver);
                SQL.CreateParameter("Seller", Seller);
                SQL.FillDataSetBySP("SP_ReceiveDocument_Search", ds.ReceiveDocument);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsReceiveDocument DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_ReceiveDocument_Sel", ds.ReceiveDocument);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsReceiveDocument tds)
        {
            try
            {
                dsReceiveDocument.ReceiveDocumentRow row = tds.ReceiveDocument[0];
                SQL.ExecuteSP("SP_ReceiveDocument_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsReceiveDocument tds)
        {
            try
            {
                dsReceiveDocument.ReceiveDocumentRow row = tds.ReceiveDocument[0];
                flag = SQL.ExecuteSP("SP_ReceiveDocument_Upd", row);
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
                flag = SQL.ExecuteSP("SP_ReceiveDocument_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
