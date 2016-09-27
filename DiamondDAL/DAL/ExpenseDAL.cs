using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class ExpenseDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsExpense ds = new dsExpense();
        int flag = 0;

        public dsExpense DoSearchData(int ExpenseGroup,int Shop , DateTime SMemoDate , DateTime EMemoDate , DateTime SExpenseDate, DateTime EExpenseDate)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ExpenseGroup", ExpenseGroup);
                SQL.CreateParameter("Shop", Shop);
                SQL.CreateParameter("SMemoDate", SMemoDate);
                SQL.CreateParameter("EMemoDate", EMemoDate);
                SQL.CreateParameter("SExpenseDate", SExpenseDate);
                SQL.CreateParameter("EExpenseDate", EExpenseDate);
                SQL.FillDataSetBySP("SP_Expense_Search", ds.Expense);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsExpense DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Expense_Sel", ds.Expense);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsExpense tds)
        {
            try
            {
                dsExpense.ExpenseRow row = tds.Expense[0];
                SQL.ExecuteSP("SP_Expense_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsExpense tds)
        {
            try
            {
                dsExpense.ExpenseRow row = tds.Expense[0];
                flag = SQL.ExecuteSP("SP_Expense_Upd", row);
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
                flag = SQL.ExecuteSP("SP_Expense_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
