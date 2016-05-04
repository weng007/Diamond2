using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BBJewelryDiamondDetailBiz
    {
        dsBBJewelryDiamondCerDetail ds = new dsBBJewelryDiamondCerDetail();
        dsBBJewelryDiamondDetail ds2 = new dsBBJewelryDiamondDetail();

        BBJewelryDiamondDetailDAL dal = new BBJewelryDiamondDetailDAL();

        public dsBBJewelryDiamondCerDetail DoSelectDataCer(int id)
        {
            try
            {
                return dal.DoSelectDataCer(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsBBJewelryDiamondDetail DoSelectData(int id)
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
        public bool DoInsertDataCer(dsBBJewelryDiamondCerDetail tds)
        {
            try
            {
                return dal.DoInsertDataCer(tds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DoInsertData(dsBBJewelryDiamondDetail tds)
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

        public bool DoUpdateDataCer(dsBBJewelryDiamondCerDetail tds)
        {
            try
            {
                return dal.DoUpdateDataCer(tds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DoUpdateData(dsBBJewelryDiamondDetail tds)
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

        public bool DoDeleteDataCer(int id)
        {
            try
            {
                return dal.DoDeleteDataCer(id);
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
