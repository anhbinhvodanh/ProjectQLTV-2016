using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuTraBUS
    {
        /// <summary>
        /// Luu thong tin xac nhan tra
        /// </summary>
        /// <param name="maPhieuMuon"></param>
        /// <param name="maThuThu"></param>
        /// <param name="ngayTra"></param>
        /// <param name="taiLieus"></param>
        public void luuPhieuTra(int maPhieuMuon, int maThuThu, DateTime ngayTra, List<TaiLieuKhiTraDTO> taiLieus)
        {
            int maPhieuTra = new PhieuTraDAO().luuPhieuTra(maPhieuMuon, maThuThu, ngayTra);

            var tinhTrangKhiTra = taiLieus.Select(s => new ChiTietTinhTrangKhiTra()
            {
                maPhieuTra = maPhieuTra,
                maChiTietMuon = s.maChiTietMuon,
                maLoaiTinhTrang = s.maTinhTrang
            }).ToList();

            new ChiTietTinhTrangKhiTraDAO().luuTinhTrangKhiTra(tinhTrangKhiTra);
        }
    }
}
