using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BBJewelryDiamondCerDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBBJewelryDiamondCerDetail ds = new dsBBJewelryDiamondCerDetail();
        int flag = 0;

        public dsBBJewelryDiamondCerDetail DoSelectData(int refid)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("RefID", refid);
                SQL.FillDataSetBySP("SP_BBJewelryDiamondCerDetail_Sel", ds.BBJewelryDiamondCerDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsBBJewelryDiamondCerDetail DoSelectData1(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBJewelryDiamondCerDetail_Sel1", ds.BBJewelryDiamondCerDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBBJewelryDiamondCerDetail tds)
        {
            try
            {

                foreach (dsBBJewelryDiamondCerDetail.BBJewelryDiamondCerDetailRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        SQL.ExecuteSP("SP_BBJewelryDiamondCerDetail_Ins", row);
                    }
                    else
                    {
                        SQL.ExecuteSP("SP_BBJewelryDiamondCerDetail_Upd", row);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBBJewelryDiamondCerDetail tds)
        {
            try
            {
                dsBBJewelryDiamondCerDetail.BBJewelryDiamondCerDetailRow row = tds.BBJewelryDiamondCerDetail[0];
                flag = SQL.ExecuteSP("SP_BBJewelryDiamondCerDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BBJewelryDiamondCerDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
