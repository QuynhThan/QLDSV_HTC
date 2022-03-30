
namespace QLDSV_HTC
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaoLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLop = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDangKyLTC = new DevExpress.XtraBars.BarButtonItem();
            this.rbQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMaSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblGroup = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItemDangXuat,
            this.barBtnTaoLogin,
            this.barBtnLop,
            this.barBtnSinhVien,
            this.barButtonItem1,
            this.barBtnMonHoc,
            this.barBtnDiem,
            this.barBtnHocPhi,
            this.barBtnLopTinChi,
            this.barBtnDangKyLTC});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbQuanTri,
            this.rbBaoCao,
            this.rbChucNang});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 193);
            // 
            // barButtonItemDangXuat
            // 
            this.barButtonItemDangXuat.Caption = "ĐĂNG XUẤT";
            this.barButtonItemDangXuat.Id = 4;
            this.barButtonItemDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemDangXuat.ImageOptions.SvgImage")));
            this.barButtonItemDangXuat.LargeWidth = 90;
            this.barButtonItemDangXuat.Name = "barButtonItemDangXuat";
            this.barButtonItemDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDangXuat_ItemClick);
            // 
            // barBtnTaoLogin
            // 
            this.barBtnTaoLogin.Caption = "TẠO TÀI KHOẢN";
            this.barBtnTaoLogin.Id = 6;
            this.barBtnTaoLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnTaoLogin.ImageOptions.SvgImage")));
            this.barBtnTaoLogin.LargeWidth = 90;
            this.barBtnTaoLogin.Name = "barBtnTaoLogin";
            // 
            // barBtnLop
            // 
            this.barBtnLop.Caption = "LỚP";
            this.barBtnLop.Id = 7;
            this.barBtnLop.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.kisspng_google_classroom__2_;
            this.barBtnLop.LargeWidth = 75;
            this.barBtnLop.Name = "barBtnLop";
            this.barBtnLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLop_ItemClick);
            // 
            // barBtnSinhVien
            // 
            this.barBtnSinhVien.Caption = "SINH VIÊN";
            this.barBtnSinhVien.Id = 8;
            this.barBtnSinhVien.ImageOptions.DisabledImage = global::QLDSV_HTC.Properties.Resources.kisspng_google_classroom__2_;
            this.barBtnSinhVien.ImageOptions.SvgImage = global::QLDSV_HTC.Properties.Resources.allowuserstoeditranges;
            this.barBtnSinhVien.LargeWidth = 75;
            this.barBtnSinhVien.Name = "barBtnSinhVien";
            this.barBtnSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSinhVien_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Báo Cáo 1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.SvgImage = global::QLDSV_HTC.Properties.Resources.printallpages;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barBtnMonHoc
            // 
            this.barBtnMonHoc.Caption = "MÔN HỌC";
            this.barBtnMonHoc.Id = 10;
            this.barBtnMonHoc.ImageOptions.SvgImage = global::QLDSV_HTC.Properties.Resources.text;
            this.barBtnMonHoc.LargeWidth = 75;
            this.barBtnMonHoc.Name = "barBtnMonHoc";
            // 
            // barBtnDiem
            // 
            this.barBtnDiem.Caption = "ĐIỂM";
            this.barBtnDiem.Id = 11;
            this.barBtnDiem.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.trackingchanges_trackchanges_16x16;
            this.barBtnDiem.ImageOptions.LargeImage = global::QLDSV_HTC.Properties.Resources.trackingchanges_trackchanges_32x32;
            this.barBtnDiem.LargeWidth = 75;
            this.barBtnDiem.Name = "barBtnDiem";
            // 
            // barBtnHocPhi
            // 
            this.barBtnHocPhi.Caption = "HỌC PHÍ";
            this.barBtnHocPhi.Id = 12;
            this.barBtnHocPhi.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.financial_16x16;
            this.barBtnHocPhi.ImageOptions.LargeImage = global::QLDSV_HTC.Properties.Resources.financial_32x32;
            this.barBtnHocPhi.LargeWidth = 75;
            this.barBtnHocPhi.Name = "barBtnHocPhi";
            // 
            // barBtnLopTinChi
            // 
            this.barBtnLopTinChi.Caption = "LỚP TÍN CHỈ";
            this.barBtnLopTinChi.Id = 13;
            this.barBtnLopTinChi.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.morefunctions_16x16;
            this.barBtnLopTinChi.ImageOptions.LargeImage = global::QLDSV_HTC.Properties.Resources.morefunctions_32x32;
            this.barBtnLopTinChi.LargeWidth = 75;
            this.barBtnLopTinChi.Name = "barBtnLopTinChi";
            // 
            // barBtnDangKyLTC
            // 
            this.barBtnDangKyLTC.Caption = "ĐĂNG KÝ LỚP TÍN CHỈ";
            this.barBtnDangKyLTC.Id = 14;
            this.barBtnDangKyLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangKyLTC.ImageOptions.Image")));
            this.barBtnDangKyLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDangKyLTC.ImageOptions.LargeImage")));
            this.barBtnDangKyLTC.Name = "barBtnDangKyLTC";
            this.barBtnDangKyLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDangKyLTC_ItemClick);
            // 
            // rbQuanTri
            // 
            this.rbQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupQuanTri});
            this.rbQuanTri.Name = "rbQuanTri";
            this.rbQuanTri.Text = "QUẢN TRỊ";
            // 
            // ribbonPageGroupQuanTri
            // 
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barBtnLop);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barBtnSinhVien);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barBtnMonHoc);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barBtnDiem);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barBtnHocPhi);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barBtnLopTinChi);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barBtnDangKyLTC);
            this.ribbonPageGroupQuanTri.Name = "ribbonPageGroupQuanTri";
            this.ribbonPageGroupQuanTri.Text = "QUẢN LÍ DỮ LIỆU";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // rbChucNang
            // 
            this.rbChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbChucNang.Name = "rbChucNang";
            this.rbChucNang.Text = "CHỨC NĂNG";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemDangXuat);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnTaoLogin);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "CHỨC NĂNG";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMaSV,
            this.lblHoTen,
            this.lblGroup});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMaSV
            // 
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(47, 20);
            this.lblMaSV.Text = "MaSV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(62, 20);
            this.lblHoTen.Text = "HO TEN";
            // 
            // lblGroup
            // 
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(50, 20);
            this.lblGroup.Text = "Group";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::QLDSV_HTC.Properties.Resources.main_icon;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUAN LI DIEM SINH VIEN HTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDangXuat;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblMaSV;
        public System.Windows.Forms.ToolStripStatusLabel lblHoTen;
        public System.Windows.Forms.ToolStripStatusLabel lblGroup;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        public DevExpress.XtraBars.BarButtonItem barBtnLop;
        public DevExpress.XtraBars.BarButtonItem barBtnMonHoc;
        public DevExpress.XtraBars.BarButtonItem barBtnDiem;
        public DevExpress.XtraBars.BarButtonItem barBtnHocPhi;
        public DevExpress.XtraBars.BarButtonItem barBtnLopTinChi;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        public DevExpress.XtraBars.BarButtonItem barBtnTaoLogin;
        public DevExpress.XtraBars.BarButtonItem barBtnSinhVien;
        public DevExpress.XtraBars.BarButtonItem barBtnDangKyLTC;
    }
}

