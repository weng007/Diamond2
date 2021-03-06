﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class OrderDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsOrder ds = new dsOrder();
        int flag = 0;

        public dsOrder DoSearchData(string CustName, string Code, int Seller, int JewelryType)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("CustName", CustName);
                SQL.CreateParameter("Code", Code);
                SQL.CreateParameter("Seller", Seller);
                SQL.CreateParameter("JewelryType", JewelryType);
                SQL.FillDataSetBySP("SP_Order_Search", ds.Order);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsOrder DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_Order_Sel", ds.Order);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsOrder tds)
        {
            try
            {
                dsOrder.OrderRow row = tds.Order[0];
                SQL.ExecuteSP("SP_Order_Ins",row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsOrder tds)
        {
            try
            {
                dsOrder.OrderRow row = tds.Order[0];
                flag = SQL.ExecuteSP("SP_Order_Upd", row);
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
                flag = SQL.ExecuteSP("SP_Order_Del");
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
                SQL.FillDataSetBySP("SP_Order_By_Code", ds.Order);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return (int)ds.Order[0]["ID"];
        }

        public dsOrder GetFactoryStatus(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.FillDataSetBySP("SP_FactoryStatus_Sel", ds.Order);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool UpdateReceiveMaterial(int id, string isReceive)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@IsReceive", isReceive);
                flag = SQL.ExecuteSP("SP_Order_Upd_ReceiveMaterial");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public bool UpdateNoteStatus(int id, int note, string noteStatus, int sender)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@Note", note);
                SQL.CreateParameter("@NoteStatus", noteStatus);
                SQL.CreateParameter("@Sender", sender);
                flag = SQL.ExecuteSP("SP_Order_ConfirmNote");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
        public bool UpdateNote(int id, string note, int noteOrd, int editBy)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                SQL.CreateParameter("@Note", note);
                SQL.CreateParameter("@NoteOrd", noteOrd);
                SQL.CreateParameter("@EditBy", editBy);
                flag = SQL.ExecuteSP("SP_Order_Upd_Note");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
