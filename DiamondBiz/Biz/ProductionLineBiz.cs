using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class ProductionLineBiz
    {
        dsProductionLine ds = new dsProductionLine();
        ProductionLineDAL dal = new ProductionLineDAL();

        public dsProductionLine DoSearchData(string OrderNo, int JewelryType, int Shop, int FactoryStatus, DateTime SOrderDate, DateTime EOrderDate)
        {
            try
            {
                return dal.DoSearchData(OrderNo, JewelryType, Shop, FactoryStatus, SOrderDate, EOrderDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public dsProductionLine DoSelectData(int id)
        {
            try
            {
                return dal.DoSelectData(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public bool DoUpdateData(dsProductionLine tds)
        //{
        //    try
        //    {
        //        return dal.DoUpdateData(tds);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
