using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class ExpenseGroupDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsExpenseGroup ds = new dsExpenseGroup();
        int flag = 0;

        public dsExpenseGroup DoSearchData(int ExpenseGroup)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ExpenseGroup", ExpenseGroup);
                SQL.FillDataSetBySP("SP_ExpenseGroup_Search", ds.ExpenseGroup);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsExpenseGroup DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_ExpenseGroup_Sel", ds.ExpenseGroup);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsExpenseGroup tds)
        {
            try
            {
                dsExpenseGroup.ExpenseGroupRow row = tds.ExpenseGroup[0];
                SQL.ExecuteSP("SP_ExpenseGroup_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsExpenseGroup tds)
        {
            try
            {
                dsExpenseGroup.ExpenseGroupRow row = tds.ExpenseGroup[0];
                flag = SQL.ExecuteSP("SP_ExpenseGroup_Upd", row);
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
                flag = SQL.ExecuteSP("SP_ExpenseGroup_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
        public dsExpenseGroup GetExpenseGroup()
        {
            try
            {
                SQL.ClearParameter();
                SQL.FillDataSetBySP("SP_ExpenseGroup_Sel2", ds.ExpenseGroup);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
