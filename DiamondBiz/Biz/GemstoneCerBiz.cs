using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class GemstoneCerBiz
    {
        dsGemstoneCer ds = new dsGemstoneCer();
        GemstoneCerDAL dal = new GemstoneCerDAL();

        public dsGemstoneCer DoSearchData(double sweight, double eweight, int shape, int origin, int companyCer, int gemstoneType)
        {
            try
            {
                return dal.DoSearchData(sweight, eweight, shape, origin, companyCer, gemstoneType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsGemstoneCer DoSelectData(int id)
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
        public bool DoInsertData(dsGemstoneCer tds)
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

        public bool DoUpdateData(dsGemstoneCer tds)
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
