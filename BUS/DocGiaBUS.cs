using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DocGiaBUS
    {

        /// <summary>
        /// Hủy thẻ độc giả
        /// </summary>
        /// <param name="maDocGia">Mã độc giả cần hủy</param>
        public void huyTheDocGia(int maDocGia)
        {
            DateTime toDay = DateTime.Now;
            //Khóa trong 3 năm
            toDay = toDay.AddYears(3);
            new DocGiaDAO().huyTheDocGia(maDocGia, toDay);
        }

        /// <summary>
        /// Mở lại thẻ độc giả bị hủy
        /// </summary>
        /// <param name="maDocGia"></param>
        public void moLaiTheDocGia(int maDocGia)
        {
            DateTime toDay = DateTime.Now;
            toDay = toDay.AddDays(-1);
            new DocGiaDAO().moLaiTheDocGia(maDocGia, toDay);
        }

        /// <summary>
        /// Ham kiem tra doc gia da ton tai hay chua
        /// </summary>
        /// <param name="cmnd">So chung minh thu duy nhat cua doc gia</param>
        /// <returns>true: neu ton tai/ false: neu khong ton tai</returns>
        public bool iDocGiaTonTai(int cmnd)
        {
            return new DocGiaDAO().iDocGiaTonTai(cmnd);
        }

        /// <summary>
        /// Thêm độc giả mới kèm thẻ độc giả
        /// </summary>
        /// <param name="ten"></param>
        /// <param name="cmnd"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="ngayTao"></param>
        public void themDocGia(string ten, int cmnd, DateTime ngaySinh, DateTime ngayTao)
        {
            int maDocGia = new DocGiaDAO().themDocGia(ten, cmnd, ngaySinh);
            new TheDocGiaDAO().themTheDocGia(maDocGia, ngayTao);
        }

        /// <summary>
        /// Lấy ra danh sách độc giả còn khả dụng chưa bị hủy thẻ
        /// </summary>
        /// <returns></returns>
        public List<DocGiaDTO> getAllDocGia()
        {
            return new DocGiaDAO().getAllDocGia();
        }

        /// <summary>
        /// Lấy danh sách độc giả bị hủy thẻ
        /// </summary>
        /// <returns></returns>
        public List<DocGiaDTO> getAllDocGiaBiHuyThe()
        {
            return new DocGiaDAO().getAllDocGiaBiHuyThe();
        }
    }
}
