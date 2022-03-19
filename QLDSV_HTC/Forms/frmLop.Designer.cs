
namespace QLDSV_HTC.Forms
{
    partial class frmLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.barManagerLop = new DevExpress.XtraBars.BarManager(this.components);
            this.barLop = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelLop = new System.Windows.Forms.Panel();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLDSV_HTC.DS();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new QLDSV_HTC.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.LOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbNhapLop = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXong = new System.Windows.Forms.Button();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoaHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.SINHVIENTableAdapter = new QLDSV_HTC.DSTableAdapters.SINHVIENTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).BeginInit();
            this.panelLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbNhapLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(49, 32);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(83, 22);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(49, 70);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(90, 22);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Location = new System.Drawing.Point(49, 104);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(113, 22);
            kHOAHOCLabel.TabIndex = 4;
            kHOAHOCLabel.Text = "KHOAHOC:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(49, 140);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(103, 22);
            mAKHOALabel.TabIndex = 6;
            mAKHOALabel.Text = "MAKHOA:";
            // 
            // barManagerLop
            // 
            this.barManagerLop.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barLop});
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
            this.barBtnLuu});
            this.barManagerLop.MainMenu = this.barLop;
            this.barManagerLop.MaxItemId = 10;
            // 
            // barLop
            // 
            this.barLop.BarName = "Main menu";
            this.barLop.DockCol = 0;
            this.barLop.DockRow = 0;
            this.barLop.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barLop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThoat),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnLuu)});
            this.barLop.OptionsBar.MultiLine = true;
            this.barLop.OptionsBar.UseWholeRow = true;
            this.barLop.Text = "Main menu";
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
            // barBtnGhi
            // 
            this.barBtnGhi.Caption = "GHI";
            this.barBtnGhi.Id = 8;
            this.barBtnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.Image")));
            this.barBtnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGhi.ImageOptions.LargeImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick_1);
            // 
            // barBtnPhucHoi
            // 
            this.barBtnPhucHoi.Caption = "PHỤC HỒI";
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
            // barBtnLuu
            // 
            this.barBtnLuu.Caption = "LƯU";
            this.barBtnLuu.Id = 9;
            this.barBtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnLuu.ImageOptions.Image")));
            this.barBtnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnLuu.ImageOptions.LargeImage")));
            this.barBtnLuu.Name = "barBtnLuu";
            this.barBtnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLuu_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerLop;
            this.barDockControlTop.Size = new System.Drawing.Size(1521, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 802);
            this.barDockControlBottom.Manager = this.barManagerLop;
            this.barDockControlBottom.Size = new System.Drawing.Size(1521, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManagerLop;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 772);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1521, 30);
            this.barDockControlRight.Manager = this.barManagerLop;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 772);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelLop
            // 
            this.panelLop.Controls.Add(this.cmbKhoa);
            this.panelLop.Controls.Add(this.label1);
            this.panelLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLop.Location = new System.Drawing.Point(0, 30);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(1521, 69);
            this.panelLop.TabIndex = 4;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(353, 23);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(410, 33);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            this.bdsLop.CurrentChanged += new System.EventHandler(this.bdsLop_CurrentChanged);
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LOPGridControl
            // 
            this.LOPGridControl.DataSource = this.bdsLop;
            this.LOPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LOPGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.LOPGridControl.Location = new System.Drawing.Point(0, 99);
            this.LOPGridControl.MainView = this.gridView1;
            this.LOPGridControl.MenuManager = this.barManagerLop;
            this.LOPGridControl.Name = "LOPGridControl";
            this.LOPGridControl.Size = new System.Drawing.Size(1521, 358);
            this.LOPGridControl.TabIndex = 15;
            this.LOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridView1.GridControl = this.LOPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "DANH SÁCH LỚP";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 25;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbNhapLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1521, 345);
            this.panel1.TabIndex = 20;
            // 
            // grbNhapLop
            // 
            this.grbNhapLop.Controls.Add(this.btnAdd);
            this.grbNhapLop.Controls.Add(this.btnXong);
            this.grbNhapLop.Controls.Add(mAKHOALabel);
            this.grbNhapLop.Controls.Add(this.txtMaKhoa);
            this.grbNhapLop.Controls.Add(kHOAHOCLabel);
            this.grbNhapLop.Controls.Add(this.txtKhoaHoc);
            this.grbNhapLop.Controls.Add(tENLOPLabel);
            this.grbNhapLop.Controls.Add(this.txtTenLop);
            this.grbNhapLop.Controls.Add(mALOPLabel);
            this.grbNhapLop.Controls.Add(this.txtMaLop);
            this.grbNhapLop.Location = new System.Drawing.Point(500, 40);
            this.grbNhapLop.Name = "grbNhapLop";
            this.grbNhapLop.Size = new System.Drawing.Size(800, 250);
            this.grbNhapLop.TabIndex = 0;
            this.grbNhapLop.TabStop = false;
            this.grbNhapLop.Text = "Nhập thông tin lớp";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(289, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 43);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXong
            // 
            this.btnXong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXong.Location = new System.Drawing.Point(588, 181);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(193, 43);
            this.btnXong.TabIndex = 8;
            this.btnXong.Text = "XONG";
            this.btnXong.UseVisualStyleBackColor = false;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKHOA", true));
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(244, 141);
            this.txtMaKhoa.MenuManager = this.barManagerLop;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(485, 22);
            this.txtMaKhoa.TabIndex = 7;
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "KHOAHOC", true));
            this.txtKhoaHoc.Location = new System.Drawing.Point(244, 105);
            this.txtKhoaHoc.MenuManager = this.barManagerLop;
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(485, 22);
            this.txtKhoaHoc.TabIndex = 5;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(244, 67);
            this.txtTenLop.MenuManager = this.barManagerLop;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(485, 22);
            this.txtTenLop.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(244, 29);
            this.txtMaLop.MenuManager = this.barManagerLop;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(485, 22);
            this.txtMaLop.TabIndex = 1;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_LOP_SINHVIEN";
            this.bdsSV.DataSource = this.bdsLop;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmLop
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LOPGridControl);
            this.Controls.Add(this.panelLop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLop";
            this.Text = "LỚP";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).EndInit();
            this.panelLop.ResumeLayout(false);
            this.panelLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbNhapLop.ResumeLayout(false);
            this.grbNhapLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerLop;
        private DevExpress.XtraBars.Bar barLop;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panelLop;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS DS;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl LOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbNhapLop;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtKhoaHoc;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barBtnReload;
        private DevExpress.XtraBars.BarButtonItem barBtnHuy;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private System.Windows.Forms.Button btnXong;
        private DevExpress.XtraBars.BarButtonItem barBtnLuu;
        private System.Windows.Forms.Button btnAdd;
    }
}