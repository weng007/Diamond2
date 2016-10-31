using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class SellBookDetailBiz
    {
        dsSellBookDetail ds = new dsSellBookDetail();
        SellBookDetailDAL dal = new SellBookDetailDAL();

        public dsSellBookDetail DoSelectData(int id)
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

        public bool DoInsertData(dsSellBookDetail tds)
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

        public bool DoUpdateData(dsSellBookDetail tds)
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

        public dsSellBookDetail GetSellBookDetail(string idSelected, int buyBookType)
        {
            try
            {
                return dal.GetSellBookDetail(idSelected, buyBookType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
