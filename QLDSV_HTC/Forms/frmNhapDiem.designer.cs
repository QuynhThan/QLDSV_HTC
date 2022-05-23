
namespace QLDSV_HTC.Forms
{
    partial class frmNhapDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGhiDiem = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnTaiLopTinChi = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bds_SP_LTC = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_HTC.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.sP_LTCTableAdapter = new QLDSV_HTC.DSTableAdapters.SP_LTCTableAdapter();
            this.sP_LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.bds_DK = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_HTC.DSTableAdapters.DANGKYTableAdapter();
            this.bds_SP_DIEMTCB = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DIEMTCTableAdapter = new QLDSV_HTC.DSTableAdapters.SP_DIEMTCTableAdapter();
            this.sP_DIEMTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiem_TB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_LTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_DIEMTCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DIEMTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnGhiDiem);
            this.groupBox1.Controls.Add(this.btnNhapDiem);
            this.groupBox1.Controls.Add(this.btnTaiLopTinChi);
            this.groupBox1.Controls.Add(this.cmbHocKy);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.cmbNienKhoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGhiDiem.Enabled = false;
            this.btnGhiDiem.Location = new System.Drawing.Point(1051, 22);
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.Size = new System.Drawing.Size(110, 45);
            this.btnGhiDiem.TabIndex = 8;
            this.btnGhiDiem.Text = "Ghi điểm";
            this.btnGhiDiem.UseVisualStyleBackColor = false;
            this.btnGhiDiem.Click += new System.EventHandler(this.btnGhiDiem_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNhapDiem.Enabled = false;
            this.btnNhapDiem.Location = new System.Drawing.Point(926, 22);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(110, 45);
            this.btnNhapDiem.TabIndex = 7;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnTaiLopTinChi
            // 
            this.btnTaiLopTinChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTaiLopTinChi.Location = new System.Drawing.Point(789, 23);
            this.btnTaiLopTinChi.Name = "btnTaiLopTinChi";
            this.btnTaiLopTinChi.Size = new System.Drawing.Size(118, 44);
            this.btnTaiLopTinChi.TabIndex = 6;
            this.btnTaiLopTinChi.Text = "Tải lớp tín chỉ";
            this.btnTaiLopTinChi.UseVisualStyleBackColor = false;
            this.btnTaiLopTinChi.Click += new System.EventHandler(this.btnTaiLopTinChi_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbHocKy.Location = new System.Drawing.Point(610, 33);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(117, 24);
            this.cmbHocKy.TabIndex = 5;
            this.cmbHocKy.SelectedIndexChanged += new System.EventHandler(this.cmbHocKy_SelectedIndexChanged);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(96, 33);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(174, 24);
            this.cmbKhoa.TabIndex = 4;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(390, 33);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 24);
            this.cmbNienKhoa.TabIndex = 3;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niên khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // bds_SP_LTC
            // 
            this.bds_SP_LTC.DataMember = "SP_LTC";
            this.bds_SP_LTC.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1247, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 719);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1247, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 719);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1247, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 719);
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
            // sP_LTCTableAdapter
            // 
            this.sP_LTCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LTCGridControl
            // 
            this.sP_LTCGridControl.DataSource = this.bds_SP_LTC;
            this.sP_LTCGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_LTCGridControl.Location = new System.Drawing.Point(0, 84);
            this.sP_LTCGridControl.MainView = this.gridView1;
            this.sP_LTCGridControl.MenuManager = this.barManager1;
            this.sP_LTCGridControl.Name = "sP_LTCGridControl";
            this.sP_LTCGridControl.Size = new System.Drawing.Size(1247, 635);
            this.sP_LTCGridControl.TabIndex = 14;
            this.sP_LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sP_LTCGridControl.Click += new System.EventHandler(this.sP_LTCGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN});
            this.gridView1.GridControl = this.sP_LTCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.AllowEdit = false;
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.AllowEdit = false;
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.OptionsColumn.ReadOnly = true;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 94;
            // 
            // bds_DK
            // 
            this.bds_DK.DataMember = "DANGKY";
            this.bds_DK.DataSource = this.dS;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bds_SP_DIEMTCB
            // 
            this.bds_SP_DIEMTCB.DataMember = "SP_DIEMTC";
            this.bds_SP_DIEMTCB.DataSource = this.dS;
            // 
            // sP_DIEMTCTableAdapter
            // 
            this.sP_DIEMTCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DIEMTCGridControl
            // 
            this.sP_DIEMTCGridControl.DataSource = this.bds_SP_DIEMTCB;
            this.sP_DIEMTCGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_DIEMTCGridControl.Location = new System.Drawing.Point(0, 346);
            this.sP_DIEMTCGridControl.MainView = this.gridView2;
            this.sP_DIEMTCGridControl.MenuManager = this.barManager1;
            this.sP_DIEMTCGridControl.Name = "sP_DIEMTCGridControl";
            this.sP_DIEMTCGridControl.Size = new System.Drawing.Size(1247, 373);
            this.sP_DIEMTCGridControl.TabIndex = 19;
            this.sP_DIEMTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTENSV,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.colDiem_TB});
            this.gridView2.GridControl = this.sP_DIEMTCGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHOTENSV
            // 
            this.colHOTENSV.FieldName = "HOTENSV";
            this.colHOTENSV.MinWidth = 25;
            this.colHOTENSV.Name = "colHOTENSV";
            this.colHOTENSV.OptionsColumn.AllowEdit = false;
            this.colHOTENSV.OptionsColumn.ReadOnly = true;
            this.colHOTENSV.Visible = true;
            this.colHOTENSV.VisibleIndex = 1;
            this.colHOTENSV.Width = 94;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.MinWidth = 25;
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            this.colDIEM_CC.Width = 94;
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.MinWidth = 25;
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            this.colDIEM_GK.Width = 94;
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.MinWidth = 25;
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            this.colDIEM_CK.Width = 94;
            // 
            // colDiem_TB
            // 
            this.colDiem_TB.Caption = "DIEM_TB";
            this.colDiem_TB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiem_TB.FieldName = "colDiem_TB";
            this.colDiem_TB.MinWidth = 25;
            this.colDiem_TB.Name = "colDiem_TB";
            this.colDiem_TB.OptionsColumn.AllowEdit = false;
            this.colDiem_TB.OptionsColumn.ReadOnly = true;
            this.colDiem_TB.UnboundExpression = "ToInt([DIEM_CC]) * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6";
            this.colDiem_TB.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDiem_TB.Visible = true;
            this.colDiem_TB.VisibleIndex = 5;
            this.colDiem_TB.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "DIEM_TB";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn1";
            this.gridColumn2.FieldName = "DIEM_TB";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 94;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 739);
            this.Controls.Add(this.sP_DIEMTCGridControl);
            this.Controls.Add(this.sP_LTCGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmNhapDiem.IconOptions.LargeImage")));
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_LTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SP_DIEMTCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DIEMTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGhiDiem;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnTaiLopTinChi;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bds_SP_LTC;
        private DSTableAdapters.SP_LTCTableAdapter sP_LTCTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource bds_DK;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bds_SP_DIEMTCB;
        private DSTableAdapters.SP_DIEMTCTableAdapter sP_DIEMTCTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_DIEMTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENSV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DevExpress.XtraGrid.Columns.GridColumn colDiem_TB;
    }
}