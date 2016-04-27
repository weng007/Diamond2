using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class MasterTableDetailBiz
    {
        dsMasterTableDetail ds = new dsMasterTableDetail();
        MasterTableDetailDAL dal = new MasterTableDetailDAL();

        public dsMasterTableDetail GetMasterTableDetail(string TypeID)
        {
            try
            {
                return dal.GetMasterTableDetail(TypeID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
