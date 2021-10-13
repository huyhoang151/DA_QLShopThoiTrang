using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiDAL loai = new LoaiDAL();
        public DataTable getLoai()
        {
            return loai.getLoaiSP();
        }
    }
}
