using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class ProductDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsProduct ds = new dsProduct();
        int flag = 0;

        public dsProduct DoSearchData(string code, int shop, int status, int jewelryType)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("Shop", shop);
                SQL.CreateParameter("Status", status);
                SQL.CreateParameter("JewelryType", jewelryType);
                SQL.FillDataSetBySP("SP_Product_Search", ds.Product);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsProduct DoSelectData(int id)
        {
            ds.Tables.Clear();

            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP2("SP_Product_Sel", ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            ds.Tables[1].TableName = "Product";
            ds.Tables[0].TableName = "DiamondDetail";
            ds.Tables[2].TableName = "GemstoneDetail";

            return ds;
        }

        public bool DoInsertData(dsProduct tds)
        {
            try
            {
                dsProduct.ProductRow row = tds.Product[0];
                SQL.ExecuteSP("SP_Product_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsProduct tds)
        {
            try
            {
                dsProduct.ProductRow row = tds.Product[0];
                flag = SQL.ExecuteSP("SP_Product_Upd", row);
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
                flag = SQL.ExecuteSP("SP_Product_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
