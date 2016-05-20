using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BBJewelryDiamondDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        
        dsBBJewelryDiamondDetail ds = new dsBBJewelryDiamondDetail();
        int flag = 0;

        

        public dsBBJewelryDiamondDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBJewelryDiamondDetail_Sel", ds.BBJewelryDiamondDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        

        public bool DoInsertData(dsBBJewelryDiamondDetail tds)
        {
            try
            {
                foreach (dsBBJewelryDiamondDetail.BBJewelryDiamondDetailRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        SQL.ExecuteSP("SP_BBJewelryDiamondDetail_Ins", row);
                    }
                    else
                    {
                        SQL.ExecuteSP("SP_BBJewelryDiamondDetail_Upd", row);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public bool DoUpdateData(dsBBJewelryDiamondDetail tds)
        {
            try
            {
                dsBBJewelryDiamondDetail.BBJewelryDiamondDetailRow row = tds.BBJewelryDiamondDetail[0];
                flag = SQL.ExecuteSP("SP_BBJewelryDiamondDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BBJewelryDiamondDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
