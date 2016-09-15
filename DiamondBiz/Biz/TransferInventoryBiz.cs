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


        public dsTransferInventory DoSearchData(int shop, string code, int jewelrytype)
        {
            try
            {
                return dal.DoSearchData(shop, code, jewelrytype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
