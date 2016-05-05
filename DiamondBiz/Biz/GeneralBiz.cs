using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class GeneralCBiz
    {
        GeneralDAL dal = new GeneralDAL();

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
    }
}
