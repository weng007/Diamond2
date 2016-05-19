using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class InvGemstoneDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        //dsInvDiamondCerDetail ds = new dsInvDiamondCerDetail();
        dsInvGemstoneDetail ds = new dsInvGemstoneDetail();
        int flag = 0;


        public dsInvGemstoneDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_InvGemstoneDetail_Sel", ds.InvGemstoneDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsInvGemstoneDetail tds)
        {
            try
            {
                foreach (dsInvGemstoneDetail.InvGemstoneDetailRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        SQL.ExecuteSP("SP_InvGemstoneDetail_Ins", row);
                    }
                    else
                    {
                        SQL.ExecuteSP("SP_InvGemstoneDetail_Upd", row);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public bool DoUpdateData(dsInvGemstoneDetail tds)
        {
            try
            {
                dsInvGemstoneDetail.InvGemstoneDetailRow row = tds.InvGemstoneDetail[0];
                flag = SQL.ExecuteSP("SP_InvGemstoneDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_InvGemstoneDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
