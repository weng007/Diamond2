using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class CustomerDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsCustomer ds = new dsCustomer();
        int flag = 0;

        public dsCustomer DoSearchData(string search,int shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Search", search);
                SQL.CreateParameter("Shop", shop);
                SQL.FillDataSetBySP("SP_Customer_Search", ds.Customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsCustomer DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Customer_Sel", ds.Customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsCustomer tds)
        {
            try
            {
                dsCustomer.CustomerRow row = tds.Customer[0];
                SQL.ExecuteSP("SP_Customer_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsCustomer tds)
        {
            try
            {
                dsCustomer.CustomerRow row = tds.Customer[0];
                flag = SQL.ExecuteSP("SP_Customer_Upd", row);
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
                flag = SQL.ExecuteSP("SP_Customer_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
