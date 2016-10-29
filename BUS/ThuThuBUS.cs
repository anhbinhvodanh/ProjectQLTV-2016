using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThuThuBUS
    {
        /// <summary>
        /// Lay thu thu
        /// </summary>
        /// <returns></returns>
        public ThuThuDTO layThuThu(int maThuThu)
        {
            return new ThuThuDAO().layThuThu(maThuThu);
        }
    }
}
