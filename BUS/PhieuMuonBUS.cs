using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuMuonBUS
    {
        /// <summary>
        /// Tạo phiếu mượn
        /// </summary>
        /// <param name="maDocGia"></param>
        /// <param name="maThuThu"></param>
        /// <param name="ngayMuon"></param>
        /// <param name="ngayTra"></param>
        /// <param name="taiLieus">Danh sách các tài liệu mượn</param>
        public void taoPhieuMuon(int maDocGia, int maThuThu, DateTime ngayMuon, DateTime ngayTra, List<TaiLieuDTO> taiLieus)
        {
            int maPhieuMuon = 0;
            maPhieuMuon = new PhieuMuonDAO().taoPhieuMuon(maDocGia
                , maThuThu
                , ngayMuon
                , ngayTra);
            new ChiTietMuonDAO().taoChiTietMuon(maPhieuMuon, taiLieus);
        }

        /// <summary>
        /// Kiểm tra thẻ mượn có tồn tại
        /// </summary>
        /// <param name="maTheMuon"></param>
        /// <returns></returns>
        public bool iThemMuonTonTai(int maTheMuon)
        {
            return new PhieuMuonDAO().iThemMuonTonTai(maTheMuon);
        }

        /// <summary>
        /// Lay phieu muon
        /// </summary>
        /// <param name="maPhieuMuon"></param>
        /// <returns></returns>
        public PhieuMuonDTO layPhieuMuon(int maPhieuMuon)
        {
            return new PhieuMuonDAO().layPhieuMuon(maPhieuMuon);
        }
    }
}
