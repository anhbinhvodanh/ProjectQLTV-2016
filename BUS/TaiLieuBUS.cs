using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiLieuBUS
    {
        /// <summary>
        /// Lấy danh sách tài liệu hiện có (chưa được mượn)
        /// </summary>
        /// <returns></returns>
        public List<TaiLieuDTO> getDsTaiLieuHienCo()
        {
            return new TaiLieuDAO().getDsTaiLieuHienCo();
        }
    }
}
