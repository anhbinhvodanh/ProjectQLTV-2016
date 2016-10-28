using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Database
    {
        private QuanLyThuVienDBDataContext db;
        public Database()
        {
            db = new QuanLyThuVienDBDataContext();
        }

        /// <summary>
        /// Hàm lấy công cụ giao tiếp với database
        /// </summary>
        /// <returns>Database context</returns>
        public QuanLyThuVienDBDataContext getDBContext()
        {
            return db;
        }
    }
}
