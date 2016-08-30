using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class SellerBiz
    {
        dsSeller ds = new dsSeller();
        SellerDAL dal = new SellerDAL();

        public dsSeller DoSearchData(string search, int shop)
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

        public dsSeller DoSelectData(int id)
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
        public bool DoInsertData(dsSeller tds)
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

        public bool DoUpdateData(dsSeller tds)
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

        public dsSeller GetSeller()
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
        public dsSeller GetBuyer()
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
