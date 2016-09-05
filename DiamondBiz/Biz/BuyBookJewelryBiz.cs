using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookJewelryBiz
    {
        dsBuyBookJewelry ds = new dsBuyBookJewelry();
        BuyBookJewelryDAL dal = new BuyBookJewelryDAL();

        public dsBuyBookJewelry DoSearchData(string code,string code2)
        {

            try
            {
                return dal.DoSearchData(code, code2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBuyBookJewelry DoSelectData(int id)
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
        public bool DoInsertData(dsBuyBookJewelry tds)
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

        public bool DoUpdateData(dsBuyBookJewelry tds)
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
