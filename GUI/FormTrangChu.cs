using GUI.UCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private UCtrlTaoTheDocGia uCtrlTaoTheDocGia;
        private UCtrlHuyTheDocGia uCtrlHuyTheDocGia;

        private UCtrlMuonTaiLieu uCtrlMuonTaiLieu;
        private UCtrlTraTaiLieu uCtrlTraTaiLieu;
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
           
        }

        private void barBtnThemDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showUCtrlTaoTheDocGia();
        }

        /// <summary>
        /// Hiển thị Form tạo thẻ độc giả mới
        /// </summary>
        private void showUCtrlTaoTheDocGia()
        {
            
                uCtrlTaoTheDocGia = new UCtrlTaoTheDocGia();
                uCtrlTaoTheDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
           

            tabNTrangChu.Controls.Clear();
            tabNTrangChu.Controls.Add(uCtrlTaoTheDocGia);
        }

        private void barBtnHuyDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                uCtrlHuyTheDocGia = new UCtrlHuyTheDocGia();
                uCtrlHuyTheDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
           

            tabNTrangChu.Controls.Clear();
            tabNTrangChu.Controls.Add(uCtrlHuyTheDocGia);
        }

        private void barBtnMuonTaiLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                uCtrlMuonTaiLieu = new UCtrlMuonTaiLieu();
                uCtrlMuonTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
           
            tabNTrangChu.Controls.Clear();
            tabNTrangChu.Controls.Add(uCtrlMuonTaiLieu);
        }

        private void barBtnTraTaiLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                uCtrlTraTaiLieu = new UCtrlTraTaiLieu();
                uCtrlTraTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            
            tabNTrangChu.Controls.Clear();
            tabNTrangChu.Controls.Add(uCtrlTraTaiLieu);
        }
    }
}
