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

        public dsGemstoneCer DoSearchData(int identification, string code, string reportnumber, double sweight, double eweight, int shape, int comment, 
            int lab, int origin, int status, int shop,int mode)
        {
            try
            {
                return dal.DoSearchData(identification, code, reportnumber, sweight, eweight, shape, comment, lab, origin, status, shop,mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsGemstoneCer DoSelectData(int id, int mode)
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
