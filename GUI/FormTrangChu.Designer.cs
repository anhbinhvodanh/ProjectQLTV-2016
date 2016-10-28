namespace GUI
{
    partial class FormTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnThemDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHuyDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMuonTaiLieu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTraTaiLieu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tabPaneTrangChu = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNTrangChu = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneTrangChu)).BeginInit();
            this.tabPaneTrangChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnThemDocGia,
            this.barBtnHuyDocGia,
            this.barBtnMuonTaiLieu,
            this.barBtnTraTaiLieu});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(786, 134);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barBtnThemDocGia
            // 
            this.barBtnThemDocGia.Caption = "Thêm thẻ độc giả";
            this.barBtnThemDocGia.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnThemDocGia.Glyph")));
            this.barBtnThemDocGia.Id = 1;
            this.barBtnThemDocGia.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnThemDocGia.LargeGlyph")));
            this.barBtnThemDocGia.Name = "barBtnThemDocGia";
            this.barBtnThemDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThemDocGia_ItemClick);
            // 
            // barBtnHuyDocGia
            // 
            this.barBtnHuyDocGia.Caption = "Hủy thẻ độc giả";
            this.barBtnHuyDocGia.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnHuyDocGia.Glyph")));
            this.barBtnHuyDocGia.Id = 2;
            this.barBtnHuyDocGia.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnHuyDocGia.LargeGlyph")));
            this.barBtnHuyDocGia.Name = "barBtnHuyDocGia";
            this.barBtnHuyDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHuyDocGia_ItemClick);
            // 
            // barBtnMuonTaiLieu
            // 
            this.barBtnMuonTaiLieu.Caption = "Mượn tài liệu";
            this.barBtnMuonTaiLieu.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnMuonTaiLieu.Glyph")));
            this.barBtnMuonTaiLieu.Id = 3;
            this.barBtnMuonTaiLieu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnMuonTaiLieu.LargeGlyph")));
            this.barBtnMuonTaiLieu.Name = "barBtnMuonTaiLieu";
            // 
            // barBtnTraTaiLieu
            // 
            this.barBtnTraTaiLieu.Caption = "Trả tài liệu";
            this.barBtnTraTaiLieu.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnTraTaiLieu.Glyph")));
            this.barBtnTraTaiLieu.Id = 4;
            this.barBtnTraTaiLieu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnTraTaiLieu.LargeGlyph")));
            this.barBtnTraTaiLieu.Name = "barBtnTraTaiLieu";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Độc giả";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnThemDocGia);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnHuyDocGia);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tác vụ";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Mượn và trả tài liệu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnMuonTaiLieu);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnTraTaiLieu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tác vụ";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 576);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(786, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // tabPaneTrangChu
            // 
            this.tabPaneTrangChu.Controls.Add(this.tabNTrangChu);
            this.tabPaneTrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneTrangChu.Location = new System.Drawing.Point(0, 134);
            this.tabPaneTrangChu.Name = "tabPaneTrangChu";
            this.tabPaneTrangChu.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNTrangChu});
            this.tabPaneTrangChu.RegularSize = new System.Drawing.Size(786, 442);
            this.tabPaneTrangChu.SelectedPage = this.tabNTrangChu;
            this.tabPaneTrangChu.Size = new System.Drawing.Size(786, 442);
            this.tabPaneTrangChu.TabIndex = 2;
            this.tabPaneTrangChu.Text = "tabPane1";
            // 
            // tabNTrangChu
            // 
            this.tabNTrangChu.Caption = "Trang chủ";
            this.tabNTrangChu.Name = "tabNTrangChu";
            this.tabNTrangChu.Size = new System.Drawing.Size(766, 397);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 599);
            this.Controls.Add(this.tabPaneTrangChu);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormTrangChu";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "PHẦN MỀM QUẢN LÝ THƯ VIỆN";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneTrangChu)).EndInit();
            this.tabPaneTrangChu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barBtnThemDocGia;
        private DevExpress.XtraBars.BarButtonItem barBtnHuyDocGia;
        private DevExpress.XtraBars.BarButtonItem barBtnMuonTaiLieu;
        private DevExpress.XtraBars.BarButtonItem barBtnTraTaiLieu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Navigation.TabPane tabPaneTrangChu;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNTrangChu;
    }
}

