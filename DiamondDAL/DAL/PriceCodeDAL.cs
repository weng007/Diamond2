using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class PriceCodeDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsPriceCode ds = new dsPriceCode();
        int flag = 0;

        public dsPriceCode DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_PriceCode_Sel", ds.PriceCode);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsPriceCode tds)
        {
            try
            {
                dsPriceCode.PriceCodeRow row = tds.PriceCode[0];
                SQL.ExecuteSP("SP_PriceCode_Ins",row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsPriceCode tds)
        {
            try
            {
                dsPriceCode.PriceCodeRow row = tds.PriceCode[0];
                flag = SQL.ExecuteSP("SP_PriceCode_UPD", row);
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
                flag = SQL.ExecuteSP("SP_PriceCode_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
