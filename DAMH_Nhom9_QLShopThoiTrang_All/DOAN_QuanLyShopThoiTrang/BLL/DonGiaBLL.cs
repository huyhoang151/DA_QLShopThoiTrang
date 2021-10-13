using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonGiaBLL
    {
        DonGiaDAL dg = new DonGiaDAL();
        public DataTable getDonGia()
        {
            return dg.getDonGia();
        }
    }
}
