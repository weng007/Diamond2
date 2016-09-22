using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class OrderDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsOrder ds = new dsOrder();
        int flag = 0;

        public dsOrder DoSearchData(string CustName, string Code, int Seller, int JewelryType)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("CustName", CustName);
                SQL.CreateParameter("Code", Code);
                SQL.CreateParameter("Seller", Seller);
                SQL.CreateParameter("JewelryType", JewelryType);
                SQL.FillDataSetBySP("SP_Order_Search", ds.Order);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsOrder DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Order_Sel", ds.Order);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsOrder tds)
        {
            try
            {
                dsOrder.OrderRow row = tds.Order[0];
                SQL.ExecuteSP("SP_Order_Ins",row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsOrder tds)
        {
            try
            {
                dsOrder.OrderRow row = tds.Order[0];
                flag = SQL.ExecuteSP("SP_Order_Upd", row);
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
                flag = SQL.ExecuteSP("SP_Order_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
        public dsOrder GetFactoryStatus(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.FillDataSetBySP("SP_FactoryStatus_Sel", ds.Order);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
