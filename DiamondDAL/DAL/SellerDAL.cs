using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class SellerDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsSeller ds = new dsSeller();
        int flag = 0;

        public dsSeller DoSearchData(string search, int shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Search", search);
                SQL.CreateParameter("Shop", shop);
                SQL.FillDataSetBySP("SP_Seller_Search", ds.Seller);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsSeller DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Seller_Sel", ds.Seller);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsSeller tds)
        {
            try
            {
                dsSeller.SellerRow row = tds.Seller[0];
                SQL.ExecuteSP("SP_Seller_Ins",row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsSeller tds)
        {
            try
            {
                dsSeller.SellerRow row = tds.Seller[0];
                flag = SQL.ExecuteSP("SP_Seller_UPD", row);
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
                flag = SQL.ExecuteSP("SP_Seller_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public dsSeller GetSeller()
        {
            try
            {
                SQL.ClearParameter();
                SQL.FillDataSetBySP("SP_Seller_Sel1", ds.Seller);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsSeller GetBuyer()
        {
            try
            {
                SQL.ClearParameter();
                SQL.FillDataSetBySP("SP_Buyer_Sel", ds.Seller);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
