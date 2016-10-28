using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheDocGiaDAO
    {
        Database db;
        public TheDocGiaDAO()
        {
            db = new Database();
        }

        /// <summary>
        /// Thêm thẻ độc giả mới
        /// </summary>
        /// <param name="maDocGia">id của độc giả mới</param>
        /// <param name="ngayTaoThe">Ngày tạo thẻ mới</param>
        public void themTheDocGia(int maDocGia, DateTime ngayTaoThe)
        {
            TheDocGia theDocGia = new TheDocGia();
            theDocGia.maDocGia = maDocGia;
            theDocGia.ngayTaoThe = ngayTaoThe;

            db.getDBContext().TheDocGias.InsertOnSubmit(theDocGia);
            db.getDBContext().SubmitChanges();

        }
    }
}
