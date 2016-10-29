using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiTinhTrangKhiTraBUS
    {
        /// <summary>
        /// Lay danh sach tinh trang khi tra trong database
        /// </summary>
        /// <returns></returns>
        public List<LoaiTinhTrangKhiTraDTO> layDanhSachLoaiTinhTrang()
        {
            return new LoaiTinhTrangKhiTraDAO().layDanhSachLoaiTinhTrang();
        }
    }
}
