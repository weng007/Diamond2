using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class BuyBookDiamondCerBiz
    {
        BuyBookDiamondCerDAL dal = new BuyBookDiamondCerDAL();

        public dsBuyBookDiamondCer DoSearchData(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int colorType, int sColor,
            int eColor, int sClearity, int eClearity, int status, int shop,string code2, int mode)
        {
            //All
            if(colorType == 0)
            {
                //เพื่อให้แสดงทั้งหมด
                sColor = 0; eColor = 10000;
            }   
            if(colorType != 0)
            {
                if (eColor == 0)
                { eColor = 10000; }
            }

            //All
            if (eClearity == 0)
            {
                //เพื่อให้แสดงทั้งหมด
                sClearity = 0; eClearity = 10000;
            }

            try
            {
                return dal.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, colorType, sColor, eColor, sClearity, eClearity, status, shop,code2, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsBuyBookDiamondCer DoSelectData(int id, int mode)
        {
            try
            {
                return dal.DoSelectData(id, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DoInsertData(dsBuyBookDiamondCer tds)
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

        public bool DoInsertData(dsBuyBookDiamondCer_Excel tds)
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

        public bool DoUpdateData(dsBuyBookDiamondCer tds)
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
