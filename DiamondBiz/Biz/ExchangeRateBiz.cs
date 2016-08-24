using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class ExchangeRateBiz
    {
        dsExchangeRate ds = new dsExchangeRate();
        ExchangeRateDAL dal = new ExchangeRateDAL();

        public dsExchangeRate DoSelectData()
        {
            try
            {
                return dal.DoSelectData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoUpdateData(dsExchangeRate tds)
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
    }
}
