using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class SellBiz
    {
        dsSell ds = new dsSell();
        SellDAL dal = new SellDAL();

        public dsSell DoSearchData(string code, int jewelryType)
        {
            try
            {
                return dal.DoSearchData(code, jewelryType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsSell DoSelectData(int id)
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
        public bool DoInsertData(dsSell tds)
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

        public bool DoUpdateData(dsSell tds)
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

        public int DoSearchByCode(string code)
        {
            try
            {
                return dal.DoSearchByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
