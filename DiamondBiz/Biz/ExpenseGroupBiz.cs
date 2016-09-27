using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class ExpenseGroupBiz
    {
        dsExpenseGroup ds = new dsExpenseGroup();
        ExpenseGroupDAL dal = new ExpenseGroupDAL();

        public dsExpenseGroup DoSearchData(int ExpenseGroup)
        {
            try
            {
                return dal.DoSearchData(ExpenseGroup);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsExpenseGroup DoSelectData(int id)
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
        public bool DoInsertData(dsExpenseGroup tds)
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

        public bool DoUpdateData(dsExpenseGroup tds)
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
        public dsExpenseGroup GetExpenseGroup()
        {
            try
            {
                return dal.GetExpenseGroup();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
