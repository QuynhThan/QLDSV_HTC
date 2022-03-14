
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
            this.barButtonItemTaoLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLopTinChi = new DevExpress.XtraBars.BarButtonItem();
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
            this.barButtonItemTaoLogin,
            this.barButtonItemLop,
            this.barButtonItemSinhVien,
            this.barButtonItem1,
            this.barButtonItemMonHoc,
            this.barButtonItemDiem,
            this.barButtonItemHocPhi,
            this.barButtonItemLopTinChi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.ribbonControl1.MaxItemId = 14;
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
            // barButtonItemTaoLogin
            // 
            this.barButtonItemTaoLogin.Caption = "TẠO TÀI KHOẢN";
            this.barButtonItemTaoLogin.Id = 6;
            this.barButtonItemTaoLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemTaoLogin.ImageOptions.SvgImage")));
            this.barButtonItemTaoLogin.LargeWidth = 90;
            this.barButtonItemTaoLogin.Name = "barButtonItemTaoLogin";
            // 
            // barButtonItemLop
            // 
            this.barButtonItemLop.Caption = "LỚP";
            this.barButtonItemLop.Id = 7;
            this.barButtonItemLop.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.kisspng_google_classroom__2_;
            this.barButtonItemLop.LargeWidth = 75;
            this.barButtonItemLop.Name = "barButtonItemLop";
            this.barButtonItemLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItemSinhVien
            // 
            this.barButtonItemSinhVien.Caption = "SINH VIÊN";
            this.barButtonItemSinhVien.Id = 8;
            this.barButtonItemSinhVien.ImageOptions.DisabledImage = global::QLDSV_HTC.Properties.Resources.kisspng_google_classroom__2_;
            this.barButtonItemSinhVien.ImageOptions.SvgImage = global::QLDSV_HTC.Properties.Resources.allowuserstoeditranges;
            this.barButtonItemSinhVien.LargeWidth = 75;
            this.barButtonItemSinhVien.Name = "barButtonItemSinhVien";
            this.barButtonItemSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Báo Cáo 1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.SvgImage = global::QLDSV_HTC.Properties.Resources.printallpages;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItemMonHoc
            // 
            this.barButtonItemMonHoc.Caption = "MÔN HỌC";
            this.barButtonItemMonHoc.Id = 10;
            this.barButtonItemMonHoc.ImageOptions.SvgImage = global::QLDSV_HTC.Properties.Resources.text;
            this.barButtonItemMonHoc.LargeWidth = 75;
            this.barButtonItemMonHoc.Name = "barButtonItemMonHoc";
            // 
            // barButtonItemDiem
            // 
            this.barButtonItemDiem.Caption = "ĐIỂM";
            this.barButtonItemDiem.Id = 11;
            this.barButtonItemDiem.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.trackingchanges_trackchanges_16x16;
            this.barButtonItemDiem.ImageOptions.LargeImage = global::QLDSV_HTC.Properties.Resources.trackingchanges_trackchanges_32x32;
            this.barButtonItemDiem.LargeWidth = 75;
            this.barButtonItemDiem.Name = "barButtonItemDiem";
            // 
            // barButtonItemHocPhi
            // 
            this.barButtonItemHocPhi.Caption = "HỌC PHÍ";
            this.barButtonItemHocPhi.Id = 12;
            this.barButtonItemHocPhi.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.financial_16x16;
            this.barButtonItemHocPhi.ImageOptions.LargeImage = global::QLDSV_HTC.Properties.Resources.financial_32x32;
            this.barButtonItemHocPhi.LargeWidth = 75;
            this.barButtonItemHocPhi.Name = "barButtonItemHocPhi";
            // 
            // barButtonItemLopTinChi
            // 
            this.barButtonItemLopTinChi.Caption = "LỚP TÍN CHỈ";
            this.barButtonItemLopTinChi.Id = 13;
            this.barButtonItemLopTinChi.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.morefunctions_16x16;
            this.barButtonItemLopTinChi.ImageOptions.LargeImage = global::QLDSV_HTC.Properties.Resources.morefunctions_32x32;
            this.barButtonItemLopTinChi.LargeWidth = 75;
            this.barButtonItemLopTinChi.Name = "barButtonItemLopTinChi";
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
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barButtonItemLop);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barButtonItemSinhVien);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barButtonItemMonHoc);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barButtonItemDiem);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barButtonItemHocPhi);
            this.ribbonPageGroupQuanTri.ItemLinks.Add(this.barButtonItemLopTinChi);
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
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemTaoLogin);
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDangXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTaoLogin;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLop;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSinhVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMonHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDiem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemHocPhi;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLopTinChi;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblMaSV;
        public System.Windows.Forms.ToolStripStatusLabel lblHoTen;
        public System.Windows.Forms.ToolStripStatusLabel lblGroup;
    }
}

