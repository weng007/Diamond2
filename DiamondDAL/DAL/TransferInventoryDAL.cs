using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class TransferInventoryDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsTransferInventory ds = new dsTransferInventory();
        int flag = 0;

        public dsTransferInventory DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_TransferDetail_Sel1", ds.TransferInventory);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsTransferInventory tds)
        {
            try
            {
                for (int i = 0; i < tds.TransferInventory.Rows.Count; i++)
                {
                    dsTransferInventory.TransferInventoryRow row = tds.TransferInventory[i];

                    if (Convert.ToInt32(tds.TransferInventory.Rows[i]["ID"].ToString()) < 0)
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

        public bool DoUpdateData(dsTransferInventory tds)
        {
            try
            {
                dsTransferInventory.TransferInventoryRow row = tds.TransferInventory[0];
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

        public dsTransferInventory DoSearchData(int shop,string code, int jewelryType)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Shop", shop);
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("JewelryType", jewelryType);
                SQL.FillDataSetBySP("SP_TransferInventory_Search", ds.TransferInventory);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsTransferInventory GetTransferInventoryDetail(string idSelected)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("IDSelected", idSelected);
                SQL.FillDataSetBySP("SP_GetTransferInventoryDetail", ds.TransferInventory);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
