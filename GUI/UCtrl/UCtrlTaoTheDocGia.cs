using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using GUI.Report;

namespace GUI
{
    public partial class UCtrlTaoTheDocGia : DevExpress.XtraEditors.XtraUserControl
    {
        public UCtrlTaoTheDocGia()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khởi tạo cấu hình cho Form mới
        /// </summary>
        private void init()
        {
            dtbNgayTaoThe.DateTime = DateTime.Now;
            txbTenThuThu.Text = Program.thuThu.tenThuThu;
            txbTenDocGia.Text = "";
            txbCMND.Text = "";
            dtbNgaySinh.Text = "";
            txbCMND.Enabled = true;
            dtbNgaySinh.Enabled = false;
            btnLuuThe.Enabled = false;
            btnInThe.Enabled = false;
            txbTenDocGia.Focus();
        }

        /// <summary>
        /// Hiển thị thông tin độc giả hiện có
        /// </summary>
        private void hienThiDanhSachDocGia()
        {
            gCtrlDocGia.DataSource = new DocGiaBUS().getAllDocGia();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txbCMND.Text != "")
            {
                kiemTraDocGiaTonTai();  
            }else
            {
                MessageBox.Show("Vui lòng điền thông tin CMND."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiem tra doc gia co ton tai hay chua
        /// </summary>
        /// <returns></returns>
        private void kiemTraDocGiaTonTai()
        {
            bool tonTai = new DocGiaBUS().iDocGiaTonTai(Int32.Parse(txbCMND.Text.ToString()));
            if (tonTai)
            {
                MessageBox.Show(String.Format("Độc giả với số CMND: {0} đã tồn tại trong hệ thống vui lòng kiểm tra lại.", txbCMND.Text.ToString())
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            else
            {
                //Kích hoạt lưu dữ liệu
                kichHoatLuuDuLieu();
            }
        }

        /// <summary>
        /// Kích hoạt control lưu dữ liệu
        /// </summary>
        private void kichHoatLuuDuLieu()
        {
            dtbNgaySinh.Enabled = true;
            btnLuuThe.Enabled = true;
            txbCMND.Enabled = false;
        }
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            DialogResult xacNhapTaoMoi = MessageBox.Show("Bạn muốn xóa dữ liệu đã nhập?"
                , "Thông báo"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);

            if(xacNhapTaoMoi == DialogResult.Yes)
            {
                //Xác nhận xóa trắng
                nhapMoi();
            }
            else
            {

            }
        }

        /// <summary>
        /// Xóa các dữ liệu đã nhập
        /// </summary>
        private void nhapMoi()
        {
            init();
        }
        private void btnLuuThe_Click(object sender, EventArgs e)
        {
            kiemTraDuLieuTrong();
        }

        /// <summary>
        /// Kiểm tra dữ liệu nhập vào có bị trống
        /// </summary>
        private void kiemTraDuLieuTrong()
        {
            if(txbTenDocGia.Text == "" || txbCMND.Text == "" || dtbNgaySinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            else
            {
                //Thêm dữ liệu
                themDuLieuDocGiaMoi();
            }
        }

        /// <summary>
        /// Thêm dữ liệu độc giả mới
        /// </summary>
        private void themDuLieuDocGiaMoi()
        {
            new DocGiaBUS().themDocGia(txbTenDocGia.Text
                , Int32.Parse(txbCMND.Text)
                , dtbNgaySinh.DateTime
                , dtbNgayTaoThe.DateTime);

            MessageBox.Show(String.Format("Độc giả với số CMND: {0} đã được thêm mới.", txbCMND.Text.ToString())
                   , "Thông báo"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Information);

            btnLuuThe.Enabled = false;
            btnInThe.Enabled = true;

            hienThiDanhSachDocGia();
        }
        private void btnInThe_Click(object sender, EventArgs e)
        {
            
        }

        private void UCtrlTaoTheDocGia_Load(object sender, EventArgs e)
        {
            init();
            hienThiDanhSachDocGia();
        }
    }
}
