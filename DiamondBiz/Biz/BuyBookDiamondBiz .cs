using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookDiamondBiz
    {
        dsBuyBookDiamond ds = new dsBuyBookDiamond();
        BuyBookDiamondDAL dal = new BuyBookDiamondDAL();

        public dsBuyBookDiamond DoSearchData(string code,double sSize, double eSize, int shape)
        {
            try
            {
                return dal.DoSearchData(code, sSize,eSize, shape);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBuyBookDiamond DoSelectData(int id)
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
        public bool DoInsertData(dsBuyBookDiamond tds)
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

        public bool DoUpdateData(dsBuyBookDiamond tds)
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
