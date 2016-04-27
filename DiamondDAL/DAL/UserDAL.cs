using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

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

        public dsUser DoAuthenticate(string userName, string password, string type)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("UserName", userName);
                SQL.CreateParameter("Password", password);
                SQL.CreateParameter("Type", type);
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
    }
}
