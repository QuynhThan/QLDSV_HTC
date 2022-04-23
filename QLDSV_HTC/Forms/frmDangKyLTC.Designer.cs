
namespace QLDSV_HTC.Forms
{
    partial class frmDangKyLTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyLTC));
            this.panelDN = new System.Windows.Forms.Panel();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLDSV_HTC.DS();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.bdsSP_DSLTCDADANGKY = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSP_DSLTC_NIENKHOAHOCKY = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSLTCDADANGKYTableAdapter = new QLDSV_HTC.DSTableAdapters.SP_DSLTCDADANGKYTableAdapter();
            this.sP_DSLTC_NIENKHOAHOCKYTableAdapter = new QLDSV_HTC.DSTableAdapters.SP_DSLTC_NIENKHOAHOCKYTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDKLTC = new DevExpress.XtraBars.Bar();
            this.barBtnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBoxDKLTC = new System.Windows.Forms.GroupBox();
            this.gcDangKyLTC = new DevExpress.XtraGrid.GridControl();
            this.gvDangKyLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.panelNKHK = new System.Windows.Forms.Panel();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gcLTCDaDangKy = new DevExpress.XtraGrid.GridControl();
            this.gvLTCDaDangKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_DSLTCDADANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_DSLTC_NIENKHOAHOCKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBoxDKLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKyLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangKyLTC)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelNKHK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTCDaDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTCDaDangKy)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDN
            // 
            this.panelDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDN.Controls.Add(this.lblMaSV);
            this.panelDN.Controls.Add(this.lblTenLop);
            this.panelDN.Controls.Add(this.label7);
            this.panelDN.Controls.Add(this.lblMaLop);
            this.panelDN.Controls.Add(this.label4);
            this.panelDN.Controls.Add(this.lblHoTen);
            this.panelDN.Controls.Add(this.label2);
            this.panelDN.Controls.Add(this.label1);
            this.panelDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDN.Location = new System.Drawing.Point(0, 30);
            this.panelDN.Margin = new System.Windows.Forms.Padding(4);
            this.panelDN.Name = "panelDN";
            this.panelDN.Size = new System.Drawing.Size(1581, 66);
            this.panelDN.TabIndex = 0;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(340, 10);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(0, 21);
            this.lblMaSV.TabIndex = 15;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(838, 35);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(0, 21);
            this.lblTenLop.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Lớp:";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(296, 35);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(0, 21);
            this.lblMaLop.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã Lớp:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(835, 10);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(0, 21);
            this.lblHoTen.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bdsSP_DSLTCDADANGKY
            // 
            this.bdsSP_DSLTCDADANGKY.DataMember = "SP_DSLTCDADANGKY";
            this.bdsSP_DSLTCDADANGKY.DataSource = this.dS;
            // 
            // bdsSP_DSLTC_NIENKHOAHOCKY
            // 
            this.bdsSP_DSLTC_NIENKHOAHOCKY.DataMember = "SP_DSLTC_NIENKHOAHOCKY";
            this.bdsSP_DSLTC_NIENKHOAHOCKY.DataSource = this.dS;
            // 
            // sP_DSLTCDADANGKYTableAdapter
            // 
            this.sP_DSLTCDADANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DSLTC_NIENKHOAHOCKYTableAdapter
            // 
            this.sP_DSLTC_NIENKHOAHOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barDKLTC});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThoat,
            this.barBtnReload});
            this.barManager1.MainMenu = this.barDKLTC;
            this.barManager1.MaxItemId = 3;
            // 
            // barDKLTC
            // 
            this.barDKLTC.BarName = "Main menu";
            this.barDKLTC.DockCol = 0;
            this.barDKLTC.DockRow = 0;
            this.barDKLTC.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barDKLTC.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThoat)});
            this.barDKLTC.OptionsBar.MultiLine = true;
            this.barDKLTC.OptionsBar.UseWholeRow = true;
            this.barDKLTC.Text = "Main menu";
            // 
            // barBtnReload
            // 
            this.barBtnReload.Caption = "Reload";
            this.barBtnReload.Enabled = false;
            this.barBtnReload.Id = 2;
            this.barBtnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnReload.ImageOptions.SvgImage")));
            this.barBtnReload.Name = "barBtnReload";
            this.barBtnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReload_ItemClick);
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Id = 1;
            this.barBtnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThoat.ImageOptions.SvgImage")));
            this.barBtnThoat.Name = "barBtnThoat";
            this.barBtnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1581, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1062);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1581, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1581, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1032);
            // 
            // groupBoxDKLTC
            // 
            this.groupBoxDKLTC.BackColor = System.Drawing.Color.White;
            this.groupBoxDKLTC.Controls.Add(this.gcDangKyLTC);
            this.groupBoxDKLTC.Controls.Add(this.panel3);
            this.groupBoxDKLTC.Controls.Add(this.panelNKHK);
            this.groupBoxDKLTC.Controls.Add(this.gcLTCDaDangKy);
            this.groupBoxDKLTC.Controls.Add(this.panel4);
            this.groupBoxDKLTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDKLTC.Location = new System.Drawing.Point(0, 96);
            this.groupBoxDKLTC.Name = "groupBoxDKLTC";
            this.groupBoxDKLTC.Size = new System.Drawing.Size(1581, 966);
            this.groupBoxDKLTC.TabIndex = 18;
            this.groupBoxDKLTC.TabStop = false;
            // 
            // gcDangKyLTC
            // 
            this.gcDangKyLTC.DataSource = this.bdsSP_DSLTC_NIENKHOAHOCKY;
            this.gcDangKyLTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDangKyLTC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gcDangKyLTC.Location = new System.Drawing.Point(3, 88);
            this.gcDangKyLTC.MainView = this.gvDangKyLTC;
            this.gcDangKyLTC.Name = "gcDangKyLTC";
            this.gcDangKyLTC.Size = new System.Drawing.Size(1575, 507);
            this.gcDangKyLTC.TabIndex = 15;
            this.gcDangKyLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDangKyLTC});
            // 
            // gvDangKyLTC
            // 
            this.gvDangKyLTC.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvDangKyLTC.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDangKyLTC.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aqua;
            this.gvDangKyLTC.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDangKyLTC.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Aqua;
            this.gvDangKyLTC.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvDangKyLTC.Appearance.SelectedRow.BackColor = System.Drawing.Color.Aqua;
            this.gvDangKyLTC.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Aqua;
            this.gvDangKyLTC.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDangKyLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTENGV,
            this.colMaxSV,
            this.colSOLSV});
            this.gvDangKyLTC.GridControl = this.gcDangKyLTC;
            this.gvDangKyLTC.Name = "gvDangKyLTC";
            this.gvDangKyLTC.OptionsSelection.MultiSelect = true;
            this.gvDangKyLTC.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDangKyLTC.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gvDangKyLTC.OptionsView.ShowIndicator = false;
            this.gvDangKyLTC.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDangKyLTC_SelectionChanged);
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 25;
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.AllowEdit = false;
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 1;
            this.colSTT.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã Môn Học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            this.colMAMH.Width = 179;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên Môn Học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 3;
            this.colTENMH.Width = 253;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.AllowEdit = false;
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 253;
            // 
            // colHOTENGV
            // 
            this.colHOTENGV.Caption = "Tên Giảng Viên";
            this.colHOTENGV.FieldName = "TENGV";
            this.colHOTENGV.MinWidth = 25;
            this.colHOTENGV.Name = "colHOTENGV";
            this.colHOTENGV.OptionsColumn.AllowEdit = false;
            this.colHOTENGV.OptionsColumn.ReadOnly = true;
            this.colHOTENGV.Visible = true;
            this.colHOTENGV.VisibleIndex = 5;
            this.colHOTENGV.Width = 253;
            // 
            // colMaxSV
            // 
            this.colMaxSV.Caption = "Số SV Tối Đa";
            this.colMaxSV.FieldName = "SOSVTOITHIEU";
            this.colMaxSV.MinWidth = 25;
            this.colMaxSV.Name = "colMaxSV";
            this.colMaxSV.OptionsColumn.AllowEdit = false;
            this.colMaxSV.OptionsColumn.ReadOnly = true;
            this.colMaxSV.Visible = true;
            this.colMaxSV.VisibleIndex = 6;
            this.colMaxSV.Width = 253;
            // 
            // colSOLSV
            // 
            this.colSOLSV.Caption = "Số SV Đã ĐK";
            this.colSOLSV.FieldName = "SOSVDADK";
            this.colSOLSV.MinWidth = 25;
            this.colSOLSV.Name = "colSOLSV";
            this.colSOLSV.OptionsColumn.AllowEdit = false;
            this.colSOLSV.OptionsColumn.ReadOnly = true;
            this.colSOLSV.Visible = true;
            this.colSOLSV.VisibleIndex = 7;
            this.colSOLSV.Width = 258;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 595);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1575, 84);
            this.panel3.TabIndex = 13;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(9, 59);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(239, 22);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Danh sách môn học đã chọn";
            // 
            // panelNKHK
            // 
            this.panelNKHK.Controls.Add(this.cmbNienKhoa);
            this.panelNKHK.Controls.Add(this.pictureBox1);
            this.panelNKHK.Controls.Add(this.label3);
            this.panelNKHK.Controls.Add(this.btnLoc);
            this.panelNKHK.Controls.Add(this.txtHocKy);
            this.panelNKHK.Controls.Add(this.label6);
            this.panelNKHK.Controls.Add(this.label5);
            this.panelNKHK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNKHK.Location = new System.Drawing.Point(3, 24);
            this.panelNKHK.Name = "panelNKHK";
            this.panelNKHK.Size = new System.Drawing.Size(1575, 64);
            this.panelNKHK.TabIndex = 13;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(213, 18);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(158, 28);
            this.cmbNienKhoa.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.Location = new System.Drawing.Point(1385, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(1427, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "ĐÃ ĐĂNG KÝ";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(817, 12);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 40);
            this.btnLoc.TabIndex = 12;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtHocKy
            // 
            this.txtHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Location = new System.Drawing.Point(609, 20);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocKy.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Size = new System.Drawing.Size(58, 24);
            this.txtHocKy.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "HỌC KỲ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "NIÊN KHÓA";
            // 
            // gcLTCDaDangKy
            // 
            this.gcLTCDaDangKy.DataSource = this.bdsSP_DSLTCDADANGKY;
            this.gcLTCDaDangKy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcLTCDaDangKy.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gcLTCDaDangKy.Location = new System.Drawing.Point(3, 679);
            this.gcLTCDaDangKy.MainView = this.gvLTCDaDangKy;
            this.gcLTCDaDangKy.Name = "gcLTCDaDangKy";
            this.gcLTCDaDangKy.Size = new System.Drawing.Size(1575, 220);
            this.gcLTCDaDangKy.TabIndex = 12;
            this.gcLTCDaDangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLTCDaDangKy});
            // 
            // gvLTCDaDangKy
            // 
            this.gvLTCDaDangKy.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvLTCDaDangKy.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvLTCDaDangKy.Appearance.FocusedRow.BackColor = System.Drawing.Color.PeachPuff;
            this.gvLTCDaDangKy.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvLTCDaDangKy.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.PeachPuff;
            this.gvLTCDaDangKy.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvLTCDaDangKy.Appearance.SelectedRow.BackColor = System.Drawing.Color.PeachPuff;
            this.gvLTCDaDangKy.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvLTCDaDangKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT1,
            this.colMAMH1,
            this.colTENMH1,
            this.colNIENKHOA1,
            this.colHOCKY1,
            this.colNHOM1});
            this.gvLTCDaDangKy.GridControl = this.gcLTCDaDangKy;
            this.gvLTCDaDangKy.Name = "gvLTCDaDangKy";
            this.gvLTCDaDangKy.OptionsSelection.MultiSelect = true;
            this.gvLTCDaDangKy.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvLTCDaDangKy.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gvLTCDaDangKy.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvLTCDaDangKy_SelectionChanged);
            // 
            // colSTT1
            // 
            this.colSTT1.Caption = "STT";
            this.colSTT1.FieldName = "STT";
            this.colSTT1.MinWidth = 25;
            this.colSTT1.Name = "colSTT1";
            this.colSTT1.OptionsColumn.AllowEdit = false;
            this.colSTT1.Visible = true;
            this.colSTT1.VisibleIndex = 1;
            this.colSTT1.Width = 68;
            // 
            // colMAMH1
            // 
            this.colMAMH1.Caption = "MÃ MÔN HỌC";
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 25;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.OptionsColumn.AllowEdit = false;
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 2;
            this.colMAMH1.Width = 212;
            // 
            // colTENMH1
            // 
            this.colTENMH1.Caption = "TÊN MÔN HỌC";
            this.colTENMH1.FieldName = "TENMH";
            this.colTENMH1.MinWidth = 25;
            this.colTENMH1.Name = "colTENMH1";
            this.colTENMH1.OptionsColumn.AllowEdit = false;
            this.colTENMH1.Visible = true;
            this.colTENMH1.VisibleIndex = 3;
            this.colTENMH1.Width = 289;
            // 
            // colNIENKHOA1
            // 
            this.colNIENKHOA1.Caption = "NIÊN KHÓA";
            this.colNIENKHOA1.FieldName = "NIENKHOA";
            this.colNIENKHOA1.MinWidth = 25;
            this.colNIENKHOA1.Name = "colNIENKHOA1";
            this.colNIENKHOA1.OptionsColumn.AllowEdit = false;
            this.colNIENKHOA1.Visible = true;
            this.colNIENKHOA1.VisibleIndex = 4;
            this.colNIENKHOA1.Width = 289;
            // 
            // colHOCKY1
            // 
            this.colHOCKY1.Caption = "HỌC KỲ";
            this.colHOCKY1.FieldName = "HOCKY";
            this.colHOCKY1.MinWidth = 25;
            this.colHOCKY1.Name = "colHOCKY1";
            this.colHOCKY1.OptionsColumn.AllowEdit = false;
            this.colHOCKY1.Visible = true;
            this.colHOCKY1.VisibleIndex = 5;
            this.colHOCKY1.Width = 289;
            // 
            // colNHOM1
            // 
            this.colNHOM1.Caption = "NHÓM";
            this.colNHOM1.FieldName = "NHOM";
            this.colNHOM1.MinWidth = 25;
            this.colNHOM1.Name = "colNHOM1";
            this.colNHOM1.OptionsColumn.AllowEdit = false;
            this.colNHOM1.OptionsColumn.ReadOnly = true;
            this.colNHOM1.Visible = true;
            this.colNHOM1.VisibleIndex = 6;
            this.colNHOM1.Width = 302;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 899);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1575, 64);
            this.panel4.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.FlatAppearance.BorderSize = 3;
            this.btnXoa.Location = new System.Drawing.Point(5, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(243, 41);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "HỦY ĐĂNG KÝ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseLeave += new System.EventHandler(this.btnXoa_MouseLeave);
            this.btnXoa.MouseHover += new System.EventHandler(this.btnXoa_MouseHover);
            // 
            // frmDangKyLTC
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1581, 1062);
            this.Controls.Add(this.groupBoxDKLTC);
            this.Controls.Add(this.panelDN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKyLTC";
            this.Text = "Đăng ký lớp tín chỉ";
            this.Load += new System.EventHandler(this.frmDangKyLTC_Load);
            this.panelDN.ResumeLayout(false);
            this.panelDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_DSLTCDADANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_DSLTC_NIENKHOAHOCKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBoxDKLTC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKyLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangKyLTC)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelNKHK.ResumeLayout(false);
            this.panelNKHK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTCDaDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTCDaDangKy)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDN;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsSP_DSLTCDADANGKY;
        private DSTableAdapters.SP_DSLTCDADANGKYTableAdapter sP_DSLTCDADANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsSP_DSLTC_NIENKHOAHOCKY;
        private DSTableAdapters.SP_DSLTC_NIENKHOAHOCKYTableAdapter sP_DSLTC_NIENKHOAHOCKYTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barDKLTC;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox groupBoxDKLTC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblText;
        private DevExpress.XtraGrid.GridControl gcLTCDaDangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLTCDaDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panelNKHK;
        private System.Windows.Forms.Button btnLoc;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gcDangKyLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDangKyLTC;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxSV;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLSV;
        private DevExpress.XtraBars.BarButtonItem barBtnReload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
    }
}