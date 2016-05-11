using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{

    public class BuyBookSettingDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookSetting ds = new dsBuyBookSetting();
        int flag = 0;

        public dsBuyBookSetting DoSearchData(int JewelryType,DateTime sBuyDate, DateTime eBuyDate)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("JewelryType", JewelryType);
                SQL.CreateParameter("SBuyDate", sBuyDate);
                SQL.CreateParameter("EBuyDate", eBuyDate);
                SQL.FillDataSetBySP("SP_BBSetting_Search", ds.BBSetting);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookSetting DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBSetting_Sel", ds.BBSetting);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookSetting tds)
        {
            try
            {
                dsBuyBookSetting.BBSettingRow row = tds.BBSetting[0];
                SQL.ExecuteSP("SP_BBSetting_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookSetting tds)
        {
            try
            {
                dsBuyBookSetting.BBSettingRow row = tds.BBSetting[0];
                flag = SQL.ExecuteSP("SP_BBSetting_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BBSetting_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
