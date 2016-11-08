using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class ProductionLineDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsProductionLine ds = new dsProductionLine();
        int flag = 0;
        public dsProductionLine DoSearchData(string OrderNo, int JewelryType, int Shop, int FactoryStatus, DateTime SOrderDate, DateTime EOrderDate)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("OrderNo", OrderNo);
                SQL.CreateParameter("JewelryType", JewelryType);
                SQL.CreateParameter("Shop", Shop);
                SQL.CreateParameter("FactoryStatus", FactoryStatus);
                SQL.CreateParameter("SOrderDate", SOrderDate);
                SQL.CreateParameter("EOrderDate", EOrderDate);
                SQL.FillDataSetBySP("SP_ProductionLine_Search", ds.ProductionLine);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        public dsProductionLine DoSelectData(int id)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.FillDataSetBySP("SP_ProductionLine_Sel", ds.ProductionLine);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
