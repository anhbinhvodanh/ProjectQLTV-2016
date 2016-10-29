using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiTinhTrangKhiTraDAO
    {
        Database db;
        public LoaiTinhTrangKhiTraDAO()
        {
            db = new Database();
        }


        /// <summary>
        /// Lay danh sach tinh trang khi tra trong database
        /// </summary>
        /// <returns></returns>
        public List<LoaiTinhTrangKhiTraDTO> layDanhSachLoaiTinhTrang()
        {
            var tinhTrangs = from LoaiTinhTrangKhiTra in db.getDBContext().LoaiTinhTrangKhiTras
                             select new LoaiTinhTrangKhiTraDTO
                             {
                                 maLoaiTinhTrang = LoaiTinhTrangKhiTra.maLoaiTinhTrang,
                                 tenLoaiTinhTrang = LoaiTinhTrangKhiTra.tenLoaiTinhTrang
                             };
            return tinhTrangs.ToList();
        }
    }
}
