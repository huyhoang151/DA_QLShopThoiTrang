using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BoPhanBLL
    {
        BoPhanDAL bp = new BoPhanDAL();

        public DataTable getCBBBoPhan()
        {
            return bp.getCBBBoPhan();
        }

    }
}
