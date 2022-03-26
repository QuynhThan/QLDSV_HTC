
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonThem = new DevExpress.XtraBars.BarButtonItem();
            this.r = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.qLDSVHTCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet = new QLDSV_HTC.QLDSV_HTCDataSet();
            this.fKLOPTINCHIMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.LOPTINCHITableAdapter();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.MONHOCTableAdapter();
            this.mAMHTextBox = new System.Windows.Forms.TextBox();
            this.tENMHTextBox = new System.Windows.Forms.TextBox();
            this.sOTIET_LTTextBox = new System.Windows.Forms.TextBox();
            this.sOTIET_THTextBox = new System.Windows.Forms.TextBox();
            this.mONHOCGridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVHTCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLOPTINCHIMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(34, 155);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(43, 13);
            mAMHLabel.TabIndex = 22;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(28, 181);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(49, 13);
            tENMHLabel.TabIndex = 23;
            tENMHLabel.Text = "TENMH:";
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Location = new System.Drawing.Point(12, 207);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(65, 13);
            sOTIET_LTLabel.TabIndex = 24;
            sOTIET_LTLabel.Text = "SOTIET LT:";
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Location = new System.Drawing.Point(10, 233);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(67, 13);
            sOTIET_THLabel.TabIndex = 25;
            sOTIET_THLabel.Text = "SOTIET TH:";
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
            this.barButtonThem,
            this.r,
            this.barButtonGhi,
            this.barButtonItem4,
            this.barButtonPhucHoi,
            this.barButtonItem6,
            this.barButtonHuy,
            this.barButtonThoat,
            this.barButtonReload,
            this.barButtonLuu});
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.r, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonThem
            // 
            this.barButtonThem.Caption = "THÊM";
            this.barButtonThem.Id = 0;
            this.barButtonThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonThem.ImageOptions.Image")));
            this.barButtonThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonThem.ImageOptions.LargeImage")));
            this.barButtonThem.Name = "barButtonThem";
            // 
            // r
            // 
            this.r.Caption = "XÓA";
            this.r.Id = 1;
            this.r.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("r.ImageOptions.Image")));
            this.r.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("r.ImageOptions.LargeImage")));
            this.r.Name = "r";
            // 
            // barButtonGhi
            // 
            this.barButtonGhi.Caption = "GHI";
            this.barButtonGhi.Id = 2;
            this.barButtonGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonGhi.ImageOptions.Image")));
            this.barButtonGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonGhi.ImageOptions.LargeImage")));
            this.barButtonGhi.Name = "barButtonGhi";
            // 
            // barButtonPhucHoi
            // 
            this.barButtonPhucHoi.Caption = "PHỤC HỒI";
            this.barButtonPhucHoi.Id = 4;
            this.barButtonPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonPhucHoi.ImageOptions.Image")));
            this.barButtonPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonPhucHoi.ImageOptions.LargeImage")));
            this.barButtonPhucHoi.Name = "barButtonPhucHoi";
            // 
            // barButtonReload
            // 
            this.barButtonReload.Caption = "RELOAD";
            this.barButtonReload.Id = 8;
            this.barButtonReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonReload.ImageOptions.SvgImage")));
            this.barButtonReload.Name = "barButtonReload";
            // 
            // barButtonHuy
            // 
            this.barButtonHuy.Caption = "HỦY";
            this.barButtonHuy.Id = 6;
            this.barButtonHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonHuy.ImageOptions.SvgImage")));
            this.barButtonHuy.Name = "barButtonHuy";
            // 
            // barButtonThoat
            // 
            this.barButtonThoat.Caption = "THOÁT";
            this.barButtonThoat.Id = 7;
            this.barButtonThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonThoat.ImageOptions.SvgImage")));
            this.barButtonThoat.Name = "barButtonThoat";
            // 
            // barButtonLuu
            // 
            this.barButtonLuu.Caption = "LƯU";
            this.barButtonLuu.Id = 9;
            this.barButtonLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonLuu.ImageOptions.Image")));
            this.barButtonLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonLuu.ImageOptions.LargeImage")));
            this.barButtonLuu.Name = "barButtonLuu";
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
            // qLDSVHTCDataSetBindingSource
            // 
            this.qLDSVHTCDataSetBindingSource.DataSource = this.qLDSV_HTCDataSet;
            this.qLDSVHTCDataSetBindingSource.Position = 0;
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKLOPTINCHIMONHOCBindingSource
            // 
            this.fKLOPTINCHIMONHOCBindingSource.DataMember = "FK_LOPTINCHI_MONHOC";
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.QLDSV_HTCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mAMHTextBox
            // 
            this.mAMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHTextBox.Location = new System.Drawing.Point(83, 152);
            this.mAMHTextBox.Name = "mAMHTextBox";
            this.mAMHTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAMHTextBox.TabIndex = 23;
            // 
            // tENMHTextBox
            // 
            this.tENMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHTextBox.Location = new System.Drawing.Point(83, 178);
            this.tENMHTextBox.Name = "tENMHTextBox";
            this.tENMHTextBox.Size = new System.Drawing.Size(100, 20);
            this.tENMHTextBox.TabIndex = 24;
            // 
            // sOTIET_LTTextBox
            // 
            this.sOTIET_LTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "SOTIET_LT", true));
            this.sOTIET_LTTextBox.Location = new System.Drawing.Point(83, 204);
            this.sOTIET_LTTextBox.Name = "sOTIET_LTTextBox";
            this.sOTIET_LTTextBox.Size = new System.Drawing.Size(100, 20);
            this.sOTIET_LTTextBox.TabIndex = 25;
            // 
            // sOTIET_THTextBox
            // 
            this.sOTIET_THTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "SOTIET_TH", true));
            this.sOTIET_THTextBox.Location = new System.Drawing.Point(83, 230);
            this.sOTIET_THTextBox.Name = "sOTIET_THTextBox";
            this.sOTIET_THTextBox.Size = new System.Drawing.Size(100, 20);
            this.sOTIET_THTextBox.TabIndex = 26;
            // 
            // mONHOCGridControl1
            // 
            this.mONHOCGridControl1.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl1.Location = new System.Drawing.Point(233, 85);
            this.mONHOCGridControl1.MainView = this.gridView2;
            this.mONHOCGridControl1.MenuManager = this.barManager1;
            this.mONHOCGridControl1.Name = "mONHOCGridControl1";
            this.mONHOCGridControl1.Size = new System.Drawing.Size(759, 220);
            this.mONHOCGridControl1.TabIndex = 38;
            this.mONHOCGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH1,
            this.colTENMH1,
            this.colSOTIET_LT1,
            this.colSOTIET_TH1});
            this.gridView2.GridControl = this.mONHOCGridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colMAMH1
            // 
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 0;
            // 
            // colTENMH1
            // 
            this.colTENMH1.FieldName = "TENMH";
            this.colTENMH1.Name = "colTENMH1";
            this.colTENMH1.Visible = true;
            this.colTENMH1.VisibleIndex = 1;
            // 
            // colSOTIET_LT1
            // 
            this.colSOTIET_LT1.FieldName = "SOTIET_LT";
            this.colSOTIET_LT1.Name = "colSOTIET_LT1";
            this.colSOTIET_LT1.Visible = true;
            this.colSOTIET_LT1.VisibleIndex = 2;
            // 
            // colSOTIET_TH1
            // 
            this.colSOTIET_TH1.FieldName = "SOTIET_TH";
            this.colSOTIET_TH1.Name = "colSOTIET_TH1";
            this.colSOTIET_TH1.Visible = true;
            this.colSOTIET_TH1.VisibleIndex = 3;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 559);
            this.Controls.Add(this.mONHOCGridControl1);
            this.Controls.Add(sOTIET_THLabel);
            this.Controls.Add(this.sOTIET_THTextBox);
            this.Controls.Add(sOTIET_LTLabel);
            this.Controls.Add(this.sOTIET_LTTextBox);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.tENMHTextBox);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.mAMHTextBox);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonHoc";
            this.Text = "Môn học";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVHTCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLOPTINCHIMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonThem;
        private DevExpress.XtraBars.BarButtonItem r;
        private DevExpress.XtraBars.BarButtonItem barButtonGhi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonPhucHoi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonReload;
        private DevExpress.XtraBars.BarButtonItem barButtonLuu;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        //private System.Windows.Forms.BindingSource mONHOCBindingSource;
        //private QLDSV_HTCDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        //private System.Windows.Forms.BindingSource mONHOCBindingSource1;
        private System.Windows.Forms.BindingSource qLDSVHTCDataSetBindingSource;
        private System.Windows.Forms.BindingSource fKLOPTINCHIMONHOCBindingSource;
        private QLDSV_HTCDataSetTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        //private System.Windows.Forms.BindingSource mONHOCBindingSource2;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSV_HTCDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSV_HTCDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.TextBox tENMHTextBox;
        private System.Windows.Forms.TextBox mAMHTextBox;
        private System.Windows.Forms.TextBox sOTIET_THTextBox;
        private System.Windows.Forms.TextBox sOTIET_LTTextBox;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH1;
    }
}