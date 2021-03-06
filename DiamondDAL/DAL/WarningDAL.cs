﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class WarningDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsWarning ds = new dsWarning();
        int flag = 0;

        public dsWarning DoSearchData(string RefID, int StatusType, DateTime SDate, DateTime EDate, int LoginID,int IsInbox)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("RefID", RefID);
                SQL.CreateParameter("StatusType", StatusType);
                SQL.CreateParameter("SDate", SDate);
                SQL.CreateParameter("EDate", EDate);
                SQL.CreateParameter("loginID", LoginID);
                SQL.CreateParameter("IsInbox", IsInbox);
                SQL.FillDataSetBySP("SP_Warning_Search", ds.Warning);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsWarning DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Warning_Sel", ds.Warning);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsWarning tds)
        {
            try
            {
                dsWarning.WarningRow row = tds.Warning[0];
                SQL.ExecuteSP("SP_Warning_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsWarning tds)
        {
            try
            {
                dsWarning.WarningRow row = tds.Warning[0];
                flag = SQL.ExecuteSP("SP_Warning_Upd", row);
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
                flag = SQL.ExecuteSP("SP_Warning_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
