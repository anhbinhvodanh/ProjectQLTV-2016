using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GUI.UCtrl
{
    public partial class UCtrlMuonTaiLieu : DevExpress.XtraEditors.XtraUserControl
    {
        private int maDocGiaMuon;
        private List<TaiLieuDTO> taiLieuKho;
        private List<TaiLieuDTO> taiLieuMuon;
        public UCtrlMuonTaiLieu()
        {
            InitializeComponent();
        }

        private void UCtrlMuonTaiLieu_Load(object sender, EventArgs e)
        {
            khoaThongTinMuon();
            hienThiDanhSachDocGia();

            txbTenThuThu.Text = Program.thuThu.tenThuThu;
            dtbNgayMuon.DateTime = DateTime.Now;

            taiLieuKho =  new TaiLieuBUS().getDsTaiLieuHienCo();
            taiLieuMuon = new List<TaiLieuDTO>();
            
            gCtrlTaiLieuKho.DataSource = taiLieuKho;
            gCtrlTaiLieuMuon.DataSource = taiLieuMuon;
        }

        /// <summary>
        /// Khóa thông tin mượn để chọn độc giả
        /// </summary>
        private void khoaThongTinMuon()
        {
            pnTheMuon.Enabled = false;
            pnDanhSachTaiLieu.Enabled = false;

            gCtrlDocGia.Enabled = true;
            btnChonDocGiaMuon.Enabled = true;
        }

        /// <summary>
        /// Mở khóa thông tin mượn
        /// </summary>
        private void moKhoaThongTinMuon()
        {
       
            pnTheMuon.Enabled = true;
            pnDanhSachTaiLieu.Enabled = true;

            gCtrlDocGia.Enabled = false;
            btnChonDocGiaMuon.Enabled = false;

        }

        /// <summary>s
        /// Hiển thị danh sách độc giả
        /// </summary>
        private void hienThiDanhSachDocGia()
        {
            gCtrlDocGia.DataSource = new DocGiaBUS().getAllDocGia();
        }

        private void btnChonDocGiaMoi_Click(object sender, EventArgs e)
        {
            //Xóa thông tin mượn
            maDocGiaMuon = -1;
            txbTenDocGia.Text = "";
            txbMaDocGia.Text = "";

            taiLieuKho = new TaiLieuBUS().getDsTaiLieuHienCo();
            taiLieuMuon = new List<TaiLieuDTO>();

            gCtrlTaiLieuKho.DataSource = taiLieuKho;
            gCtrlTaiLieuMuon.DataSource = taiLieuMuon;

            grdTaiLieuKho.RefreshData();
            grdTaiLieuMuon.RefreshData();

            khoaThongTinMuon();
        }

        private void btnChonDocGiaMuon_Click(object sender, EventArgs e)
        {
            //Nếu có đang chọn độc giả
            if (grdDocGia.SelectedRowsCount > 0)
            {
                chonDocGiaMuon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả"
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chọn độc giả cần mượn tài liệu
        /// </summary>
        public void chonDocGiaMuon()
        {
            int index = grdDocGia.GetSelectedRows()[0];
            var ma = grdDocGia.GetRowCellValue(index, "maDocGia");
            var ten = grdDocGia.GetRowCellValue(index, "tenDocGia");
            maDocGiaMuon = Int32.Parse(ma.ToString());

            txbMaDocGia.Text = ma.ToString();
            txbTenDocGia.Text = ten.ToString();

            moKhoaThongTinMuon();

        }

        private void grdDocGia_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            khoaThongTinMuon();
        }

        private void gCtrlTaiLieuKho_DoubleClick(object sender, EventArgs e)
        {
            Point pt = grdTaiLieuKho.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = grdTaiLieuKho.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                int index = grdTaiLieuKho.GetSelectedRows()[0];
                chonTaiLieuMuon(index);
            }
        }

        private void chonTaiLieuMuon(int index)
        {
            //Kiểm tra số lượng mượn tối đa là 5 quyển
            int soLuongMuonToiDa = 5;
            if( taiLieuMuon.Count < soLuongMuonToiDa)
            {
                //Nếu vẫn còn mượn được
                TaiLieuDTO taiLieuChon = taiLieuKho[index];
                taiLieuMuon.Add(new TaiLieuDTO
                {
                    maTaiLieu = taiLieuChon.maTaiLieu,
                    tenTaiLieu = taiLieuChon.tenTaiLieu
                });
               
                grdTaiLieuMuon.RefreshData();
                grdTaiLieuKho.DeleteRow(index);

            }
            else
            {
                MessageBox.Show(String.Format("Độc giả chỉ được mượn tối đa {0} tài liệu.", soLuongMuonToiDa)
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void gCtrlTaiLieuMuon_DoubleClick(object sender, EventArgs e)
        {
            Point pt = grdTaiLieuMuon.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = grdTaiLieuMuon.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                int index = grdTaiLieuMuon.GetSelectedRows()[0];
                huyTaiLieuMuon(index);
            }
        }

        /// <summary>
        /// Hủy tài liệu đã chọn mượn
        /// </summary>
        /// <param name="index"></param>
        private void huyTaiLieuMuon(int index)
        {
            TaiLieuDTO taiLieuChon = taiLieuMuon[index];
            taiLieuKho.Add(new TaiLieuDTO
            {
                maTaiLieu = taiLieuChon.maTaiLieu,
                tenTaiLieu = taiLieuChon.tenTaiLieu
            });
            grdTaiLieuKho.RefreshData();
            grdTaiLieuMuon.DeleteRow(index);

        }

        private void btnLuuTheMuon_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn muốn tạo thẻ mượn cho độc giả?"
                , "Thông báo"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if(xacNhan == DialogResult.Yes)
            {
                new PhieuMuonBUS().taoPhieuMuon(maDocGiaMuon
                , Program.thuThu.maThuThu
                , dtbNgayMuon.DateTime
                , dtbNgayMuon.DateTime.AddDays(30)
                , taiLieuMuon);

                MessageBox.Show("Lưu thẻ mượn thành công."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            else
            {
                
            }
        }
    }
}
