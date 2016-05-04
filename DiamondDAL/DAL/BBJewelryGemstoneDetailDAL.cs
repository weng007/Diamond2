using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BBJewelryGemstoneDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBBJewelryGemstoneCerDetail ds = new dsBBJewelryGemstoneCerDetail();
        dsBBJewelryGemstoneDetail ds2 = new dsBBJewelryGemstoneDetail();
        int flag = 0;


        public dsBBJewelryGemstoneCerDetail DoSelectDataCer(int id)
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

        public dsBBJewelryGemstoneDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBJewelryGemstoneDetail_Sel", ds2.BBJewelryGemstoneDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds2;
        }

        public bool DoInsertDataCer(dsBBJewelryGemstoneCerDetail tds)
        {
            try
            {
                //if (tds.Tables[0].Rows.Count > 0)
                //{
                    dsBBJewelryGemstoneCerDetail.BBJewelryGemstoneCerDetailRow row = tds.BBJewelryGemstoneCerDetail[0];
                    SQL.ExecuteSP("SP_BBJewelryGemstoneCerDetail_Ins", row);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoInsertData(dsBBJewelryGemstoneDetail tds)
        {
            try
            {
                if (tds.Tables[0].Rows.Count > 0)
                {
                    dsBBJewelryGemstoneDetail.BBJewelryGemstoneDetailRow row = tds.BBJewelryGemstoneDetail[0];
                    SQL.ExecuteSP("SP_BBJewelryGemstoneDetail_Ins", row);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateDataCer(dsBBJewelryGemstoneCerDetail tds)
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
        public bool DoUpdateData(dsBBJewelryGemstoneDetail tds)
        {
            try
            {
                dsBBJewelryGemstoneDetail.BBJewelryGemstoneDetailRow row = tds.BBJewelryGemstoneDetail[0];
                flag = SQL.ExecuteSP("SP_BBJewelryGemstoneDetail_Upd", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public bool DoDeleteDataCer(int id)
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

        public bool DoDeleteData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("@ID", id);
                flag = SQL.ExecuteSP("SP_BBJewelryGemstoneDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
