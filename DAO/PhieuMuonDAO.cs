using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuMuonDAO
    {
        Database db;
        public PhieuMuonDAO()
        {
            db = new Database();
        }

        /// <summary>
        /// Tạo phiếu mượn mới
        /// </summary>
        /// <param name="maDocGia"></param>
        /// <param name="maThuThu"></param>
        /// <param name="ngayMuon"></param>
        /// <param name="ngayTra"></param>
        /// <returns>Mã phiếu mượn vừa thêm vào</returns>
        public int taoPhieuMuon(int maDocGia, int maThuThu, DateTime ngayMuon, DateTime ngayTra)
        {
            int maPhieuMuon = 0;
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.maDocGia = maDocGia;
            phieuMuon.maThuThu = maThuThu;
            phieuMuon.ngayMuon = ngayMuon;
            phieuMuon.ngayHetHan = ngayTra;
            db.getDBContext().PhieuMuons.InsertOnSubmit(phieuMuon);
            db.getDBContext().SubmitChanges();
            maPhieuMuon = phieuMuon.maPhieuMuon;
            return maPhieuMuon;
        }
    }
}
