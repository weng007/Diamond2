using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class InvDiamondCerDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsInvDiamondCerDetail ds = new dsInvDiamondCerDetail();
        int flag = 0;

        //public dsInvDiamondCerDetail DoSearchData(int JewelryType, DateTime sBuyDate, DateTime eBuyDate)
        //{
        //    try
        //    {
        //        SQL.ClearParameter();
        //        SQL.CreateParameter("JewelryType", JewelryType);
        //        SQL.CreateParameter("SBuyDate", sBuyDate);
        //        SQL.CreateParameter("EBuyDate", eBuyDate);
        //        SQL.FillDataSetBySP("SP_BBSetting_Search", ds.BBSetting);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return ds;
        //}

        public dsInvDiamondCerDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_InvDiamondCerDetail_Sel", ds.InvDiamondCerDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsInvDiamondCerDetail tds)
        {
            try
            {
                dsInvDiamondCerDetail.InvDiamondCerDetailRow row = tds.InvDiamondCerDetail[0];
                SQL.ExecuteSP("SP_InvDiamondCerDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsInvDiamondCerDetail tds)
        {
            try
            {
                dsInvDiamondCerDetail.InvDiamondCerDetailRow row = tds.InvDiamondCerDetail[0];
                flag = SQL.ExecuteSP("SP_InvDiamondCerDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_InvDiamondCerDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
