
namespace QLDSV_HTC.Forms
{
    partial class frmHocPhi
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
            System.Windows.Forms.Label niên_khóaLabel;
            System.Windows.Forms.Label học_kỳLabel;
            System.Windows.Forms.Label học_phíLabel;
            System.Windows.Forms.Label tổng_số_tiền_đóngLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbTenSV = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.DS = new QLDSV_HTC.DS();
            this.bdsDSHOCPHI = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSHOCPHITableAdapter = new QLDSV_HTC.DSTableAdapters.SP_DSHOCPHITableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.bdsCTHP = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CTHOCPHITableAdapter = new QLDSV_HTC.DSTableAdapters.SP_CTHOCPHITableAdapter();
            this.sP_CTHOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_DSHOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNiênkhóa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọckỳ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọcphí = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTổngsốtiềnđóng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốtiềncầnđóng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoTienDong = new DevExpress.XtraEditors.SpinEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtHK = new DevExpress.XtraEditors.TextEdit();
            this.txtHP = new DevExpress.XtraEditors.TextEdit();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemHP = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaHP = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiHP = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            niên_khóaLabel = new System.Windows.Forms.Label();
            học_kỳLabel = new System.Windows.Forms.Label();
            học_phíLabel = new System.Windows.Forms.Label();
            tổng_số_tiền_đóngLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSHOCPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CTHOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSHOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // niên_khóaLabel
            // 
            niên_khóaLabel.AutoSize = true;
            niên_khóaLabel.Location = new System.Drawing.Point(38, 37);
            niên_khóaLabel.Name = "niên_khóaLabel";
            niên_khóaLabel.Size = new System.Drawing.Size(73, 17);
            niên_khóaLabel.TabIndex = 4;
            niên_khóaLabel.Text = "Niên khóa:";
            // 
            // học_kỳLabel
            // 
            học_kỳLabel.AutoSize = true;
            học_kỳLabel.Location = new System.Drawing.Point(41, 69);
            học_kỳLabel.Name = "học_kỳLabel";
            học_kỳLabel.Size = new System.Drawing.Size(56, 17);
            học_kỳLabel.TabIndex = 5;
            học_kỳLabel.Text = "Học kỳ:";
            // 
            // học_phíLabel
            // 
            học_phíLabel.AutoSize = true;
            học_phíLabel.Location = new System.Drawing.Point(41, 109);
            học_phíLabel.Name = "học_phíLabel";
            học_phíLabel.Size = new System.Drawing.Size(59, 17);
            học_phíLabel.TabIndex = 6;
            học_phíLabel.Text = "Học phí:";
            // 
            // tổng_số_tiền_đóngLabel
            // 
            tổng_số_tiền_đóngLabel.AutoSize = true;
            tổng_số_tiền_đóngLabel.Location = new System.Drawing.Point(42, 149);
            tổng_số_tiền_đóngLabel.Name = "tổng_số_tiền_đóngLabel";
            tổng_số_tiền_đóngLabel.Size = new System.Drawing.Size(125, 17);
            tổng_số_tiền_đóngLabel.TabIndex = 7;
            tổng_số_tiền_đóngLabel.Text = "Tổng số tiền đóng:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbMaLop);
            this.panelControl1.Controls.Add(this.lbTenSV);
            this.panelControl1.Controls.Add(this.lbMaSV);
            this.panelControl1.Controls.Add(this.btnLoc);
            this.panelControl1.Controls.Add(this.txtMaLop);
            this.panelControl1.Controls.Add(this.txtTenSV);
            this.panelControl1.Controls.Add(this.txtMaSV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1327, 70);
            this.panelControl1.TabIndex = 0;
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(582, 27);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(52, 17);
            this.lbMaLop.TabIndex = 6;
            this.lbMaLop.Text = "Mã Lớp";
            // 
            // lbTenSV
            // 
            this.lbTenSV.AutoSize = true;
            this.lbTenSV.Location = new System.Drawing.Point(301, 27);
            this.lbTenSV.Name = "lbTenSV";
            this.lbTenSV.Size = new System.Drawing.Size(88, 17);
            this.lbTenSV.TabIndex = 5;
            this.lbTenSV.Text = "Tên sinh viên";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(15, 27);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(82, 17);
            this.lbMaSV.TabIndex = 4;
            this.lbMaSV.Text = "Mã sinh viên";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(905, 21);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(56, 29);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(677, 24);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(179, 23);
            this.txtMaLop.TabIndex = 2;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(395, 22);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(157, 23);
            this.txtTenSV.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaSV.Location = new System.Drawing.Point(103, 21);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(165, 23);
            this.txtMaSV.TabIndex = 0;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSHOCPHI
            // 
            this.bdsDSHOCPHI.DataMember = "SP_DSHOCPHI";
            this.bdsDSHOCPHI.DataSource = this.DS;
            // 
            // sP_DSHOCPHITableAdapter
            // 
            this.sP_DSHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsCTHP
            // 
            this.bdsCTHP.DataMember = "SP_CTHOCPHI";
            this.bdsCTHP.DataSource = this.DS;
            // 
            // sP_CTHOCPHITableAdapter
            // 
            this.sP_CTHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // sP_CTHOCPHIGridControl
            // 
            this.sP_CTHOCPHIGridControl.DataSource = this.bdsCTHP;
            this.sP_CTHOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.sP_CTHOCPHIGridControl.Location = new System.Drawing.Point(415, 0);
            this.sP_CTHOCPHIGridControl.MainView = this.gridView2;
            this.sP_CTHOCPHIGridControl.Name = "sP_CTHOCPHIGridControl";
            this.sP_CTHOCPHIGridControl.Size = new System.Drawing.Size(912, 600);
            this.sP_CTHOCPHIGridControl.TabIndex = 4;
            this.sP_CTHOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gridView2.GridControl = this.sP_CTHOCPHIGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView2_InitNewRow);
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 25;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.OptionsColumn.AllowEdit = false;
            this.colNGAYDONG.OptionsColumn.ReadOnly = true;
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 94;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 25;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 94;
            // 
            // sP_DSHOCPHIGridControl
            // 
            this.sP_DSHOCPHIGridControl.DataSource = this.bdsDSHOCPHI;
            this.sP_DSHOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_DSHOCPHIGridControl.Location = new System.Drawing.Point(0, 100);
            this.sP_DSHOCPHIGridControl.MainView = this.gridView1;
            this.sP_DSHOCPHIGridControl.Name = "sP_DSHOCPHIGridControl";
            this.sP_DSHOCPHIGridControl.Size = new System.Drawing.Size(1327, 362);
            this.sP_DSHOCPHIGridControl.TabIndex = 4;
            this.sP_DSHOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sP_DSHOCPHIGridControl.Click += new System.EventHandler(this.sP_DSHOCPHIGridControl_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNiênkhóa,
            this.colHọckỳ,
            this.colHọcphí,
            this.colTổngsốtiềnđóng,
            this.colSốtiềncầnđóng});
            this.gridView1.GridControl = this.sP_DSHOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colNiênkhóa
            // 
            this.colNiênkhóa.FieldName = "Niên khóa";
            this.colNiênkhóa.MinWidth = 25;
            this.colNiênkhóa.Name = "colNiênkhóa";
            this.colNiênkhóa.OptionsColumn.AllowEdit = false;
            this.colNiênkhóa.OptionsColumn.ReadOnly = true;
            this.colNiênkhóa.Visible = true;
            this.colNiênkhóa.VisibleIndex = 0;
            this.colNiênkhóa.Width = 94;
            // 
            // colHọckỳ
            // 
            this.colHọckỳ.FieldName = "Học kỳ";
            this.colHọckỳ.MinWidth = 25;
            this.colHọckỳ.Name = "colHọckỳ";
            this.colHọckỳ.OptionsColumn.AllowEdit = false;
            this.colHọckỳ.OptionsColumn.ReadOnly = true;
            this.colHọckỳ.Visible = true;
            this.colHọckỳ.VisibleIndex = 1;
            this.colHọckỳ.Width = 94;
            // 
            // colHọcphí
            // 
            this.colHọcphí.FieldName = "Học phí";
            this.colHọcphí.MinWidth = 25;
            this.colHọcphí.Name = "colHọcphí";
            this.colHọcphí.OptionsColumn.AllowEdit = false;
            this.colHọcphí.OptionsColumn.ReadOnly = true;
            this.colHọcphí.Visible = true;
            this.colHọcphí.VisibleIndex = 2;
            this.colHọcphí.Width = 94;
            // 
            // colTổngsốtiềnđóng
            // 
            this.colTổngsốtiềnđóng.FieldName = "Tổng số tiền đóng";
            this.colTổngsốtiềnđóng.MinWidth = 25;
            this.colTổngsốtiềnđóng.Name = "colTổngsốtiềnđóng";
            this.colTổngsốtiềnđóng.OptionsColumn.AllowEdit = false;
            this.colTổngsốtiềnđóng.OptionsColumn.ReadOnly = true;
            this.colTổngsốtiềnđóng.Visible = true;
            this.colTổngsốtiềnđóng.VisibleIndex = 3;
            this.colTổngsốtiềnđóng.Width = 94;
            // 
            // colSốtiềncầnđóng
            // 
            this.colSốtiềncầnđóng.Caption = "Số tiền cần đóng";
            this.colSốtiềncầnđóng.FieldName = "colSốtiềncầnđóng";
            this.colSốtiềncầnđóng.MinWidth = 25;
            this.colSốtiềncầnđóng.Name = "colSốtiềncầnđóng";
            this.colSốtiềncầnđóng.OptionsColumn.AllowEdit = false;
            this.colSốtiềncầnđóng.OptionsColumn.ReadOnly = true;
            this.colSốtiềncầnđóng.UnboundExpression = "[Học phí] - [Tổng số tiền đóng]";
            this.colSốtiềncầnđóng.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colSốtiềncầnđóng.Visible = true;
            this.colSốtiềncầnđóng.VisibleIndex = 4;
            this.colSốtiềncầnđóng.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tổng_số_tiền_đóngLabel);
            this.panel1.Controls.Add(this.txtSoTienDong);
            this.panel1.Controls.Add(học_phíLabel);
            this.panel1.Controls.Add(học_kỳLabel);
            this.panel1.Controls.Add(this.sP_CTHOCPHIGridControl);
            this.panel1.Controls.Add(niên_khóaLabel);
            this.panel1.Controls.Add(this.txtNienKhoa);
            this.panel1.Controls.Add(this.txtHK);
            this.panel1.Controls.Add(this.txtHP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 600);
            this.panel1.TabIndex = 5;
            // 
            // txtSoTienDong
            // 
            this.txtSoTienDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSHOCPHI, "Tổng số tiền đóng", true));
            this.txtSoTienDong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoTienDong.Location = new System.Drawing.Point(173, 146);
            this.txtSoTienDong.MenuManager = this.barManager1;
            this.txtSoTienDong.Name = "txtSoTienDong";
            this.txtSoTienDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTienDong.Properties.ReadOnly = true;
            this.txtSoTienDong.Size = new System.Drawing.Size(125, 24);
            this.txtSoTienDong.TabIndex = 8;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 30);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1062);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1032);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1327, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1032);
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSHOCPHI, "Niên khóa", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(173, 34);
            this.txtNienKhoa.MenuManager = this.barManager1;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(125, 22);
            this.txtNienKhoa.TabIndex = 5;
            this.txtNienKhoa.EditValueChanged += new System.EventHandler(this.txtNienKhoa_EditValueChanged);
            // 
            // txtHK
            // 
            this.txtHK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSHOCPHI, "Học kỳ", true));
            this.txtHK.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHK.Location = new System.Drawing.Point(173, 65);
            this.txtHK.MenuManager = this.barManager1;
            this.txtHK.Name = "txtHK";
            this.txtHK.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtHK.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHK.Size = new System.Drawing.Size(125, 22);
            this.txtHK.TabIndex = 6;
            this.txtHK.EditValueChanged += new System.EventHandler(this.txtHK_EditValueChanged);
            // 
            // txtHP
            // 
            this.txtHP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSHOCPHI, "Học phí", true));
            this.txtHP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHP.Location = new System.Drawing.Point(173, 105);
            this.txtHP.MenuManager = this.barManager1;
            this.txtHP.Name = "txtHP";
            this.txtHP.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtHP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHP.Size = new System.Drawing.Size(125, 22);
            this.txtHP.TabIndex = 7;
            this.txtHP.EditValueChanged += new System.EventHandler(this.txtHP_EditValueChanged);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemHP,
            this.btnGhiHP,
            this.btnXoaHP});
            this.barManager2.MainMenu = this.bar2;
            this.barManager2.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(314, 189);
            this.bar2.FloatSize = new System.Drawing.Size(53, 22);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemHP),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaHP),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhiHP)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemHP
            // 
            this.btnThemHP.Caption = "Thêm";
            this.btnThemHP.Id = 0;
            this.btnThemHP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHP.ImageOptions.Image")));
            this.btnThemHP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemHP.ImageOptions.LargeImage")));
            this.btnThemHP.Name = "btnThemHP";
            this.btnThemHP.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThemHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemHP_ItemClick);
            // 
            // btnXoaHP
            // 
            this.btnXoaHP.Caption = "Xóa";
            this.btnXoaHP.Id = 2;
            this.btnXoaHP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHP.ImageOptions.Image")));
            this.btnXoaHP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaHP.ImageOptions.LargeImage")));
            this.btnXoaHP.Name = "btnXoaHP";
            this.btnXoaHP.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoaHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaHP_ItemClick);
            // 
            // btnGhiHP
            // 
            this.btnGhiHP.Caption = "Ghi";
            this.btnGhiHP.Id = 1;
            this.btnGhiHP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiHP.ImageOptions.Image")));
            this.btnGhiHP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiHP.ImageOptions.LargeImage")));
            this.btnGhiHP.Name = "btnGhiHP";
            this.btnGhiHP.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhiHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiHP_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1327, 30);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1062);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 30);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 1032);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1327, 30);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 1032);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCTHP,
            this.lưuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 52);
            // 
            // btnThemCTHP
            // 
            this.btnThemCTHP.Name = "btnThemCTHP";
            this.btnThemCTHP.Size = new System.Drawing.Size(115, 24);
            this.btnThemCTHP.Text = "Thêm";
            this.btnThemCTHP.Click += new System.EventHandler(this.btnThemCTHP_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1327, 1062);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sP_DSHOCPHIGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmHocPhi";
            this.Text = "frmHocPhi";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSHOCPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CTHOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSHOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbTenSV;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsDSHOCPHI;
        private DSTableAdapters.SP_DSHOCPHITableAdapter sP_DSHOCPHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCTHP;
        private DSTableAdapters.SP_CTHOCPHITableAdapter sP_CTHOCPHITableAdapter;
        private DevExpress.XtraGrid.GridControl sP_CTHOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl sP_DSHOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNiênkhóa;
        private DevExpress.XtraGrid.Columns.GridColumn colHọckỳ;
        private DevExpress.XtraGrid.Columns.GridColumn colHọcphí;
        private DevExpress.XtraGrid.Columns.GridColumn colTổngsốtiềnđóng;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSốtiềncầnđóng;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemHP;
        private DevExpress.XtraBars.BarButtonItem btnGhiHP;
        private DevExpress.XtraBars.BarButtonItem btnXoaHP;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemCTHP;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private DevExpress.XtraEditors.SpinEdit txtSoTienDong;
        private DevExpress.XtraEditors.TextEdit txtHK;
        private DevExpress.XtraEditors.TextEdit txtHP;
    }
}