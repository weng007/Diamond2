using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class TransferInventoryBiz
    {
        dsTransferInventory ds = new dsTransferInventory();
        TransferInventoryDAL dal = new TransferInventoryDAL();

        //type 0 = Login, 1 = BuyBook

        public dsTransferInventory DoSelectData(int id)
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
        public bool DoInsertData(dsTransferInventory tds)
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

        public bool DoUpdateData(dsTransferInventory tds)
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
        public dsTransferInventory DoSearchData(int shop, string code, int jewelryType)
        {
            try
            {
                return dal.DoSearchData(shop, code, jewelryType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsTransferInventory GetTransferInventoryDetail(string idSelected)
        {
            try
            {
                return dal.GetTransferInventoryDetail(idSelected);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
