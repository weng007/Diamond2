using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookGoldBiz
    {
        dsBuyBookGold ds = new dsBuyBookGold();
        BuyBookGoldDAL dal = new BuyBookGoldDAL();

        public dsBuyBookGold DoSearchData(double sSize, double eSize, int status)
        {
            try
            {
                return dal.DoSearchData(sSize,eSize,status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBuyBookGold DoSelectData(int id)
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
        public bool DoInsertData(dsBuyBookGold tds)
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

        public bool DoUpdateData(dsBuyBookGold tds)
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
