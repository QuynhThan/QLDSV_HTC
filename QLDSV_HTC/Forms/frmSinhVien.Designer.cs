
namespace QLDSV_HTC.Forms
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.Windows.Forms.Label nGAYSINHLabel1;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label dANGHIHOCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.DS = new QLDSV_HTC.DS();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV_HTC.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.barLop = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManagerLop = new DevExpress.XtraBars.BarManager(this.components);
            this.barSinhVien = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelLop = new System.Windows.Forms.Panel();
            this.cmbKhoaSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSinhVien = new System.Windows.Forms.GroupBox();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gvDSLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapSinhVien = new System.Windows.Forms.Panel();
            this.panelInfoLop = new System.Windows.Forms.Panel();
            this.txtMalop = new DevExpress.XtraEditors.TextEdit();
            this.tENLOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelDaNghiHoc = new System.Windows.Forms.Panel();
            this.chkDaNghiHoc = new DevExpress.XtraEditors.CheckEdit();
            this.btnXong = new System.Windows.Forms.Button();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.chkPhai = new DevExpress.XtraEditors.CheckEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.lOPTableAdapter = new QLDSV_HTC.DSTableAdapters.LOPTableAdapter();
            this.gvSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_HTC.DSTableAdapters.DANGKYTableAdapter();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel1 = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            dANGHIHOCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).BeginInit();
            this.panelLop.SuspendLayout();
            this.gbSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLop)).BeginInit();
            this.panelNhapSinhVien.SuspendLayout();
            this.panelInfoLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).BeginInit();
            this.panelDaNghiHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkDaNghiHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(24, 69);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(98, 17);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MÃ SINH VIÊN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(25, 109);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(113, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HỌ VÀ TÊN ĐỆM:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(25, 149);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(38, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TÊN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(474, 108);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(42, 17);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "PHÁI:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(24, 226);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(88, 17);
            pASSWORDLabel.TabIndex = 10;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // nGAYSINHLabel1
            // 
            nGAYSINHLabel1.AutoSize = true;
            nGAYSINHLabel1.Location = new System.Drawing.Point(474, 70);
            nGAYSINHLabel1.Name = "nGAYSINHLabel1";
            nGAYSINHLabel1.Size = new System.Drawing.Size(81, 17);
            nGAYSINHLabel1.TabIndex = 12;
            nGAYSINHLabel1.Text = "NGÀY SINH:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(23, 22);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(64, 17);
            mALOPLabel.TabIndex = 13;
            mALOPLabel.Text = "MÃ LỚP: ";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(290, 21);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(67, 17);
            tENLOPLabel.TabIndex = 14;
            tENLOPLabel.Text = "TÊN LỚP:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(25, 186);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(65, 17);
            dIACHILabel.TabIndex = 16;
            dIACHILabel.Text = "ĐỊA CHỈ: ";
            // 
            // dANGHIHOCLabel
            // 
            dANGHIHOCLabel.AutoSize = true;
            dANGHIHOCLabel.Location = new System.Drawing.Point(3, 19);
            dANGHIHOCLabel.Name = "dANGHIHOCLabel";
            dANGHIHOCLabel.Size = new System.Drawing.Size(98, 17);
            dANGHIHOCLabel.TabIndex = 19;
            dANGHIHOCLabel.Text = "ĐÃ NGHỈ HỌC:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_LOP_SINHVIEN";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barLop
            // 
            this.barLop.BarName = "Main menu";
            this.barLop.DockCol = 0;
            this.barLop.DockRow = 0;
            this.barLop.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barLop.OptionsBar.MultiLine = true;
            this.barLop.OptionsBar.UseWholeRow = true;
            this.barLop.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManagerLop
            // 
            this.barManagerLop.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barSinhVien});
            this.barManagerLop.DockControls.Add(this.barDockControlTop);
            this.barManagerLop.DockControls.Add(this.barDockControlBottom);
            this.barManagerLop.DockControls.Add(this.barDockControlLeft);
            this.barManagerLop.DockControls.Add(this.barDockControlRight);
            this.barManagerLop.Form = this;
            this.barManagerLop.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barBtnThem,
            this.barBtnXoa,
            this.barBtnPhucHoi,
            this.barBtnThoat,
            this.barBtnReload,
            this.barBtnHuy,
            this.barBtnGhi,
            this.barBtnSua});
            this.barManagerLop.MainMenu = this.barSinhVien;
            this.barManagerLop.MaxItemId = 11;
            // 
            // barSinhVien
            // 
            this.barSinhVien.BarName = "Main menu";
            this.barSinhVien.DockCol = 0;
            this.barSinhVien.DockRow = 0;
            this.barSinhVien.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barSinhVien.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThoat)});
            this.barSinhVien.OptionsBar.MultiLine = true;
            this.barSinhVien.OptionsBar.UseWholeRow = true;
            this.barSinhVien.Text = "Main menu";
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "THÊM";
            this.barBtnThem.Id = 1;
            this.barBtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnThem.ImageOptions.Image")));
            this.barBtnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnThem.ImageOptions.LargeImage")));
            this.barBtnThem.Name = "barBtnThem";
            this.barBtnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThem_ItemClick);
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "XÓA";
            this.barBtnXoa.Id = 2;
            this.barBtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnXoa.ImageOptions.Image")));
            this.barBtnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnXoa.ImageOptions.LargeImage")));
            this.barBtnXoa.Name = "barBtnXoa";
            this.barBtnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoa_ItemClick);
            // 
            // barBtnSua
            // 
            this.barBtnSua.Caption = "SỬA";
            this.barBtnSua.Id = 10;
            this.barBtnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSua.ImageOptions.Image")));
            this.barBtnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSua.ImageOptions.LargeImage")));
            this.barBtnSua.Name = "barBtnSua";
            this.barBtnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSua_ItemClick);
            // 
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "GHI";
            this.barBtnGhi.Enabled = false;
            this.barBtnGhi.Id = 8;
            this.barBtnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.Image")));
            this.barBtnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.LargeImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick);
            // 
            // barBtnPhucHoi
            // 
            this.barBtnPhucHoi.Caption = "PHỤC HỒI";
            this.barBtnPhucHoi.Enabled = false;
            this.barBtnPhucHoi.Id = 4;
            this.barBtnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPhucHoi.ImageOptions.Image")));
            this.barBtnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPhucHoi.ImageOptions.LargeImage")));
            this.barBtnPhucHoi.Name = "barBtnPhucHoi";
            this.barBtnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPhucHoi_ItemClick);
            // 
            // barBtnReload
            // 
            this.barBtnReload.Caption = "RELOAD";
            this.barBtnReload.Id = 6;
            this.barBtnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnReload.ImageOptions.SvgImage")));
            this.barBtnReload.Name = "barBtnReload";
            this.barBtnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReload_ItemClick);
            // 
            // barBtnHuy
            // 
            this.barBtnHuy.Caption = "HỦY";
            this.barBtnHuy.Enabled = false;
            this.barBtnHuy.Id = 7;
            this.barBtnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnHuy.ImageOptions.SvgImage")));
            this.barBtnHuy.Name = "barBtnHuy";
            this.barBtnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHuy_ItemClick);
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "THOÁT";
            this.barBtnThoat.Id = 5;
            this.barBtnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.ImageOptions.Image")));
            this.barBtnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnThoat.ImageOptions.LargeImage")));
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerLop;
            this.barDockControlTop.Size = new System.Drawing.Size(1192, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1062);
            this.barDockControlBottom.Manager = this.barManagerLop;
            this.barDockControlBottom.Size = new System.Drawing.Size(1192, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManagerLop;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1032);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1192, 30);
            this.barDockControlRight.Manager = this.barManagerLop;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1032);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelLop
            // 
            this.panelLop.Controls.Add(this.cmbKhoaSV);
            this.panelLop.Controls.Add(this.label1);
            this.panelLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLop.Location = new System.Drawing.Point(0, 30);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(1192, 57);
            this.panelLop.TabIndex = 7;
            // 
            // cmbKhoaSV
            // 
            this.cmbKhoaSV.FormattingEnabled = true;
            this.cmbKhoaSV.Location = new System.Drawing.Point(373, 12);
            this.cmbKhoaSV.Name = "cmbKhoaSV";
            this.cmbKhoaSV.Size = new System.Drawing.Size(410, 33);
            this.cmbKhoaSV.TabIndex = 1;
            this.cmbKhoaSV.SelectedIndexChanged += new System.EventHandler(this.cmbKhoaSV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // gbSinhVien
            // 
            this.gbSinhVien.Controls.Add(this.gcLop);
            this.gbSinhVien.Controls.Add(this.panelNhapSinhVien);
            this.gbSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSinhVien.Location = new System.Drawing.Point(0, 675);
            this.gbSinhVien.Name = "gbSinhVien";
            this.gbSinhVien.Size = new System.Drawing.Size(1192, 387);
            this.gbSinhVien.TabIndex = 9;
            this.gbSinhVien.TabStop = false;
            this.gbSinhVien.Text = "Nhập Thông Tin Sinh Viên";
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLop.Location = new System.Drawing.Point(758, 19);
            this.gcLop.MainView = this.gvDSLop;
            this.gcLop.MenuManager = this.barManagerLop;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(431, 365);
            this.gcLop.TabIndex = 1;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSLop});
            // 
            // gvDSLop
            // 
            this.gvDSLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP1,
            this.colTENLOP,
            this.colKHOAHOC});
            this.gvDSLop.GridControl = this.gcLop;
            this.gvDSLop.Name = "gvDSLop";
            this.gvDSLop.OptionsBehavior.ReadOnly = true;
            this.gvDSLop.OptionsView.ShowViewCaption = true;
            this.gvDSLop.ViewCaption = "DANH SÁCH LỚP";
            this.gvDSLop.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDSLop_FocusedRowChanged);
            // 
            // colMALOP1
            // 
            this.colMALOP1.Caption = "Mã Lớp";
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 25;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 0;
            this.colMALOP1.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên Lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.Caption = "Khóa Học";
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 25;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 94;
            // 
            // panelNhapSinhVien
            // 
            this.panelNhapSinhVien.AutoScroll = true;
            this.panelNhapSinhVien.Controls.Add(this.panelInfoLop);
            this.panelNhapSinhVien.Controls.Add(this.panelDaNghiHoc);
            this.panelNhapSinhVien.Controls.Add(this.btnXong);
            this.panelNhapSinhVien.Controls.Add(dIACHILabel);
            this.panelNhapSinhVien.Controls.Add(this.txtDiaChi);
            this.panelNhapSinhVien.Controls.Add(nGAYSINHLabel1);
            this.panelNhapSinhVien.Controls.Add(this.dateNgaySinh);
            this.panelNhapSinhVien.Controls.Add(pASSWORDLabel);
            this.panelNhapSinhVien.Controls.Add(this.txtPassword);
            this.panelNhapSinhVien.Controls.Add(pHAILabel);
            this.panelNhapSinhVien.Controls.Add(this.chkPhai);
            this.panelNhapSinhVien.Controls.Add(tENLabel);
            this.panelNhapSinhVien.Controls.Add(this.txtTen);
            this.panelNhapSinhVien.Controls.Add(hOLabel);
            this.panelNhapSinhVien.Controls.Add(this.txtHo);
            this.panelNhapSinhVien.Controls.Add(mASVLabel);
            this.panelNhapSinhVien.Controls.Add(this.txtMaSV);
            this.panelNhapSinhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapSinhVien.Enabled = false;
            this.panelNhapSinhVien.Location = new System.Drawing.Point(3, 19);
            this.panelNhapSinhVien.Name = "panelNhapSinhVien";
            this.panelNhapSinhVien.Size = new System.Drawing.Size(755, 365);
            this.panelNhapSinhVien.TabIndex = 0;
            // 
            // panelInfoLop
            // 
            this.panelInfoLop.Controls.Add(this.txtMalop);
            this.panelInfoLop.Controls.Add(mALOPLabel);
            this.panelInfoLop.Controls.Add(this.tENLOPTextEdit);
            this.panelInfoLop.Controls.Add(tENLOPLabel);
            this.panelInfoLop.Enabled = false;
            this.panelInfoLop.Location = new System.Drawing.Point(57, 3);
            this.panelInfoLop.Name = "panelInfoLop";
            this.panelInfoLop.Size = new System.Drawing.Size(656, 57);
            this.panelInfoLop.TabIndex = 22;
            // 
            // txtMalop
            // 
            this.txtMalop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMalop.Enabled = false;
            this.txtMalop.Location = new System.Drawing.Point(114, 19);
            this.txtMalop.MenuManager = this.barManagerLop;
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(160, 22);
            this.txtMalop.TabIndex = 14;
            // 
            // tENLOPTextEdit
            // 
            this.tENLOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.tENLOPTextEdit.Enabled = false;
            this.tENLOPTextEdit.Location = new System.Drawing.Point(377, 17);
            this.tENLOPTextEdit.MenuManager = this.barManagerLop;
            this.tENLOPTextEdit.Name = "tENLOPTextEdit";
            this.tENLOPTextEdit.Size = new System.Drawing.Size(242, 22);
            this.tENLOPTextEdit.TabIndex = 15;
            // 
            // panelDaNghiHoc
            // 
            this.panelDaNghiHoc.Controls.Add(dANGHIHOCLabel);
            this.panelDaNghiHoc.Controls.Add(this.chkDaNghiHoc);
            this.panelDaNghiHoc.Enabled = false;
            this.panelDaNghiHoc.Location = new System.Drawing.Point(477, 136);
            this.panelDaNghiHoc.Name = "panelDaNghiHoc";
            this.panelDaNghiHoc.Size = new System.Drawing.Size(212, 45);
            this.panelDaNghiHoc.TabIndex = 21;
            // 
            // chkDaNghiHoc
            // 
            this.chkDaNghiHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "DANGHIHOC", true));
            this.chkDaNghiHoc.Location = new System.Drawing.Point(111, 15);
            this.chkDaNghiHoc.MenuManager = this.barManagerLop;
            this.chkDaNghiHoc.Name = "chkDaNghiHoc";
            this.chkDaNghiHoc.Properties.Caption = "";
            this.chkDaNghiHoc.Size = new System.Drawing.Size(94, 24);
            this.chkDaNghiHoc.TabIndex = 20;
            // 
            // btnXong
            // 
            this.btnXong.BackColor = System.Drawing.Color.Aqua;
            this.btnXong.Location = new System.Drawing.Point(270, 268);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(144, 37);
            this.btnXong.TabIndex = 18;
            this.btnXong.Text = "KẾT THÚC";
            this.btnXong.UseVisualStyleBackColor = false;
            this.btnXong.Visible = false;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(172, 183);
            this.txtDiaChi.MenuManager = this.barManagerLop;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(222, 22);
            this.txtDiaChi.TabIndex = 17;
            this.txtDiaChi.EditValueChanged += new System.EventHandler(this.txtDiaChi_EditValueChanged);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "NGAYSINH", true));
            this.dateNgaySinh.EditValue = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateNgaySinh.Location = new System.Drawing.Point(588, 67);
            this.dateNgaySinh.MenuManager = this.barManagerLop;
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Size = new System.Drawing.Size(125, 22);
            this.dateNgaySinh.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "PASSWORD", true));
            this.txtPassword.Location = new System.Drawing.Point(171, 221);
            this.txtPassword.MenuManager = this.barManagerLop;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // chkPhai
            // 
            this.chkPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "PHAI", true));
            this.chkPhai.Location = new System.Drawing.Point(588, 106);
            this.chkPhai.MenuManager = this.barManagerLop;
            this.chkPhai.Name = "chkPhai";
            this.chkPhai.Properties.Caption = "Nữ";
            this.chkPhai.Size = new System.Drawing.Size(94, 24);
            this.chkPhai.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(172, 144);
            this.txtTen.MenuManager = this.barManagerLop;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(222, 22);
            this.txtTen.TabIndex = 5;
            this.txtTen.EditValueChanged += new System.EventHandler(this.txtTen_EditValueChanged);
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(172, 103);
            this.txtHo.MenuManager = this.barManagerLop;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(222, 22);
            this.txtHo.TabIndex = 3;
            this.txtHo.EditValueChanged += new System.EventHandler(this.txtHo_EditValueChanged);
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(172, 67);
            this.txtMaSV.MenuManager = this.barManagerLop;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaSV.Size = new System.Drawing.Size(222, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // gvSinhVien
            // 
            this.gvSinhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP,
            this.colDANGHIHOC});
            this.gvSinhVien.GridControl = this.gcSinhVien;
            this.gvSinhVien.Name = "gvSinhVien";
            this.gvSinhVien.OptionsBehavior.ReadOnly = true;
            this.gvSinhVien.OptionsView.ShowViewCaption = true;
            this.gvSinhVien.ViewCaption = "DANH SÁCH SINH VIÊN THEO LỚP";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã Sinh Viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã Lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 6;
            this.colMALOP.Width = 94;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.Caption = "Đã Nghỉ Học";
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.MinWidth = 25;
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 94;
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.bdsSinhVien;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSinhVien.Location = new System.Drawing.Point(0, 87);
            this.gcSinhVien.MainView = this.gvSinhVien;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(1192, 975);
            this.gcSinhVien.TabIndex = 8;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSinhVien});
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "FK_CTLTC_SINHVIEN";
            this.bdsDangKy.DataSource = this.bdsSinhVien;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.DataMember = "FK_SINHVIEN_HOCPHI";
            this.bdsHocPhi.DataSource = this.bdsSinhVien;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1192, 1062);
            this.Controls.Add(this.gbSinhVien);
            this.Controls.Add(this.gcSinhVien);
            this.Controls.Add(this.panelLop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSinhVien";
            this.Text = "SINH VIÊN";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).EndInit();
            this.panelLop.ResumeLayout(false);
            this.panelLop.PerformLayout();
            this.gbSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLop)).EndInit();
            this.panelNhapSinhVien.ResumeLayout(false);
            this.panelNhapSinhVien.PerformLayout();
            this.panelInfoLop.ResumeLayout(false);
            this.panelInfoLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).EndInit();
            this.panelDaNghiHoc.ResumeLayout(false);
            this.panelDaNghiHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkDaNghiHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Bar barLop;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManagerLop;
        private DevExpress.XtraBars.Bar barSinhVien;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnSua;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraBars.BarButtonItem barBtnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem barBtnReload;
        private DevExpress.XtraBars.BarButtonItem barBtnHuy;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Panel panelLop;
        private System.Windows.Forms.ComboBox cmbKhoaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSinhVien;
        private System.Windows.Forms.Panel panelNhapSinhVien;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.CheckEdit chkPhai;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.TextEdit tENLOPTextEdit;
        private DevExpress.XtraEditors.TextEdit txtMalop;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private System.Windows.Forms.Button btnXong;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSinhVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsHocPhi;
        private DevExpress.XtraEditors.CheckEdit chkDaNghiHoc;
        private System.Windows.Forms.Panel panelDaNghiHoc;
        private System.Windows.Forms.Panel panelInfoLop;
    }
}