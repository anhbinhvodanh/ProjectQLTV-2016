using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietTinhTrangKhiTraDAO
    {
        Database db;
        public ChiTietTinhTrangKhiTraDAO()
        {
            db = new Database();
        }
        
        /// <summary>
        /// Luu thong tin tinh trang khi tra
        /// </summary>
        /// <param name="tinhTrangs"></param>
        public void luuTinhTrangKhiTra(List<ChiTietTinhTrangKhiTra> tinhTrangs)
        {
            db.getDBContext().ChiTietTinhTrangKhiTras.InsertAllOnSubmit(tinhTrangs);
            db.getDBContext().SubmitChanges();
        }
    }
}
