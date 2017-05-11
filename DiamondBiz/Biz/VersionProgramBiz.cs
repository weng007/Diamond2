using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class VersionProgramBiz
    {
        dsVersionProgram ds = new dsVersionProgram();
        VersionProgramDAL dal = new VersionProgramDAL();

        public int GetVersion()
        {
            try
            {
                return dal.GetVersion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
