using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class ExpenseBiz
    {
        dsExpense ds = new dsExpense();
        ExpenseDAL dal = new ExpenseDAL();

        public dsExpense DoSearchData(int ExpenseGroup, int Shop, DateTime SMemoDate, DateTime EMemoDate, DateTime SExpenseDate, DateTime EExpenseDate)
        {
            try
            {
                return dal.DoSearchData(ExpenseGroup, Shop, SMemoDate,  EMemoDate, SExpenseDate, EExpenseDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsExpense DoSelectData(int id)
        {
            try
            {
                return dal.DoSelectData(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DoInsertData(dsExpense tds)
        {
            try
            {
                return dal.DoInsertData(tds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoUpdateData(dsExpense tds)
        {
            try
            {
                return dal.DoUpdateData(tds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoDeleteData(int id)
        {
            try
            {
                return dal.DoDeleteData(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
