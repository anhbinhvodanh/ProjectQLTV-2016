using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietMuonDAO
    {
        Database db;
        public ChiTietMuonDAO()
        {
            db = new Database();
        }

        /// <summary>
        /// Tạo chi tiết mượn cho phiếu mượn
        /// </summary>
        /// <param name="maPhieuMuon"></param>
        /// <param name="taiLieus"></param>
        public void taoChiTietMuon(int maPhieuMuon, List<TaiLieuDTO> taiLieus)
        {
            ChiTietMuon chiTietMuon;
            List<ChiTietMuon> chiTietMuons = new List<ChiTietMuon>();
            foreach(TaiLieuDTO taiLieu in taiLieus)
            {
                chiTietMuon = new ChiTietMuon();
                chiTietMuon.maPhieuMuon = maPhieuMuon;
                chiTietMuon.maTaiLieu = taiLieu.maTaiLieu;

                chiTietMuons.Add(chiTietMuon);
            }

            db.getDBContext().ChiTietMuons.InsertAllOnSubmit(chiTietMuons);
            db.getDBContext().SubmitChanges();
        }
    }
}
