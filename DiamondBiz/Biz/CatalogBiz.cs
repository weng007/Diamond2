using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class CatalogBiz
    {
        dsCatalog ds = new dsCatalog();
        CatalogDAL dal = new CatalogDAL();

        //type 0 = Login, 1 = BuyBook
        public dsCatalog DoSearchData(string code, int mode, int Shop)
        {
            try
            {
                return dal.DoSearchData(code, mode,Shop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsCatalog DoSearchByType(string prefix, int mode)
        {
            try
            {
                return dal.DoSearchByType(prefix, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsCatalog DoSelectData(int id, int mode)
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
        //public bool DoInsertData(dsCatalog tds)
        //{
        //    try
        //    {
        //        return dal.DoInsertData(tds);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public bool DoUpdateData(dsCatalog tds)
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
