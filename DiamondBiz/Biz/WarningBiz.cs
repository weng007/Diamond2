﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class WarningBiz
    {
        dsWarning ds = new dsWarning();
        WarningDAL dal = new WarningDAL();

        public dsWarning DoSearchData(int Sender, int Receiver, int MessageStatus, int FactoryStatus, int Shop, int loginID)
        {
            try
            {
                return dal.DoSearchData(Sender, Receiver, MessageStatus, FactoryStatus, Shop, loginID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsWarning DoSelectData(int id)
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
        public bool DoInsertData(dsWarning tds)
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

        public bool DoUpdateData(dsWarning tds)
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
