using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondDS.DS;
using DiamondDAL.DAL;
using System.Data;

namespace DiamondBiz.Biz
{
    public class GeneralCBiz
    {
        GeneralDAL dal = new GeneralDAL();
        int flag = 0;

        public string GetRunningNumber(string subject)
        {
            try
            {
                return dal.GetRunningNumber(subject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateJewelryStatus(int id, string status)
        {
            int tmp = 0;

            try
            {
                if(status =="Shop")
                {
                    tmp = 71;
                }
                else if(status == "Pending")
                {
                    tmp = 72;
                }
                else if(status == "Sold")
                {
                    tmp = 73;
                }

                return dal.UpdateJewelryStatus(id, tmp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetJewelryDetail(int id)
        {
            try
            {
                return dal.GetJewelryDetail(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public DataSet GetPriceDaimondAndGemstone(int id)
        {
            try
            {
                return dal.GetPriceDaimondAndGemstone(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetReportJewelry(int id)
        {
            try
            {
                return dal.GetReportJewelry(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
