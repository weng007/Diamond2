﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class BuyBookDiamondDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsBuyBookDiamond ds = new dsBuyBookDiamond();
        int flag = 0;

        public dsBuyBookDiamond DoSearchData(double sSize, double eSize, int colorGrade, int color, int clarity)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("SSize", sSize);
                SQL.CreateParameter("ESize", eSize);
                SQL.CreateParameter("ColorGrade", colorGrade);
                SQL.CreateParameter("Color", color);
                SQL.CreateParameter("Clarity", clarity);
                SQL.FillDataSetBySP("SP_BuyBookDiamond_Search", ds.BuyBookDiamond);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsBuyBookDiamond DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BuyBookDiamond_Sel", ds.BuyBookDiamond);            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public bool DoInsertData(dsBuyBookDiamond tds)
        {
            try
            {
                dsBuyBookDiamond.BuyBookDiamondRow row = tds.BuyBookDiamond[0];
                SQL.ExecuteSP("SP_BuyBookDiamond_Ins", row);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool DoUpdateData(dsBuyBookDiamond tds)
        {
            try
            {
                dsBuyBookDiamond.BuyBookDiamondRow row = tds.BuyBookDiamond[0];
                flag = SQL.ExecuteSP("SP_BuyBookDiamond_Upd", row);
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
                flag = SQL.ExecuteSP("SP_BuyBookDiamond_Del");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
