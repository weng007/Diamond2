using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class TransferBuyBookDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsTransferBuyBook ds = new dsTransferBuyBook();
        int flag = 0;

        public dsTransferBuyBook DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_TransferDetail_Sel", ds.TransferBuyBook);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsTransferBuyBook tds)
        {
            try
            {
                for(int i = 0; i < tds.TransferBuyBook.Rows.Count; i++)
                {
                    dsTransferBuyBook.TransferBuyBookRow row = tds.TransferBuyBook[i];

                    if (tds.TransferBuyBook.Rows[i]["ID"].ToString() == "")
                    {
                        SQL.ExecuteSP("SP_TransferDetail_Ins", row);
                    }
                    else
                    {
                        flag = SQL.ExecuteSP("SP_TransferDetail_Upd", row);
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsTransferBuyBook tds)
        {
            try
            {
                dsTransferBuyBook.TransferBuyBookRow row = tds.TransferBuyBook[0];
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

        public dsTransferBuyBook DoSearchData(int shop,string code,string code2, int buybooktype)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Shop", shop);
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("Code2", code2);
                SQL.CreateParameter("BuyBookType", buybooktype);
                SQL.FillDataSetBySP("SP_TransferBuyBook_Search", ds.TransferBuyBook);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsTransferBuyBook GetTransferBuyBookDetail(string codeSelected)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("CodeSelected", codeSelected);
                SQL.FillDataSetBySP("SP_GetTransferBuyBookDetail", ds.TransferBuyBook);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
