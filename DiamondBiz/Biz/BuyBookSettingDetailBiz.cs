using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookSettingDetailBiz
    {
        dsBuyBookSettingDetail ds = new dsBuyBookSettingDetail();
        BuyBookSettingDetailDAL dal = new BuyBookSettingDetailDAL();

        public dsBuyBookSettingDetail DoSearchData(int settingtype, DateTime sSBuydate, DateTime eBuydate)
        {
            try
            {
                return dal.DoSearchData(settingtype, sSBuydate, eBuydate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBuyBookSettingDetail DoSelectData(int id,int mode)
        {
            try
            {
                return dal.DoSelectData(id, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DoInsertData(dsBuyBookSettingDetail tds)
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

        public bool DoUpdateData(dsBuyBookSettingDetail tds)
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

        public dsBuyBookSettingDetail DoSearchBBSettingDetail(int mode)
        {
            try
            {
                return dal.DoSearchBBSettingDetail(mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
