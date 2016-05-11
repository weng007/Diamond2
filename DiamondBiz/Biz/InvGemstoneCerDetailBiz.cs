using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class InvGemstoneCerDetailBiz
    {
        dsInvGemstoneCerDetail ds = new dsInvGemstoneCerDetail();

        InvGemstoneCerDetailDAL dal = new InvGemstoneCerDetailDAL();

        public dsInvGemstoneCerDetail DoSelectData(int id)
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

        public bool DoInsertData(dsInvGemstoneCerDetail tds)
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

        public bool DoUpdateData(dsInvGemstoneCerDetail tds)
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
