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
        dsBBJewelryDiamondCerDetail ds = new dsBBJewelryDiamondCerDetail();
        dsBBJewelryDiamondDetail ds2 = new dsBBJewelryDiamondDetail();
        int flag = 0;

        public dsBBJewelryDiamondCerDetail DoSelectDataCer(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBJewelryDiamondCerDetail_Sel", ds.BBJewelryDiamondCerDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBBJewelryDiamondDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBJewelryDiamondDetail_Sel", ds2.BBJewelryDiamondDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds2;
        }

        public bool DoInsertDataCer(dsBBJewelryDiamondCerDetail tds)
        {
            try
            {
                dsBBJewelryDiamondCerDetail.BBJewelryDiamondCerDetailRow row = tds.BBJewelryDiamondCerDetail[0];
                SQL.ExecuteSP("SP_BBJewelryDiamondCerDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoInsertData(dsBBJewelryDiamondDetail tds)
        {
            try
            {
                dsBBJewelryDiamondDetail.BBJewelryDiamondDetailRow row = tds.BBJewelryDiamondDetail[0];
                SQL.ExecuteSP("SP_BBJewelryDiamondDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public bool DoUpdateDataCer(dsBBJewelryDiamondCerDetail tds)
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

        public bool DoDeleteDataCer(int id)
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
