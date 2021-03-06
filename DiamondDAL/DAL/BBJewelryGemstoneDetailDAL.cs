﻿using System;
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
        dsBBJewelryGemstoneDetail ds = new dsBBJewelryGemstoneDetail();
        int flag = 0;


        public dsBBJewelryGemstoneDetail DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_BBJewelryGemstoneDetail_Sel", ds.BBJewelryGemstoneDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        } 

        public bool DoInsertData(dsBBJewelryGemstoneDetail tds)
        {
            try
            {
                foreach (dsBBJewelryGemstoneDetail.BBJewelryGemstoneDetailRow row in tds.Tables[0].Rows)
                {
                    if (row["RowNum"].ToString() == "")
                    {
                        SQL.ExecuteSP("SP_BBJewelryGemstoneDetail_Ins", row);
                    }
                    else
                    {
                        SQL.ExecuteSP("SP_BBJewelryGemstoneDetail_Upd", row);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
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
