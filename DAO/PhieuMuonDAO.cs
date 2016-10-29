using DTO;
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

        /// <summary>
        /// Kiểm tra thẻ mượn có tồn tại
        /// </summary>
        /// <param name="maTheMuon"></param>
        /// <returns></returns>
        public bool iThemMuonTonTai(int maTheMuon)
        {
            bool tonTai = false;
            int count = (from PhieuMuon in db.getDBContext().PhieuMuons
                         where !(from PhieuTra in db.getDBContext().PhieuTras
                                select PhieuTra.maPhieumuon).Contains(PhieuMuon.maPhieuMuon)
                         select PhieuMuon).Count();
            if(count > 0)
            {
                tonTai = true;
            }
            return tonTai;
        }

        /// <summary>
        /// Lay phieu muon
        /// </summary>
        /// <param name="maPhieuMuon"></param>
        /// <returns></returns>
        public PhieuMuonDTO layPhieuMuon(int maPhieuMuon)
        {
            var phieuMuon = db.getDBContext().PhieuMuons.Where(s => s.maPhieuMuon == maPhieuMuon).FirstOrDefault();
            return new PhieuMuonDTO {
                maDocGia = Convert.ToInt32(phieuMuon.maDocGia),
                maThuThu = Convert.ToInt32(phieuMuon.maThuThu),
                maPhieuMuon = Convert.ToInt32(phieuMuon.maPhieuMuon),
                ngayMuon = Convert.ToDateTime(phieuMuon.ngayMuon),
                ngayHetHan = Convert.ToDateTime(phieuMuon.ngayHetHan)
            };
        }
    }
}
