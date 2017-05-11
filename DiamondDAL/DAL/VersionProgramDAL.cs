using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;


namespace DiamondDAL.DAL    
{
    public class VersionProgramDAL
    {
        SQLHelper SQL = new SQLHelper();
        dsVersionProgram ds = new dsVersionProgram();
        int flag = 0;

        public int GetVersion()
        {
            try
            {
                SQL.ClearParameter();
                SQL.FillDataSetBySP("SP_GetVersionProgram", ds.VersionProgram);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return (int)ds.VersionProgram.Rows[0]["Version"];
        }

    }
}
