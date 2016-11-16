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

        public dsTransferBuyBook DoSelectData(int id)
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
        public bool DoInsertData(dsTransferBuyBook tds)
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

        public bool DoUpdateData(dsTransferBuyBook tds)
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

        public dsTransferBuyBook GetTransferBuyBookDetail(string codeSelected)
        {
            try
            {
                return dal.GetTransferBuyBookDetail(codeSelected);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
