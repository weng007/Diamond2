using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class InvDiamondDetailBiz
    {
        dsInvDiamondCerDetail ds = new dsInvDiamondCerDetail();
        dsInvDiamondDetail ds2 = new dsInvDiamondDetail();

        InventoryDiamondDetailDAL dal = new InventoryDiamondDetailDAL();

        public dsInvDiamondCerDetail DoSelectDataCer(int id)
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
        public dsInvDiamondDetail DoSelectData(int id)
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
        public bool DoInsertDataCer(dsInvDiamondCerDetail tds)
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
        public bool DoInsertData(dsInvDiamondDetail tds)
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

        public bool DoUpdateDataCer(dsInvDiamondCerDetail tds)
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
        public bool DoUpdateData(dsInvDiamondDetail tds)
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
