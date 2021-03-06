﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondDS.DS;
using DiamondDAL.DAL;
using System.Data;

namespace DiamondBiz.Biz
{
    public class GeneralBiz
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

        public int UpdateJewelryStatus(int id, string status, int shop)
        {
            int tmp = 0;

            try
            {
                if(status == "Available")
                {
                    tmp = 73;
                }
                else if(status == "Sold")
                {
                    tmp = 72;
                }
                else if (status == "Pending")
                {
                    tmp = 211;
                }

                return dal.UpdateJewelryStatus(id, tmp,shop);
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
        public DataSet GetReportBuying(int TableName, DateTime SBuyDate, DateTime EBuyDate, float SWeight, float EWeight, int Shape, int Status, DateTime SDueDate, DateTime EDueDate, int IsPaid)
        {
            try
            {
                return dal.GetReportBuying(TableName, SBuyDate, EBuyDate, SWeight, EWeight, Shape, Status, SDueDate, EDueDate, IsPaid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetReportSelling(int JewelryType, int Seller, DateTime SSellDate, DateTime ESellDate)
        {
            try
            {
                return dal.GetReportSelling(JewelryType, Seller, SSellDate, ESellDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetReportInventory(int Status, DateTime SImpDate, DateTime EImpDate, float SPriceTag, float EPricetag)
        {
            try
            {
                return dal.GetReportInventory(Status, SImpDate, EImpDate, SPriceTag, EPricetag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetReportDebt(int TableName, string Seller, DateTime SDueDate, DateTime EDueDate)
        {
            try
            {
                return dal.GetReportDebt(TableName, Seller, SDueDate, EDueDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetReportCustomer(DateTime SBirthDate, DateTime EBirthDate, DateTime SAnniDate, DateTime EAnniDate, string DisplayName)
        {
            try
            {
                return dal.GetReportCustomer(SBirthDate,EBirthDate,SAnniDate,EAnniDate,DisplayName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetReportOrder(int ID)
        {
            try
            {
                return dal.GetReportOrder(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetReportReceiveDocument(int ID)
        {
            try
            {
                return dal.GetReportReceiveDocument(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetReportCertificate(int id, string isPrintPrice)
        {
            try
            {
                return dal.GetReportCertificate(id, isPrintPrice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateMessageStatus(int id, string StatusType, string Flag)
        {
            try
            {
                return dal.UpdateMessageStatus(id, StatusType, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DoDeleteDataReference(int id, int flag)
        {
            try
            {
                return dal.DoDeleteDataReference(id, flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DoUpdateProductionLine(int id, int factoryStatus, int editBy)
        {
            try
            {
                return dal.DoUpdateProductionLine(id, factoryStatus, editBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet CountUnReadMessage(int userID)
        {
            try
            {
                return dal.CountUnReadMessage(userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte[] GetCertificate(int id, int mode)
        {
            try
            {
                return dal.GetCertificate(id, mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetDeliveryOrder(int id)
        {
            try
            {
                return dal.GetDeliveryOrder(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetDeliveryInventory(int id)
        {
            try
            {
                return dal.GetDeliveryInventory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
