using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;

namespace DiamondDAL.DAL
{
    public class TransferBuyBookDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsTransferBuyBook ds = new dsTransferBuyBook();
        int flag = 0;

        public dsTransferBuyBook DoSearchData(int shop,string code,string code2, int buybooktype)
        {
            try
            {
                SQL.ClearParameter();
                SQL.CreateParameter("Shop", shop);
                SQL.CreateParameter("Code", code);
                SQL.CreateParameter("Code2", code2);
                SQL.CreateParameter("BuyBookType", buybooktype);
                SQL.FillDataSetBySP("SP_TransferBuyBook_Search", ds.TransferBuyBook);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }
    }
}
