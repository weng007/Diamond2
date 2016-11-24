using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class InventoryBiz
    {
        dsInventory ds = new dsInventory();
        InventoryDAL dal = new InventoryDAL();

        public dsInventory DoSearchData(string code)
        {
            try
            {
                return dal.DoSearchData(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsInventory DoSearchByType(string prefix)
        {
            try
            {
                return dal.DoSearchByType(prefix);
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

        public dsInventory DoSelectData(int id)
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
        public bool DoInsertData(dsInventory tds)
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

        public bool DoUpdateData(dsInventory tds)
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

        public int CheckOrderNoExist(string orderNo)
        {
            try
            {
                return dal.CheckOrderNoExist(orderNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
