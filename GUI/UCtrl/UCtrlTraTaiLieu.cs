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
using DTO;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GUI.UCtrl
{
    public partial class UCtrlTraTaiLieu : UserControl
    {
        private int maPhieuMuon;
        private List<TaiLieuKhiTraDTO> taiLieus;
        public UCtrlTraTaiLieu()
        {
            InitializeComponent();
        }

        private void khoaThongTinMuon()
        {
            btnTimKiem.Enabled = true;
            txbMaThe.Enabled = true;

            txbMaThe.Text = "";
            txbMaThe.Focus();
            txbTenThuThu.Text = "";
            txbTenDocGia.Text = "";
            dtbNgayMuon.Text = "";
            dtbNgayTra.Text = "";
            txbMaDocGia.Text = "";

            gCtrlTaiLieuMuon.DataSource = null;

            pnDanhSachTaiLieuMuon.Enabled = false;
            pnThongTinThe.Enabled = false;


        }

        

        private void gCtrlTaiLieuMuon_Click(object sender, EventArgs e)
        {

        }

        private void UCtrlTraTaiLieu_Load(object sender, EventArgs e)
        {
            khoaThongTinMuon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txbMaThe.Text != "")
            {
                kiemTraTheMuon();
            }else
            {
                MessageBox.Show("Vui lòng điền mã thẻ mượn."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiem tra the muon co ton tai
        /// </summary>
        private void kiemTraTheMuon()
        {
            btnTimKiem.Enabled = false;
            txbMaThe.Enabled = false;

            maPhieuMuon = Int32.Parse(txbMaThe.Text);
            bool tonTai = new PhieuMuonBUS().iThemMuonTonTai(maPhieuMuon);
           
            if (tonTai)
            {
                //Lay thong tin the muon
                hienThongTinTheMuon();
            }
            else
            {
                MessageBox.Show("Không tồn tại thẻ mượn, vui lòng kiểm tra lại."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                khoaThongTinMuon();
            }
        }

        /// <summary>
        /// Hien thong tin the muon
        /// </summary>
        private void hienThongTinTheMuon()
        {
            pnThongTinThe.Enabled = true;
            pnDanhSachTaiLieuMuon.Enabled = true;
            btnSave.Enabled = true;

            maPhieuMuon = Int32.Parse(txbMaThe.Text);
            PhieuMuonDTO phieuMuon = new PhieuMuonBUS().layPhieuMuon(maPhieuMuon);
            DocGiaDTO docGia = new DocGiaBUS().layDocGia(phieuMuon.maDocGia);
            ThuThuDTO thuThu = new ThuThuBUS().layThuThu(phieuMuon.maThuThu);

            txbTenThuThu.Text = thuThu.tenThuThu;
            txbTenDocGia.Text = docGia.tenDocGia;
            dtbNgayMuon.DateTime = phieuMuon.ngayMuon;
            dtbNgayTra.DateTime = phieuMuon.ngayHetHan;
            txbMaDocGia.Text = docGia.maDocGia.ToString();

            taiLieus = new TaiLieuBUS().getDsTaiLieuThuocPhieuMuon(maPhieuMuon);

            gCtrlTaiLieuMuon.DataSource = taiLieus;

            List<LoaiTinhTrangKhiTraDTO> loaiTinhTrang = new LoaiTinhTrangKhiTraBUS().layDanhSachLoaiTinhTrang();

            repositoryItemLookUpEditTinhTrang.DataSource = loaiTinhTrang;

           

        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            khoaThongTinMuon();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show(String.Format("Bạn muốn lưu thông tin xác nhận trả cho phiếu mượn {0} ?", maPhieuMuon)
                , "Thông báo"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if(xacNhan == DialogResult.Yes)
            {
                luuXacNhanTra();
            }
            else
            {

            }
        }

        private void luuXacNhanTra()
        {
            new PhieuTraBUS().luuPhieuTra(maPhieuMuon
                , Program.thuThu.maThuThu
                , DateTime.Now
                , taiLieus);

            MessageBox.Show("Lưu thẻ trả thành công."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

            btnSave.Enabled = false;
        }

        private void btnInTheTra_Click(object sender, EventArgs e)
        {

        }

        private void grdTaiLieuMuon_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int index = grdTaiLieuMuon.GetSelectedRows()[0];
            taiLieus[index].maTinhTrang = Convert.ToInt32(e.Value);
        }

       

        private void grdTaiLieuMuon_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }
    }
}
