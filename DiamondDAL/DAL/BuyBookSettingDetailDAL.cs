using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondDAL.DAL
{
    public class BuyBookSettingDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
         dsBuyBookSettingDetail ds = new dsBuyBookSettingDetail();
        int flag = 0;

        public dsBuyBookSettingDetail DoSearchData(int settingtype, DateTime sSBuydate, DateTime eBuydate)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Settingtype", settingtype);
                SQL.CreateParameter("SSBuydate", sSBuydate);
                SQL.CreateParameter("EBuydate", eBuydate);
                SQL.FillDataSetBySP("SP_BBSettingDetail_Search", ds.BBSettingDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookSettingDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBSettingDetail_Sel", ds.BBSettingDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookSettingDetail tds)
        {
            try
            {
                dsBuyBookSettingDetail.BBSettingDetailRow row = tds.BBSettingDetail[0];
                SQL.ExecuteSP("SP_BBSettingDetail_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookSettingDetail tds)
        {
            try
            {
                dsBuyBookSettingDetail.BBSettingDetailRow row = tds.BBSettingDetail[0];
                flag = SQL.ExecuteSP("SP_BBSettingDetail_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BBSettingDetail_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }

        public dsBuyBookSettingDetail DoSearchBBSettingDetail(int mode)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Mode", mode);
                SQL.FillDataSetBySP("SP_SearchBBSettingDetail", ds.BBSettingDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
