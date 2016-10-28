using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DocGiaDAO
    {
        private Database db;
        public DocGiaDAO()
        {
            db = new Database();
        }

        /// <summary>
        /// Hủy thẻ độc giả
        /// </summary>
        /// <param name="maDocGia">Mã độc giả cần hủy</param>s
        public void huyTheDocGia(int maDocGia, DateTime ngayMoLai)
        {
            bool iTonTai = false;
            XacNhanHuyThe xacNhanHuyThe;
            //Kiểm tra thẻ đã bị hủy trước đó hay chưa
            xacNhanHuyThe = db.getDBContext().XacNhanHuyThes.Where(s => s.maDocGia == maDocGia).FirstOrDefault();
            if (xacNhanHuyThe == null)
            {
                iTonTai = false;
                xacNhanHuyThe = new XacNhanHuyThe();
            }
            else
            {
                iTonTai = true;
            }
            xacNhanHuyThe.maDocGia = maDocGia;
            xacNhanHuyThe.ngayMoLai = ngayMoLai;
            if (!iTonTai)
            {
                //Nếu không tồn tại mới thêm mới
                db.getDBContext().XacNhanHuyThes.InsertOnSubmit(xacNhanHuyThe);
            }
            
            db.getDBContext().SubmitChanges();
        }

        /// <summary>
        /// Mở lại thẻ độc giả bị hủy
        /// </summary>
        /// <param name="maDocGia"></param>
        /// <param name="ngayMoLai"></param>
        public void moLaiTheDocGia(int maDocGia, DateTime ngayMoLai)
        {
            XacNhanHuyThe xacNhanHuyThe = db.getDBContext().XacNhanHuyThes.Where(s => s.maDocGia == maDocGia).FirstOrDefault();
            if(xacNhanHuyThe != null)
            {
                xacNhanHuyThe.ngayMoLai = ngayMoLai;
                db.getDBContext().SubmitChanges();
            }
        }

        /// <summary>
        /// Ham kiem tra doc gia da ton tai hay chua
        /// </summary>
        /// <param name="cmnd">So chung minh thu duy nhat cua doc gia</param>
        /// <returns>true: neu ton tai/ false: neu khong ton tai</returns>
        public bool iDocGiaTonTai(int cmnd)
        {
            bool tonTai = false;
            //Lay doc gia co so cmnd nhu tren
            int count = db.getDBContext().DocGias.Where(s => s.cmnd == cmnd).Count();
            if(count > 0)
            {
                tonTai = true;
            }
            return tonTai;
        }
        /// <summary>
        /// Thêm độc giả mới
        /// </summary>
        /// <param name="ten">Tên độc giả</param>
        /// <param name="cmnd">Chứng minh nhân dân</param>
        /// <param name="ngaySinh">Ngày sinh độc giả</param>
        /// <returns></returns>
        public int themDocGia(string ten, int cmnd, DateTime ngaySinh)
        {
            int maDocGia = 0;
            DocGia docGia = new DocGia();
            docGia.tenDocGia = ten;
            docGia.cmnd = cmnd;
            docGia.ngaySinh = ngaySinh;

            db.getDBContext().DocGias.InsertOnSubmit(docGia);
            db.getDBContext().SubmitChanges();

            //Lấy mã độc giả được tự động khởi tạo ra
            maDocGia = docGia.maDocGia;

            return maDocGia;
        }

        /// <summary>
        /// Lấy danh sách độc giả còn khả dụng (Chư bị hủy thẻ)
        /// </summary>
        /// <returns></returns>
        public List<DocGiaDTO> getAllDocGia()
        {
            var docGias = from docGia in db.getDBContext().DocGias
                          where !(from huyThe in db.getDBContext().XacNhanHuyThes
                                  where huyThe.ngayMoLai >= DateTime.Now
                                  select huyThe.maDocGia).Contains(docGia.maDocGia)
                          select new DocGiaDTO
                          {
                              maDocGia = docGia.maDocGia,
                              tenDocGia = docGia.tenDocGia,
                              ngaySinh = Convert.ToDateTime(docGia.ngaySinh),
                              cmnd = Convert.ToInt32(docGia.cmnd),
                              hide = Convert.ToBoolean(docGia.hide == null ? false : true)
                          };
            return docGias.ToList<DocGiaDTO>();
        }

        /// <summary>
        /// Lấy danh sách độc giả bị hủy thẻ
        /// </summary>
        /// <returns></returns>
        public List<DocGiaDTO> getAllDocGiaBiHuyThe()
        {
            var docGias = from docGia in db.getDBContext().DocGias
                          where (from huyThe in db.getDBContext().XacNhanHuyThes
                                  where huyThe.ngayMoLai >= DateTime.Now
                                  select huyThe.maDocGia).Contains(docGia.maDocGia)
                          select new DocGiaDTO
                          {
                              maDocGia = docGia.maDocGia,
                              tenDocGia = docGia.tenDocGia,
                              ngaySinh = Convert.ToDateTime(docGia.ngaySinh),
                              cmnd = Convert.ToInt32(docGia.cmnd),
                              hide = Convert.ToBoolean(docGia.hide == null ? false : true)
                          };
            return docGias.ToList<DocGiaDTO>();
        }
        
    }
}
