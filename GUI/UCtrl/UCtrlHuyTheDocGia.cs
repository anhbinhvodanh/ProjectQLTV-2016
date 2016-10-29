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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GUI
{
    public partial class UCtrlHuyTheDocGia : DevExpress.XtraEditors.XtraUserControl
    {
        public UCtrlHuyTheDocGia()
        {
            InitializeComponent();
        }

        private void UCtrlHuyTheDocGia_Load(object sender, EventArgs e)
        {
            loadThongTin();
        }

        /// <summary>
        /// Load thông tin các thẻ độc giả
        /// </summary>
        private void loadThongTin()
        {
            gCtrlDocGia.DataSource = new DocGiaBUS().getAllDocGia();
            gCtrlDocGiaBiHuyThe.DataSource = new DocGiaBUS().getAllDocGiaBiHuyThe();
        }
        private void grdViewDocGia_DoubleClick(object sender, EventArgs e)
        {
            Point pt = grdViewDocGia.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = grdViewDocGia.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                int index = grdViewDocGia.GetSelectedRows()[0];
                xacNhanHuyDocGia(index);
            }
        }

        /// <summary>
        /// Xác nhận hủy thẻ độc giả
        /// </summary>
        /// <param name="index"></param>
        private void xacNhanHuyDocGia(int index)
        {
            DialogResult xacNhapTaoMoi = MessageBox.Show(String.Format("Bạn có muốn xóa thẻ độc giả của {0} ?", grdViewDocGia.GetRowCellValue(index, "tenDocGia"))
                , "Thông báo"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);

            if (xacNhapTaoMoi == DialogResult.Yes)
            {
                //Xác nhận xóa
                var maDocGiaText = grdViewDocGia.GetRowCellValue(index, "maDocGia");
                new DocGiaBUS().huyTheDocGia(Int32.Parse(maDocGiaText.ToString()));
                //Reload lại thông tin
                loadThongTin();
            }
            else
            {

            }
        }
        private void grdViewDocGiaBiHuyThe_DoubleClick(object sender, EventArgs e)
        {
            Point pt = grdViewDocGiaBiHuyThe.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = grdViewDocGiaBiHuyThe.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                int index = grdViewDocGiaBiHuyThe.GetSelectedRows()[0];
                xacNhanMoLaiTheDocGia(index);
            }
        }

        /// <summary>
        /// Xác nhận cho phép mở lại thẻ độc giả
        /// </summary>
        /// <param name="index"></param>
        private void xacNhanMoLaiTheDocGia(int index)
        {
            DialogResult xacNhan = MessageBox.Show(String.Format("Bạn có muốn mở lại thẻ độc giả của {0} ?", grdViewDocGiaBiHuyThe.GetRowCellValue(index, "tenDocGia"))
                , "Thông báo"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);

            if (xacNhan == DialogResult.Yes)
            {
                //Xác nhận xóa
                var maDocGiaText = grdViewDocGiaBiHuyThe.GetRowCellValue(index, "maDocGia");
                new DocGiaBUS().moLaiTheDocGia(Int32.Parse(maDocGiaText.ToString()));
                //Reload lại thông tin
                loadThongTin();
            }
            else
            {

            }
        }
        private void btnMoKhoaHet_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show(String.Format("Bạn có muốn mở khóa toàn bộ {0} thẻ độc giả ?", grdViewDocGiaBiHuyThe.RowCount)
               , "Thông báo"
               , MessageBoxButtons.YesNo
               , MessageBoxIcon.Warning);

            if (xacNhan == DialogResult.Yes)
            {
                //Xác nhận mở khóa toàn bộ
                moKhoaToanBoThe();
            }
            else
            {

            }
     
        }


        /// <summary>
        /// Mở khóa toàn bộ thẻ độc giả
        /// </summary>
        private void moKhoaToanBoThe()
        {
            int countRow = grdViewDocGiaBiHuyThe.RowCount;
            for (int i = 0; i < countRow; i++)
            {
                var maDocGiaText = grdViewDocGiaBiHuyThe.GetRowCellValue(i, "maDocGia");
                new DocGiaBUS().moLaiTheDocGia(Int32.Parse(maDocGiaText.ToString()));
            }
            if (countRow > 0)
            {
                loadThongTin();
            }
        }

        private void btnMoKhoaHet_Click_1(object sender, EventArgs e)
        {

        }
    }
}
