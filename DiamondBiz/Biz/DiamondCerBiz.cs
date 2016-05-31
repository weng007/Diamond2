using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class DiamondCerBiz
    {
        dsDiamondCer ds = new dsDiamondCer();
        dsBuyBookDiamondCer ds2 = new dsBuyBookDiamondCer();
        DiamondCerDAL dal = new DiamondCerDAL();

        public dsDiamondCer DoSearchData(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int colorType, int sColor,
            int eColor, int sClearity, int eClearity, int status, int shop, int mode)
        {
            //All
            if (colorType == 0)
            {
                //เพื่อให้แสดงทั้งหมด
                sColor = 0; eColor = 10000;
            }
            if (colorType != 0)
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
                return dal.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, colorType, sColor, eColor, sClearity, eClearity, status, shop, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsDiamondCer DoSelectData(int id, int mode)
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
        public bool DoInsertData(dsDiamondCer tds)
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

        public bool DoUpdateData(dsDiamondCer tds)
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
