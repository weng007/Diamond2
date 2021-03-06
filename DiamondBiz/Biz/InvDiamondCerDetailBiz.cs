﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class InvDiamondCerDetailBiz
    {
        InvDiamondCerDetailDAL dal = new InvDiamondCerDetailDAL();

        //public dsBuyBookDiamondCer DoSearchData(string code, string reportNumber, int shape, int lab, double sWeight, double eWeight, int colorType, int sColor,
        //    int eColor, int sClearity, int eClearity, int status, int shop)
        //{
        //    //White Diamond
        //    if (colorType == 0)
        //    {
        //        //เพื่อให้แสดงทั้งหมด
        //        sColor = 0; eColor = 10000;
        //    }

        //    try
        //    {
        //        return dal.DoSearchData(code, reportNumber, shape, lab, sWeight, eWeight, colorType, sColor, eColor, sClearity, eClearity, status, shop);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public dsInvDiamondCerDetail DoSelectData(int id)
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
        public bool DoInsertData(dsInvDiamondCerDetail tds)
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

        public bool DoUpdateData(dsInvDiamondCerDetail tds)
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
