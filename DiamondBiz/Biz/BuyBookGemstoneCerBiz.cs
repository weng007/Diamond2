using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookGemstoneCerBiz
    {
        dsBuyBookGemstoneCer ds = new dsBuyBookGemstoneCer();
        BuyBookGemstoneCerDAL dal = new BuyBookGemstoneCerDAL();

        public dsBuyBookGemstoneCer DoSearchData(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int identification, int comment, int origin, int status, int shop)
        {
            try
            {
                return dal.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, identification, comment, origin, status, shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBuyBookGemstoneCer DoSelectData(int id)
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
        public bool DoInsertData(dsBuyBookGemstoneCer tds)
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

        public bool DoUpdateData(dsBuyBookGemstoneCer tds)
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
