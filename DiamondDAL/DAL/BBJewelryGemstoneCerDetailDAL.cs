using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BBJewelryGemstoneCerDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBBJewelryGemstoneCerDetail ds = new dsBBJewelryGemstoneCerDetail();
        int flag = 0;

        public dsBBJewelryGemstoneCerDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBJewelryGemstoneCerDetail_Sel", ds.BBJewelryGemstoneCerDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBBJewelryGemstoneCerDetail tds)
        {
            try
            {
                foreach (dsBBJewelryGemstoneCerDetail.BBJewelryGemstoneCerDetailRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        SQL.ExecuteSP("SP_BBJewelryGemstoneCerDetail_Ins", row);
                    }
                    else
                    {
                        SQL.ExecuteSP("SP_BBJewelryGemstoneCerDetail_Upd", row);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBBJewelryGemstoneCerDetail tds)
        {
            try
            {
                dsBBJewelryGemstoneCerDetail.BBJewelryGemstoneCerDetailRow row = tds.BBJewelryGemstoneCerDetail[0];
                flag = SQL.ExecuteSP("SP_BBJewelryGemstoneCerDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BBJewelryGemstoneCerDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
