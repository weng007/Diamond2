using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using System.Data;

namespace DiamondDAL.DAL
{
    public class UsereDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsUser ds = new dsUser();
        int flag = 0;

        public dsUser DoSearchData(string search, int shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Search", search);
                SQL.CreateParameter("Shop", shop);
                SQL.FillDataSetBySP("SP_User_Search", ds.User);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsUser DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_User_Sel", ds.User);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsUser DoAuthenticate(string userName, string password, int Shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("UserName", userName);
                SQL.CreateParameter("Password", password);
                SQL.CreateParameter("Shop", Shop);
                SQL.FillDataSetBySP("SP_User_Authenticate", ds.User);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsUser tds)
        {
            try
            {
                dsUser.UserRow row = tds.User[0];
                SQL.ExecuteSP("SP_User_Ins",row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsUser tds)
        {
            try
            {
                dsUser.UserRow row = tds.User[0];
                flag = SQL.ExecuteSP("SP_User_UPD", row);
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
                flag = SQL.ExecuteSP("SP_User_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
        public dsUser GetSeller()
        {
            try
            {
                SQL.ClearParameter();
                SQL.FillDataSetBySP("SP_Seller_Sel1", ds.User);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsUser GetBuyer()
        {
            try
            {
                SQL.ClearParameter();
                SQL.FillDataSetBySP("SP_Buyer_Sel", ds.User);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public int GetShopByUserID(int userID)
        {
            int shop = 0;
            DataSet ds1 = new DataSet();
            ds1.Tables.Add();

            try
            {
                SQL.ClearParameter();
                SQL.FillDataSet(string.Format("Select dbo.fns_GetShopByUserID('{0}')", userID), ds1.Tables[0]);

                if (ds1.Tables[0].Rows.Count > 0 && ds1.Tables[0].Rows[0][0].ToString() != "")
                {
                    shop = Convert.ToInt16(ds1.Tables[0].Rows[0][0]);
                    ds1.Clear();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return shop;
        }
    }
}
