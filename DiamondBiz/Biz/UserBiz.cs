using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class UserBiz
    {
        dsUser ds = new dsUser();
        UsereDAL dal = new UsereDAL();

        //type 0 = Login, 1 = BuyBook
        public dsUser DoAuthenticate(string userName, string password, string type, int Shop)
        {
            try
            {
                return dal.DoAuthenticate(userName,password,type, Shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsUser DoSearchData(string search, int shop)
        {
            try
            {
                return dal.DoSearchData(search, shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsUser DoSelectData(int id)
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
        public bool DoInsertData(dsUser tds)
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

        public bool DoUpdateData(dsUser tds)
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
        public dsUser GetSeller()
        {
            try
            {
                return dal.GetSeller();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsUser GetBuyer()
        {
            try
            {
                return dal.GetBuyer();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
