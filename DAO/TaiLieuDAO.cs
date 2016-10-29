using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiLieuDAO
    {
        private Database db;

        public TaiLieuDAO()
        {
            db = new Database();
        }


        /// <summary>
        /// Lấy danh sách tài liệu hiện có (chưa được mượn)
        /// </summary>
        /// <returns></returns>
        public List<TaiLieuDTO> getDsTaiLieuHienCo()
        {
            var taiLieus = from TaiLieu in db.getDBContext().TaiLieus
                           where!(from ChiTietMuon in db.getDBContext().ChiTietMuons
                                 where !(from PhieuTra in db.getDBContext().PhieuTras
                                        select PhieuTra.maPhieumuon).Contains(ChiTietMuon.maPhieuMuon)
                                 select ChiTietMuon.maTaiLieu).Contains(TaiLieu.maTaiLieu)
                           select new TaiLieuDTO
                           {
                               maTaiLieu = TaiLieu.maTaiLieu,
                               tenTaiLieu = TaiLieu.tenTaiLieu
                           };
            return taiLieus.ToList();
        }
    }
}
