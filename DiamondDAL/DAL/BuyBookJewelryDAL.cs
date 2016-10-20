using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookJewelryDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookJewelry ds = new dsBuyBookJewelry();
        int flag = 0;

        public dsBuyBookJewelry DoSearchData(string code, string code2)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("Code2", code2);
                SQL.FillDataSetBySP("SP_BuyBookJewelry_Search", ds.BuyBookJewelry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public int DoSearchByCode(string code)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.FillDataSetBySP("SP_Jewelry_By_Code", ds.BuyBookJewelry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return (int)ds.BuyBookJewelry[0]["ID"];
        }

        public dsBuyBookJewelry DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookJewelry_Sel", ds.BuyBookJewelry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookJewelry tds)
        {
            try
            {
                dsBuyBookJewelry.BuyBookJewelryRow row = tds.BuyBookJewelry[0];
                SQL.ExecuteSP("SP_BuyBookJewelry_Ins", row);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookJewelry tds)
        {
            try
            {
                dsBuyBookJewelry.BuyBookJewelryRow row = tds.BuyBookJewelry[0];
                flag = SQL.ExecuteSP("SP_BuyBookJewelry_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BuyBookJewelry_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
