using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class SellBookBiz
    {
        dsSellBook ds = new dsSellBook();
        SellBookDAL dal = new SellBookDAL();

        public dsSellBook DoSearchData(string code)
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
        public dsSellBook DoSelectData(int id)
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
        public bool DoInsertData(dsSellBook tds)
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

        public bool DoUpdateData(dsSellBook tds)
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

        public bool UpdateSellBookStatus(int id, string status)
        {
            int tmp = 0;

            try
            {
                if (status == "Available")
                {
                    tmp = 73;
                }
                else if (status == "Pending")
                {
                    tmp = 1;
                }
                else if (status == "Sold")
                {
                    tmp = 72;
                }

                return dal.UpdateSellBookStatus(id, tmp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
