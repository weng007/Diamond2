using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BBJewelryDiamondCerDetailBiz
    {
        dsBBJewelryDiamondCerDetail ds = new dsBBJewelryDiamondCerDetail();
        BBJewelryDiamondCerDetailDAL dal = new BBJewelryDiamondCerDetailDAL();

        public dsBBJewelryDiamondCerDetail DoSelectData(int refid)
        {
            try
            {
                return dal.DoSelectData(refid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBBJewelryDiamondCerDetail DoSelectData1(int id)
        {
            try
            {
                return dal.DoSelectData1(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoInsertData(dsBBJewelryDiamondCerDetail tds)
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
        public bool DoUpdateData(dsBBJewelryDiamondCerDetail tds)
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
