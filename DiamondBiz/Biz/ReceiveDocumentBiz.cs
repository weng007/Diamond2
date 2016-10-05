using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class ReceiveDocumentBiz
    {
        dsReceiveDocument ds = new dsReceiveDocument();
        ReceiveDocumentDAL dal = new ReceiveDocumentDAL();


        public dsReceiveDocument DoSearchData(string ReceiveNo, DateTime SReceiveDate, DateTime EReceiveDate, int Receiver, string Seller)
        {
            try
            {
                return dal.DoSearchData(ReceiveNo, SReceiveDate, EReceiveDate, Receiver, Seller);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsReceiveDocument DoSelectData(int id)
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
        public bool DoInsertData(dsReceiveDocument tds)
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

        public bool DoUpdateData(dsReceiveDocument tds)
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
