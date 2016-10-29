using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using System.Data;

namespace DiamondDAL.DAL
{
    public class SellBookDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsSellBookDetail ds = new dsSellBookDetail();
        int flag = 0;

        public dsSellBookDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_SellBookDetail_Sel", ds.SellBookDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsSellBookDetail tds)
        {
            try
            {
                foreach (dsSellBookDetail.SellBookDetailRow row in tds.SellBookDetail.Rows)
                {
                    if (row.ID < 0)
                    {
                        SQL.ExecuteSP("SP_SellBookDetail_Ins", row);
                    }
                    else
                    {
                        SQL.ExecuteSP("SP_SellBookDetail_Upd", row);
                    }
                }              
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsSellBookDetail tds)
        {
            try
            {
                foreach (dsSellBookDetail.SellBookDetailRow row in tds.SellBookDetail.Rows)
                {
                    SQL.ExecuteSP("SP_SellBookDetail_Upd", row);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoDeleteData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                flag = SQL.ExecuteSP("SP_SellBookDetail_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public dsSellBookDetail GetSellBookDetail(string idSelected)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@IDSelected", idSelected);
                SQL.FillDataSetBySP("SP_GetSellBookDetail", ds.SellBookDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
