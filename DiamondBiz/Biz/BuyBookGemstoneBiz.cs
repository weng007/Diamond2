using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookGemstoneBiz
    {
        dsBuyBookGemstone ds = new dsBuyBookGemstone();
        BuyBookGemstoneDAL dal = new BuyBookGemstoneDAL();

        public dsBuyBookGemstone DoSearchData(string Code, double Size, string Shape)
        {
            try
            {
                return dal.DoSearchData(Code, Size, Shape);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBuyBookGemstone DoSelectData(int id)
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
        public bool DoInsertData(dsBuyBookGemstone tds)
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

        public bool DoUpdateData(dsBuyBookGemstone tds)
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
