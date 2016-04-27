using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiamondDS.DS;
using DiamondDAL.DAL;

namespace DiamondBiz.Biz
{
    public class DiamondCerBiz
    {
        dsDiamondCer ds = new dsDiamondCer();
        DiamondCerDAL dal = new DiamondCerDAL();

        public dsDiamondCer DoSearchData(string GIANumber, double sweight, double eweight, int shape, int colorGrade, int color, int clarity)
        {
            try
            {
                return dal.DoSearchData(GIANumber,sweight,eweight,shape,colorGrade,color,clarity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsDiamondCer DoSelectData(int id)
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
        public bool DoInsertData(dsDiamondCer tds)
        {
            try
            {
                return dal.DoInsertData(tds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoUpdateData(dsDiamondCer tds)
        {
            try
            {
                return dal.DoUpdateData(tds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoDeleteData(int id)
        {
            try
            {
                return dal.DoDeleteData(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
