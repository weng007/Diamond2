using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class OrderBiz
    {
        dsOrder ds = new dsOrder();
        OrderDAL dal = new OrderDAL();

        //type 0 = Login, 1 = BuyBook
        public dsOrder DoSearchData(string CustName, string Code, int Seller, int JewelryType)
        {
            try
            {
                return dal.DoSearchData(CustName, Code, Seller, JewelryType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsOrder DoSelectData(int id)
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
        public bool DoInsertData(dsOrder tds)
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

        public bool DoUpdateData(dsOrder tds)
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

        public dsOrder GetFactoryStatus(int id)
        {
            try
            {
                return dal.GetFactoryStatus(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateReceiveMaterial(int id, string isReceive)
        {
            try
            {
                return dal.UpdateReceiveMaterial(id, isReceive);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateNoteStatus(int id, int note, string noteStatus)
        {
            try
            {
                return dal.UpdateNoteStatus(id, note, noteStatus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateNote(int id, string note, int noteOrd)
        {
            try
            {
                return dal.UpdateNote(id,note,noteOrd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
