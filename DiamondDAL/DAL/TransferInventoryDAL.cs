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

        public dsTransferInventory DoSearchData(int shop,string code, int jewelrytype)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Shop", shop);
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("JewelryType", jewelrytype);
                SQL.FillDataSetBySP("SP_TransferInventory_Search", ds.TransferInventory);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
