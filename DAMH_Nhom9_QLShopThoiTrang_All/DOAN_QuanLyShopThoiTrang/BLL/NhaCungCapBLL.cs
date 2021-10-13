using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL ncc = new NhaCungCapDAL();

        public DataTable getData()
        {
            return ncc.getData();
        }

        public DataTable getDataByMaNCC(int mancc)
        {
            return ncc.getDataByMaNCC(mancc);
        }
    }
}
