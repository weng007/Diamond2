using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookSettingBiz
    {
        dsBuyBookSetting ds = new dsBuyBookSetting();
        BuyBookSettingDAL dal = new BuyBookSettingDAL();

        public dsBuyBookSetting DoSearchData(string Seller, DateTime sBuyDate, DateTime eBuyDate)
        {
            try
            {
                return dal.DoSearchData(Seller, sBuyDate, eBuyDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBuyBookSetting DoSelectData(int id)
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
        public bool DoInsertData(dsBuyBookSetting tds)
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

        public bool DoUpdateData(dsBuyBookSetting tds)
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
