using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class MasterTableDetailDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsMasterTableDetail ds;
        MasterTableDetailDAL dal;

        public dsMasterTableDetail GetMasterTableDetail(string TypeID)
        {
            ds = new dsMasterTableDetail();
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("TypeID", TypeID);
                SQL.FillDataSetBySP("SP_MasterTableDetail_Sel_By_TypeID", ds.MasterTableDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}