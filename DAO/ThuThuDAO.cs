using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThuThuDAO
    {
        Database db;
        public ThuThuDAO()
        {
            db = new Database();
        }

        /// <summary>
        /// Lay thu thu
        /// </summary>
        /// <returns></returns>
        public ThuThuDTO layThuThu(int maThuThu)
        {
            var thuThu = db.getDBContext().ThuThus.Where(s => s.maThuThu == maThuThu).FirstOrDefault();
            return new ThuThuDTO
            {
                maThuThu = thuThu.maThuThu,
                tenThuThu = thuThu.tenThuThu,
                taiKhoan = thuThu.taiKhoan,
                matKhau = thuThu.matKhau,
                hide = Convert.ToBoolean(thuThu.hide == null ? false : true)
            };
        }
    }
}
