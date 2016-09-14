using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class OrderDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsOrderDetail ds = new dsOrderDetail();
        
        int flag = 0;

        public DataSet DoSelectData(int id)
        {
            DataSet ds1 = new DataSet();
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("refID", id);
                SQL.FillDataSetBySP2("SP_OrderDetail_Sel", ds1);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds1;
        }

        public bool DoInsertData(dsOrderDetail tds)
        {
            try
            {
                foreach (dsOrderDetail.OrderDetailRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        SQL.ExecuteSP("SP_OrderDetail_Ins", row);
                    }
                    else
                    {
                        SQL.ExecuteSP("SP_OrderDetail_Upd", row);
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsOrderDetail tds)
        {
            try
            {
                dsOrderDetail.OrderDetailRow row = tds.OrderDetail[0];
                flag = SQL.ExecuteSP("SP_OrderDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_OrderDetail_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
