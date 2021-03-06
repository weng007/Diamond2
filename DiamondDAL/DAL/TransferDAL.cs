﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class TransferDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsTransfer ds = new dsTransfer();
        int flag = 0;

        public dsTransfer DoSearchData(int Sender, int TransferStatus, int SShop, int EShop, DateTime SSendDate, DateTime ESendDate,string isBuyBook)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Sender", Sender);
                SQL.CreateParameter("TransferStatus", TransferStatus);
                SQL.CreateParameter("SShop", SShop);
                SQL.CreateParameter("EShop", EShop);
                SQL.CreateParameter("SSendDate", SSendDate);
                SQL.CreateParameter("ESendDate", ESendDate);
                SQL.CreateParameter("IsBuyBook", isBuyBook);
                SQL.FillDataSetBySP("SP_Transfer_Search", ds.Transfer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsTransfer DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Transfer_Sel", ds.Transfer);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsTransfer tds)
        {
            try
            {
                dsTransfer.TransferRow row = tds.Transfer[0];
                SQL.ExecuteSP("SP_Transfer_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsTransfer tds)
        {
            try
            {
                dsTransfer.TransferRow row = tds.Transfer[0];
                flag = SQL.ExecuteSP("SP_Transfer_Upd", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public bool DoDeleteData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                flag = SQL.ExecuteSP("SP_Transfer_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public int DoSearchByCode(string code)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.FillDataSetBySP("SP_Transfer_By_Code", ds.Transfer);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return (int)ds.Transfer[0]["ID"];
        }

        public int UpdateTransferReceive(int ID, int EShop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", ID);
                SQL.CreateParameter("@EShop", EShop);
                flag = SQL.ExecuteSP("SP_Transfer_Upd_Receive");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return flag;
        }
    }
}
