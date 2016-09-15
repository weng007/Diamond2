using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class TransferBuyBookBiz
    {
        dsTransferBuyBook ds = new dsTransferBuyBook();
        TransferBuyBookDAL dal = new TransferBuyBookDAL();

        //type 0 = Login, 1 = BuyBook


        public dsTransferBuyBook DoSearchData(int shop, string code, string code2, int buybooktype)
        {
            try
            {
                return dal.DoSearchData(shop, code, code2, buybooktype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
