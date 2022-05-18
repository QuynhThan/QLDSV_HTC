
namespace QLDSV_HTC.Forms
{
    partial class frmMonHoc
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
            System.Windows.Forms.Label lblMaMonHoc;
            System.Windows.Forms.Label lblTenMonHoc;
            System.Windows.Forms.Label lblSoTietLyThuyet;
            System.Windows.Forms.Label lblSoTietThucHanh;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLuu = new DevExpress.XtraBars.BarButtonItem();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.DS = new QLDSV_HTC.DS();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLDSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtSoTietLyThuyet = new System.Windows.Forms.TextBox();
            this.txtSoTietThucHanh = new System.Windows.Forms.TextBox();
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gvMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMonHoc = new System.Windows.Forms.Panel();
            this.bdsLOPTINCHI = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_HTC.DSTableAdapters.LOPTINCHITableAdapter();
            lblMaMonHoc = new System.Windows.Forms.Label();
            lblTenMonHoc = new System.Windows.Forms.Label();
            lblSoTietLyThuyet = new System.Windows.Forms.Label();
            lblSoTietThucHanh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            this.pnlMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOPTINCHI)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaMonHoc
            // 
            lblMaMonHoc.AutoSize = true;
            lblMaMonHoc.Location = new System.Drawing.Point(354, 42);
            lblMaMonHoc.Name = "lblMaMonHoc";
            lblMaMonHoc.Size = new System.Drawing.Size(69, 13);
            lblMaMonHoc.TabIndex = 64;
            lblMaMonHoc.Text = "Mã môn học:";
            // 
            // lblTenMonHoc
            // 
            lblTenMonHoc.AutoSize = true;
            lblTenMonHoc.Location = new System.Drawing.Point(354, 65);
            lblTenMonHoc.Name = "lblTenMonHoc";
            lblTenMonHoc.Size = new System.Drawing.Size(73, 13);
            lblTenMonHoc.TabIndex = 65;
            lblTenMonHoc.Text = "Tên môn học:";
            // 
            // lblSoTietLyThuyet
            // 
            lblSoTietLyThuyet.AutoSize = true;
            lblSoTietLyThuyet.Location = new System.Drawing.Point(354, 91);
            lblSoTietLyThuyet.Name = "lblSoTietLyThuyet";
            lblSoTietLyThuyet.Size = new System.Drawing.Size(82, 13);
            lblSoTietLyThuyet.TabIndex = 66;
            lblSoTietLyThuyet.Text = "Số tiết lý thuyết:";
            // 
            // lblSoTietThucHanh
            // 
            lblSoTietThucHanh.AutoSize = true;
            lblSoTietThucHanh.Location = new System.Drawing.Point(354, 117);
            lblSoTietThucHanh.Name = "lblSoTietThucHanh";
            lblSoTietThucHanh.Size = new System.Drawing.Size(91, 13);
            lblSoTietThucHanh.TabIndex = 67;
            lblSoTietThucHanh.Text = "Số tiết thực hành:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.barButtonItem4,
            this.btnPhucHoi,
            this.barButtonItem6,
            this.btnHuy,
            this.btnThoat,
            this.btnReload,
            this.barButtonLuu,
            this.btnSua});
            this.barManager1.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "THÊM";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "SỬA";
            this.btnSua.Id = 10;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "GHI";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "PHỤC HỒI";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "RELOAD";
            this.btnReload.Id = 8;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "HỦY";
            this.btnHuy.Id = 6;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1004, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 559);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1004, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 535);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1004, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 535);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "RELOAD";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonLuu
            // 
            this.barButtonLuu.Caption = "LƯU";
            this.barButtonLuu.Id = 9;
            this.barButtonLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonLuu.ImageOptions.Image")));
            this.barButtonLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonLuu.ImageOptions.LargeImage")));
            this.barButtonLuu.Name = "barButtonLuu";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DS;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMONHOC, "MAMH", true));
            this.txtMaMonHoc.Location = new System.Drawing.Point(451, 39);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(100, 20);
            this.txtMaMonHoc.TabIndex = 65;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMONHOC, "TENMH", true));
            this.txtTenMonHoc.Location = new System.Drawing.Point(451, 65);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(100, 20);
            this.txtTenMonHoc.TabIndex = 66;
            // 
            // txtSoTietLyThuyet
            // 
            this.txtSoTietLyThuyet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMONHOC, "SOTIET_LT", true));
            this.txtSoTietLyThuyet.Location = new System.Drawing.Point(451, 91);
            this.txtSoTietLyThuyet.Name = "txtSoTietLyThuyet";
            this.txtSoTietLyThuyet.Size = new System.Drawing.Size(100, 20);
            this.txtSoTietLyThuyet.TabIndex = 67;
            // 
            // txtSoTietThucHanh
            // 
            this.txtSoTietThucHanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMONHOC, "SOTIET_TH", true));
            this.txtSoTietThucHanh.Location = new System.Drawing.Point(451, 117);
            this.txtSoTietThucHanh.Name = "txtSoTietThucHanh";
            this.txtSoTietThucHanh.Size = new System.Drawing.Size(100, 20);
            this.txtSoTietThucHanh.TabIndex = 68;
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.bdsMONHOC;
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.Location = new System.Drawing.Point(0, 24);
            this.gcMonHoc.MainView = this.gvMonHoc;
            this.gcMonHoc.MenuManager = this.barManager1;
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(1004, 323);
            this.gcMonHoc.TabIndex = 72;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonHoc});
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH,
            this.colSOTIET_LT1});
            this.gvMonHoc.GridControl = this.gcMonHoc;
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.OptionsBehavior.Editable = false;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.Caption = "Số tiết lý thuyết";
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.Caption = "Số tiết thực hành";
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            // 
            // colSOTIET_LT1
            // 
            this.colSOTIET_LT1.FieldName = "SOTIET_LT";
            this.colSOTIET_LT1.Name = "colSOTIET_LT1";
            this.colSOTIET_LT1.Visible = true;
            this.colSOTIET_LT1.VisibleIndex = 4;
            // 
            // pnlMonHoc
            // 
            this.pnlMonHoc.Controls.Add(lblSoTietLyThuyet);
            this.pnlMonHoc.Controls.Add(this.txtMaMonHoc);
            this.pnlMonHoc.Controls.Add(lblSoTietThucHanh);
            this.pnlMonHoc.Controls.Add(lblMaMonHoc);
            this.pnlMonHoc.Controls.Add(this.txtSoTietThucHanh);
            this.pnlMonHoc.Controls.Add(this.txtTenMonHoc);
            this.pnlMonHoc.Controls.Add(lblTenMonHoc);
            this.pnlMonHoc.Controls.Add(this.txtSoTietLyThuyet);
            this.pnlMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMonHoc.Location = new System.Drawing.Point(0, 347);
            this.pnlMonHoc.Name = "pnlMonHoc";
            this.pnlMonHoc.Size = new System.Drawing.Size(1004, 212);
            this.pnlMonHoc.TabIndex = 77;
            // 
            // bdsLOPTINCHI
            // 
            this.bdsLOPTINCHI.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLOPTINCHI.DataSource = this.bdsMONHOC;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 559);
            this.Controls.Add(this.pnlMonHoc);
            this.Controls.Add(this.gcMonHoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonHoc";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            this.pnlMonHoc.ResumeLayout(false);
            this.pnlMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOPTINCHI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonLuu;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DS DS;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.TextBox txtSoTietThucHanh;
        private System.Windows.Forms.TextBox txtSoTietLyThuyet;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private System.Windows.Forms.Panel pnlMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private System.Windows.Forms.BindingSource bdsLOPTINCHI;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT1;
    }
}