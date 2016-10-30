using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuTraDAO
    {
        Database db;
        public PhieuTraDAO()
        {
            db = new Database();
        }

        /// <summary>
        /// Luu thong tin xac nhan tra
        /// </summary>
        public int luuPhieuTra(int maPhieuMuon, int maThuThu, DateTime ngayTra)
        {
            int maPhieuTra = 0;
            PhieuTra phieuTra = new PhieuTra();
            phieuTra.maPhieumuon = maPhieuMuon;
            phieuTra.maThuThu = maThuThu;
            phieuTra.ngayTra = ngayTra;

            db.getDBContext().PhieuTras.InsertOnSubmit(phieuTra);
            db.getDBContext().SubmitChanges();

            maPhieuTra = phieuTra.maPhieuTra;
            return maPhieuTra;
        }
    }
}
