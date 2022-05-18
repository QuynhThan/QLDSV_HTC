
namespace QLDSV_HTC.Forms
{
    partial class frmLopTinChi
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
            System.Windows.Forms.Label hUYLOPLabel;
            System.Windows.Forms.Label lblSoSVToiThieu;
            System.Windows.Forms.Label lblNhom;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label mAMHLabel1;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopTinChi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            this.DS = new QLDSV_HTC.DS();
            this.bdsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_HTC.DSTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_HTC.DSTableAdapters.DANGKYTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KHOA = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.pnlLopTinChi = new DevExpress.XtraEditors.PanelControl();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.checkHuyLop = new DevExpress.XtraEditors.CheckEdit();
            this.txtSoSVToiThieu = new System.Windows.Forms.TextBox();
            this.txtNhom = new System.Windows.Forms.TextBox();
            this.gcLopTinChi = new DevExpress.XtraGrid.GridControl();
            this.gvLopTinChi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            hUYLOPLabel = new System.Windows.Forms.Label();
            lblSoSVToiThieu = new System.Windows.Forms.Label();
            lblNhom = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            mAMHLabel1 = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLopTinChi)).BeginInit();
            this.pnlLopTinChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkHuyLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(504, 74);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(50, 13);
            hUYLOPLabel.TabIndex = 18;
            hUYLOPLabel.Text = "HUYLOP:";
            // 
            // lblSoSVToiThieu
            // 
            lblSoSVToiThieu.AutoSize = true;
            lblSoSVToiThieu.Location = new System.Drawing.Point(422, 45);
            lblSoSVToiThieu.Name = "lblSoSVToiThieu";
            lblSoSVToiThieu.Size = new System.Drawing.Size(132, 13);
            lblSoSVToiThieu.TabIndex = 14;
            lblSoSVToiThieu.Text = "SỐ SINH VIÊN TỐI THIỂU:";
            // 
            // lblNhom
            // 
            lblNhom.AutoSize = true;
            lblNhom.Location = new System.Drawing.Point(156, 126);
            lblNhom.Name = "lblNhom";
            lblNhom.Size = new System.Drawing.Size(41, 13);
            lblNhom.TabIndex = 8;
            lblNhom.Text = "NHÓM:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(134, 42);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(63, 13);
            nIENKHOALabel.TabIndex = 25;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(152, 69);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(45, 13);
            hOCKYLabel.TabIndex = 26;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(143, 180);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(54, 13);
            mAKHOALabel.TabIndex = 27;
            mAKHOALabel.Text = "MAKHOA:";
            // 
            // mAMHLabel1
            // 
            mAMHLabel1.AutoSize = true;
            mAMHLabel1.Location = new System.Drawing.Point(156, 99);
            mAMHLabel1.Name = "mAMHLabel1";
            mAMHLabel1.Size = new System.Drawing.Size(41, 13);
            mAMHLabel1.TabIndex = 28;
            mAMHLabel1.Text = "MAMH:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(158, 153);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(39, 13);
            mAGVLabel.TabIndex = 29;
            mAGVLabel.Text = "MAGV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnReload,
            this.btnHuy,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "THÊM";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "SỬA";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "GHI";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "PHỤC HỒI";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "RELOAD";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "HỦY";
            this.btnHuy.Id = 6;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1286, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1286, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 598);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1286, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 598);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLopTinChi
            // 
            this.bdsLopTinChi.DataMember = "LOPTINCHI";
            this.bdsLopTinChi.DataSource = this.DS;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDangKy.DataSource = this.bdsLopTinChi;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.KHOA);
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 45);
            this.panel1.TabIndex = 15;
            // 
            // KHOA
            // 
            this.KHOA.AutoSize = true;
            this.KHOA.Location = new System.Drawing.Point(53, 11);
            this.KHOA.Name = "KHOA";
            this.KHOA.Size = new System.Drawing.Size(37, 13);
            this.KHOA.TabIndex = 1;
            this.KHOA.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(112, 8);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(272, 21);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // pnlLopTinChi
            // 
            this.pnlLopTinChi.AllowTouchScroll = true;
            this.pnlLopTinChi.AutoSize = true;
            this.pnlLopTinChi.Controls.Add(this.cmbMaGV);
            this.pnlLopTinChi.Controls.Add(this.cmbMaMH);
            this.pnlLopTinChi.Controls.Add(mAGVLabel);
            this.pnlLopTinChi.Controls.Add(this.txtMaGV);
            this.pnlLopTinChi.Controls.Add(mAMHLabel1);
            this.pnlLopTinChi.Controls.Add(this.txtMaMH);
            this.pnlLopTinChi.Controls.Add(mAKHOALabel);
            this.pnlLopTinChi.Controls.Add(this.txtMaKhoa);
            this.pnlLopTinChi.Controls.Add(hOCKYLabel);
            this.pnlLopTinChi.Controls.Add(this.cmbHocKy);
            this.pnlLopTinChi.Controls.Add(nIENKHOALabel);
            this.pnlLopTinChi.Controls.Add(this.cmbNienKhoa);
            this.pnlLopTinChi.Controls.Add(hUYLOPLabel);
            this.pnlLopTinChi.Controls.Add(this.checkHuyLop);
            this.pnlLopTinChi.Controls.Add(lblSoSVToiThieu);
            this.pnlLopTinChi.Controls.Add(this.txtSoSVToiThieu);
            this.pnlLopTinChi.Controls.Add(lblNhom);
            this.pnlLopTinChi.Controls.Add(this.txtNhom);
            this.pnlLopTinChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLopTinChi.InvertTouchScroll = true;
            this.pnlLopTinChi.Location = new System.Drawing.Point(0, 411);
            this.pnlLopTinChi.Name = "pnlLopTinChi";
            this.pnlLopTinChi.Size = new System.Drawing.Size(1286, 211);
            this.pnlLopTinChi.TabIndex = 17;
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(263, 150);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(121, 21);
            this.cmbMaGV.TabIndex = 32;
            this.cmbMaGV.SelectedIndexChanged += new System.EventHandler(this.cmbMaGV_SelectedIndexChanged);
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(263, 96);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(121, 21);
            this.cmbMaMH.TabIndex = 31;
            this.cmbMaMH.SelectedIndexChanged += new System.EventHandler(this.cmbMaMH_SelectedIndexChanged);
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "MAGV", true));
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(203, 150);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(45, 21);
            this.txtMaGV.TabIndex = 30;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "MAMH", true));
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(203, 96);
            this.txtMaMH.Multiline = true;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(45, 21);
            this.txtMaMH.TabIndex = 29;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "MAKHOA", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(203, 177);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(181, 21);
            this.txtMaKhoa.TabIndex = 28;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "HOCKY", true));
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(203, 66);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(181, 21);
            this.cmbHocKy.TabIndex = 27;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "NIENKHOA", true));
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(203, 39);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(181, 21);
            this.cmbNienKhoa.TabIndex = 26;
            // 
            // checkHuyLop
            // 
            this.checkHuyLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "HUYLOP", true));
            this.checkHuyLop.Location = new System.Drawing.Point(560, 72);
            this.checkHuyLop.MenuManager = this.barManager1;
            this.checkHuyLop.Name = "checkHuyLop";
            this.checkHuyLop.Properties.Caption = "";
            this.checkHuyLop.Size = new System.Drawing.Size(100, 20);
            this.checkHuyLop.TabIndex = 19;
            // 
            // txtSoSVToiThieu
            // 
            this.txtSoSVToiThieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "SOSVTOITHIEU", true));
            this.txtSoSVToiThieu.Location = new System.Drawing.Point(560, 45);
            this.txtSoSVToiThieu.Name = "txtSoSVToiThieu";
            this.txtSoSVToiThieu.Size = new System.Drawing.Size(100, 21);
            this.txtSoSVToiThieu.TabIndex = 15;
            // 
            // txtNhom
            // 
            this.txtNhom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "NHOM", true));
            this.txtNhom.Location = new System.Drawing.Point(203, 123);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(181, 21);
            this.txtNhom.TabIndex = 9;
            // 
            // gcLopTinChi
            // 
            this.gcLopTinChi.DataSource = this.bdsLopTinChi;
            this.gcLopTinChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLopTinChi.Location = new System.Drawing.Point(0, 69);
            this.gcLopTinChi.MainView = this.gvLopTinChi;
            this.gcLopTinChi.MenuManager = this.barManager1;
            this.gcLopTinChi.Name = "gcLopTinChi";
            this.gcLopTinChi.Size = new System.Drawing.Size(1286, 342);
            this.gcLopTinChi.TabIndex = 16;
            this.gcLopTinChi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLopTinChi});
            // 
            // gvLopTinChi
            // 
            this.gvLopTinChi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gvLopTinChi.GridControl = this.gcLopTinChi;
            this.gvLopTinChi.Name = "gvLopTinChi";
            this.gvLopTinChi.OptionsBehavior.Editable = false;
            this.gvLopTinChi.OptionsBehavior.ReadOnly = true;
            this.gvLopTinChi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvLopTinChi_FocusedRowChanged);
            // 
            // colMALTC
            // 
            this.colMALTC.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALTC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.Caption = "MÃ LỚP TÍN CHỈ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceCell.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.Caption = "NIÊN KHÓA";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCKY.Caption = "HỌC KỲ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.Options.UseTextOptions = true;
            this.colMAMH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.Caption = "MÃ MÔN HỌC";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            // 
            // colNHOM
            // 
            this.colNHOM.AppearanceHeader.Options.UseTextOptions = true;
            this.colNHOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.Caption = "NHÓM";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            // 
            // colMAGV
            // 
            this.colMAGV.AppearanceCell.Options.UseTextOptions = true;
            this.colMAGV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAGV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAGV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAGV.Caption = "MÃ GIẢNG VIÊN";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceCell.Options.UseTextOptions = true;
            this.colMAKHOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHOA.Caption = "MÃ KHOA";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOSVTOITHIEU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVTOITHIEU.Caption = "SỐ SINH VIÊN TỐI THIỂU";
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.AppearanceCell.Options.UseTextOptions = true;
            this.colHUYLOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHUYLOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colHUYLOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHUYLOP.Caption = "HỦY LỚP";
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Location = new System.Drawing.Point(1345, 535);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(75, 23);
            this.xtraScrollableControl1.TabIndex = 23;
            // 
            // frmLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 622);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.pnlLopTinChi);
            this.Controls.Add(this.gcLopTinChi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLopTinChi";
            this.Text = "frmLopTinChi";
            this.Load += new System.EventHandler(this.frmLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLopTinChi)).EndInit();
            this.pnlLopTinChi.ResumeLayout(false);
            this.pnlLopTinChi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkHuyLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsLopTinChi;
        private DS DS;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DevExpress.XtraEditors.PanelControl pnlLopTinChi;
        private DevExpress.XtraEditors.CheckEdit checkHuyLop;
        private System.Windows.Forms.TextBox txtSoSVToiThieu;
        private System.Windows.Forms.TextBox txtNhom;
        private DevExpress.XtraGrid.GridControl gcLopTinChi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLopTinChi;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KHOA;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtMaMH;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}