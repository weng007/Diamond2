using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class TransferBiz
    {
        dsTransfer ds = new dsTransfer();
        TransferDAL dal = new TransferDAL();

        public dsTransfer DoSearchData(int Sender, int TransferStatus, int SShop, int EShop, DateTime SSendDate, DateTime ESendDate, DateTime SReceiveDate, DateTime EReceiveDate,string Flag)
        {
            try
            {
                return dal.DoSearchData(Sender, TransferStatus,  SShop, EShop, SSendDate, ESendDate, SReceiveDate, EReceiveDate, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsTransfer DoSelectData(int id)
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
        public bool DoInsertData(dsTransfer tds)
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

        public bool DoUpdateData(dsTransfer tds)
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

        public int UpdateTransferReceive(int id, int eShop)
        {
            try
            {
                return dal.UpdateTransferReceive(id, eShop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
