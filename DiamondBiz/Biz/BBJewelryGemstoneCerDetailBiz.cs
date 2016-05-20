using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BBJewelryGemstoneCerDetailBiz
    {
        dsBBJewelryGemstoneCerDetail ds = new dsBBJewelryGemstoneCerDetail();
        BBJewelryGemstoneCerDetailDAL dal = new BBJewelryGemstoneCerDetailDAL();

        public dsBBJewelryGemstoneCerDetail DoSelectData(int id)
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

        public bool DoInsertData(dsBBJewelryGemstoneCerDetail tds)
        {
            try
            {
                //if(tds.Tables[0].Rows.Count > 0 || tds2.Tables[0].Rows.Count > 0)
                //{ return dal.DoInsertData(tds,tds2); }
                return dal.DoInsertData(tds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //return false;
        }

        public bool DoUpdateData(dsBBJewelryGemstoneCerDetail tds)
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
