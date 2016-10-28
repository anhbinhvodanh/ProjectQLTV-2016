﻿using GUI.UCtrl;
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
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            tabNTrangChu.Controls.Add(new UCtrlMuonTaiLieu());
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
            if(uCtrlTaoTheDocGia == null)
            {
                uCtrlTaoTheDocGia = new UCtrlTaoTheDocGia();
            }

            tabNTrangChu.Controls.Clear();
            tabNTrangChu.Controls.Add(uCtrlTaoTheDocGia);
        }

        private void barBtnHuyDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (uCtrlHuyTheDocGia == null)
            {
                uCtrlHuyTheDocGia = new UCtrlHuyTheDocGia();
            }

            tabNTrangChu.Controls.Clear();
            tabNTrangChu.Controls.Add(uCtrlHuyTheDocGia);
        }
    }
}
