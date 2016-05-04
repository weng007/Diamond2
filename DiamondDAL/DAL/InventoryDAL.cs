using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class InventoryDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsInventory ds = new dsInventory();
        int flag = 0;

        public dsInventory DoSearchData(string code)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.FillDataSetBySP("SP_Inventory_Search", ds.Inventory);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsInventory DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Inventory_Sel", ds.Inventory);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsInventory tds)
        {
            try
            {
                dsInventory.InventoryRow row = tds.Inventory[0];
                SQL.ExecuteSP("SP_Inventory_Ins", row);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsInventory tds)
        {
            try
            {
                dsInventory.InventoryRow row = tds.Inventory[0];
                flag = SQL.ExecuteSP("SP_Inventory_Upd", row);
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
                flag = SQL.ExecuteSP("SP_Inventory_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
