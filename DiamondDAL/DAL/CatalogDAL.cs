using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class CatalogDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsCatalog ds = new dsCatalog();
        int flag = 0;

        public dsCatalog DoSearchData(string code, int mode,int Shop)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("Mode", mode);
                SQL.CreateParameter("Shop", Shop);
                SQL.FillDataSetBySP("SP_Catalog_Search", ds.Catalog);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsCatalog DoSelectData(int id, int mode)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("ID", id);
                SQL.CreateParameter("Mode", mode);
                SQL.FillDataSetBySP("SP_Catalog_Sel", ds.Catalog);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
        public dsCatalog DoSearchByType(string prefix, int mode)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("CatalogType", prefix);
                SQL.CreateParameter("Mode", mode);
                SQL.FillDataSetBySP("SP_Catalog_By_Type", ds.Catalog);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        //public bool DoInsertData(dsCatalog tds)
        //{
        //    try
        //    {
        //        dsCatalog.CatalogRow row = tds.Catalog[0];
        //        SQL.ExecuteSP("SP_Catalog_Ins", row);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return true;
        //}

        public bool DoUpdateData(dsCatalog tds)
        {
            try
            {
                dsCatalog.CatalogRow row = tds.Catalog[0];
                flag = SQL.ExecuteSP("SP_Catalog_UPD", row);
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
                flag = SQL.ExecuteSP("SP_Catalog_Del");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToBoolean(flag);
        }
    }
}
