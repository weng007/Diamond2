using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class ExchangeRateDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsExchangeRate ds = new dsExchangeRate();
        int flag = 0;

        public dsExchangeRate DoSelectData()
        {
            try
            {
                SQL.ClearParameter();
                SQL.FillDataSetBySP("SP_ExchangeRate_Sel", ds.ExchangeRate);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }


        public bool DoUpdateData(dsExchangeRate tds)
        {
            try
            {
                dsExchangeRate.ExchangeRateRow row = tds.ExchangeRate[0];
                flag = SQL.ExecuteSP("SP_ExchangeRate_Upd", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

    }
}
