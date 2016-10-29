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

namespace GUI.UCtrl
{
    public partial class UCtrlTraTaiLieu : UserControl
    {
        public UCtrlTraTaiLieu()
        {
            InitializeComponent();
        }

        private void khoaThongTinMuon()
        {
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
            int maTheMuon = Int32.Parse(txbMaThe.Text);
            bool tonTai = new PhieuMuonBUS().iThemMuonTonTai(maTheMuon);
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
            }
        }

        /// <summary>
        /// Hien thong tin the muon
        /// </summary>
        private void hienThongTinTheMuon()
        {
            pnThongTinThe.Enabled = true;
            pnDanhSachTaiLieuMuon.Enabled = true;

            int maTheMuon = Int32.Parse(txbMaThe.Text);
            PhieuMuonDTO phieuMuon = new PhieuMuonBUS().layPhieuMuon(maTheMuon);
            DocGiaDTO docGia = new DocGiaBUS().layDocGia(phieuMuon.maDocGia);
            ThuThuDTO thuThu = new ThuThuBUS().layThuThu(phieuMuon.maThuThu);

            txbTenThuThu.Text = thuThu.tenThuThu;
            txbTenDocGia.Text = docGia.tenDocGia;
            dtbNgayMuon.DateTime = phieuMuon.ngayMuon;
            dtbNgayTra.DateTime = phieuMuon.ngayHetHan;
            txbMaDocGia.Text = docGia.maDocGia.ToString();
           
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            khoaThongTinMuon();
        }
    }
}
