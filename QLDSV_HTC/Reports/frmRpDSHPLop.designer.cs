
namespace QLDSV_HTC.Forms
{
    partial class frmRpDSHPLop
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRpDSHPLop));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrlbGV = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbKhoa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbMaLop = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrlbTongTienSTR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbTongTienINT_Sum = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbTongSV_sum = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbTongTienDD = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbTongSV = new DevExpress.XtraReports.UI.XRLabel();
            this.tableDSHPLop = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tbDSHPLop_clHoTen = new DevExpress.XtraReports.UI.XRTableCell();
            this.tbDSHPLop_clHP = new DevExpress.XtraReports.UI.XRTableCell();
            this.tbDSHPLop_clTongTien = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrlbNguoiLap = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDSHPLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV_HTCConnectionString4";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_DSHPLOP";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D15CQCP01 ";
            queryParameter2.Name = "@NIENKHOA";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "2021-2022";
            queryParameter3.Name = "@HOCKY";
            queryParameter3.Type = typeof(int);
            queryParameter3.ValueInfo = "1";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.StoredProcName = "SP_DSHPLOP";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(5F, 5F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(315F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(330F, 5F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(315F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlbKhoa,
            this.xrlbMaLop,
            this.label1});
            this.ReportHeader.HeightF = 110.5F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrlbGV
            // 
            this.xrlbGV.LocationFloat = new DevExpress.Utils.PointFloat(397.4999F, 47.00002F);
            this.xrlbGV.Multiline = true;
            this.xrlbGV.Name = "xrlbGV";
            this.xrlbGV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbGV.SizeF = new System.Drawing.SizeF(179.1667F, 22.99999F);
            this.xrlbGV.StylePriority.UseTextAlignment = false;
            this.xrlbGV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlbKhoa
            // 
            this.xrlbKhoa.LocationFloat = new DevExpress.Utils.PointFloat(5F, 52.19434F);
            this.xrlbKhoa.Multiline = true;
            this.xrlbKhoa.Name = "xrlbKhoa";
            this.xrlbKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbKhoa.SizeF = new System.Drawing.SizeF(640F, 23F);
            this.xrlbKhoa.StylePriority.UseTextAlignment = false;
            this.xrlbKhoa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlbMaLop
            // 
            this.xrlbMaLop.LocationFloat = new DevExpress.Utils.PointFloat(5.000025F, 29.19434F);
            this.xrlbMaLop.Multiline = true;
            this.xrlbMaLop.Name = "xrlbMaLop";
            this.xrlbMaLop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbMaLop.SizeF = new System.Drawing.SizeF(640F, 23F);
            this.xrlbMaLop.StylePriority.UseTextAlignment = false;
            this.xrlbMaLop.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(5F, 5F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(640F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "DANH SÁCH SINH VIÊN ĐÓNG HỌC PHÍ";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 28F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(650F, 28F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell1
            // 
            this.tableCell1.BackColor = System.Drawing.Color.White;
            this.tableCell1.BorderColor = System.Drawing.Color.Black;
            this.tableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell1.ForeColor = System.Drawing.Color.Black;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "DetailCaption1";
            this.tableCell1.StylePriority.UseBackColor = false;
            this.tableCell1.StylePriority.UseBorderColor = false;
            this.tableCell1.StylePriority.UseBorders = false;
            this.tableCell1.StylePriority.UseForeColor = false;
            this.tableCell1.StylePriority.UseTextAlignment = false;
            this.tableCell1.Text = "Họ và Tên";
            this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell1.Weight = 0.38164813440085754D;
            // 
            // tableCell2
            // 
            this.tableCell2.BackColor = System.Drawing.Color.White;
            this.tableCell2.BorderColor = System.Drawing.Color.Black;
            this.tableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell2.ForeColor = System.Drawing.Color.Black;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "DetailCaption1";
            this.tableCell2.StylePriority.UseBackColor = false;
            this.tableCell2.StylePriority.UseBorderColor = false;
            this.tableCell2.StylePriority.UseBorders = false;
            this.tableCell2.StylePriority.UseForeColor = false;
            this.tableCell2.StylePriority.UseTextAlignment = false;
            this.tableCell2.Text = "Học phí";
            this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell2.Weight = 0.3175374169584777D;
            // 
            // tableCell3
            // 
            this.tableCell3.BackColor = System.Drawing.Color.White;
            this.tableCell3.BorderColor = System.Drawing.Color.Black;
            this.tableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell3.ForeColor = System.Drawing.Color.Black;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "DetailCaption1";
            this.tableCell3.StylePriority.UseBackColor = false;
            this.tableCell3.StylePriority.UseBorderColor = false;
            this.tableCell3.StylePriority.UseBorders = false;
            this.tableCell3.StylePriority.UseForeColor = false;
            this.tableCell3.StylePriority.UseTextAlignment = false;
            this.tableCell3.Text = "Tổng số tiền đã đóng";
            this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell3.Weight = 0.30081442516560464D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlbTongTienSTR,
            this.xrlbTongTienINT_Sum,
            this.xrlbTongSV_sum,
            this.xrlbTongTienDD,
            this.xrlbTongSV,
            this.tableDSHPLop});
            this.Detail.HeightF = 100.5F;
            this.Detail.Name = "Detail";
            // 
            // xrlbTongTienSTR
            // 
            this.xrlbTongTienSTR.LocationFloat = new DevExpress.Utils.PointFloat(219.1667F, 77.5F);
            this.xrlbTongTienSTR.Multiline = true;
            this.xrlbTongTienSTR.Name = "xrlbTongTienSTR";
            this.xrlbTongTienSTR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbTongTienSTR.SizeF = new System.Drawing.SizeF(170.2621F, 23F);
            this.xrlbTongTienSTR.StylePriority.UseTextAlignment = false;
            this.xrlbTongTienSTR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrlbTongTienSTR.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrlbTongTienSTR_PrintOnPage);
            // 
            // xrlbTongTienINT_Sum
            // 
            this.xrlbTongTienINT_Sum.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Tổng số tiền đã đóng])")});
            this.xrlbTongTienINT_Sum.LocationFloat = new DevExpress.Utils.PointFloat(136.6667F, 77.5F);
            this.xrlbTongTienINT_Sum.Multiline = true;
            this.xrlbTongTienINT_Sum.Name = "xrlbTongTienINT_Sum";
            this.xrlbTongTienINT_Sum.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbTongTienINT_Sum.SizeF = new System.Drawing.SizeF(82.49995F, 23F);
            this.xrlbTongTienINT_Sum.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrlbTongTienINT_Sum.Summary = xrSummary1;
            this.xrlbTongTienINT_Sum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrlbTongTienINT_Sum.TextFormatString = "{0:c0}";
            this.xrlbTongTienINT_Sum.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrlbTongTienINT_Sum_PrintOnPage);
            // 
            // xrlbTongSV_sum
            // 
            this.xrlbTongSV_sum.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([Họ và Tên])")});
            this.xrlbTongSV_sum.LocationFloat = new DevExpress.Utils.PointFloat(119.1667F, 49.16667F);
            this.xrlbTongSV_sum.Multiline = true;
            this.xrlbTongSV_sum.Name = "xrlbTongSV_sum";
            this.xrlbTongSV_sum.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbTongSV_sum.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrlbTongSV_sum.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrlbTongSV_sum.Summary = xrSummary2;
            this.xrlbTongSV_sum.Text = "xrlbTongSV_sum";
            this.xrlbTongSV_sum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbTongTienDD
            // 
            this.xrlbTongTienDD.LocationFloat = new DevExpress.Utils.PointFloat(0F, 77.5F);
            this.xrlbTongTienDD.Multiline = true;
            this.xrlbTongTienDD.Name = "xrlbTongTienDD";
            this.xrlbTongTienDD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbTongTienDD.SizeF = new System.Drawing.SizeF(136.6667F, 23F);
            this.xrlbTongTienDD.StylePriority.UseTextAlignment = false;
            this.xrlbTongTienDD.Text = "Tổng số tiền đã đóng: ";
            this.xrlbTongTienDD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbTongSV
            // 
            this.xrlbTongSV.LocationFloat = new DevExpress.Utils.PointFloat(0F, 49.16667F);
            this.xrlbTongSV.Multiline = true;
            this.xrlbTongSV.Name = "xrlbTongSV";
            this.xrlbTongSV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbTongSV.SizeF = new System.Drawing.SizeF(119.1667F, 23F);
            this.xrlbTongSV.StylePriority.UseTextAlignment = false;
            this.xrlbTongSV.Text = "Tổng số sinh viên:";
            this.xrlbTongSV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // tableDSHPLop
            // 
            this.tableDSHPLop.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tableDSHPLop.Name = "tableDSHPLop";
            this.tableDSHPLop.OddStyleName = "DetailData3_Odd";
            this.tableDSHPLop.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.tableDSHPLop.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tbDSHPLop_clHoTen,
            this.tbDSHPLop_clHP,
            this.tbDSHPLop_clTongTien});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // tbDSHPLop_clHoTen
            // 
            this.tbDSHPLop_clHoTen.BorderColor = System.Drawing.Color.Black;
            this.tbDSHPLop_clHoTen.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tbDSHPLop_clHoTen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Họ và Tên]")});
            this.tbDSHPLop_clHoTen.Name = "tbDSHPLop_clHoTen";
            this.tbDSHPLop_clHoTen.StyleName = "DetailData1";
            this.tbDSHPLop_clHoTen.StylePriority.UseBorderColor = false;
            this.tbDSHPLop_clHoTen.StylePriority.UseBorders = false;
            this.tbDSHPLop_clHoTen.StylePriority.UseTextAlignment = false;
            this.tbDSHPLop_clHoTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tbDSHPLop_clHoTen.Weight = 0.38164813440085754D;
            // 
            // tbDSHPLop_clHP
            // 
            this.tbDSHPLop_clHP.BorderColor = System.Drawing.Color.Black;
            this.tbDSHPLop_clHP.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tbDSHPLop_clHP.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Học phí]")});
            this.tbDSHPLop_clHP.Name = "tbDSHPLop_clHP";
            this.tbDSHPLop_clHP.StyleName = "DetailData1";
            this.tbDSHPLop_clHP.StylePriority.UseBorderColor = false;
            this.tbDSHPLop_clHP.StylePriority.UseBorders = false;
            this.tbDSHPLop_clHP.StylePriority.UseTextAlignment = false;
            this.tbDSHPLop_clHP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tbDSHPLop_clHP.Weight = 0.3175374169584777D;
            // 
            // tbDSHPLop_clTongTien
            // 
            this.tbDSHPLop_clTongTien.BorderColor = System.Drawing.Color.Black;
            this.tbDSHPLop_clTongTien.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tbDSHPLop_clTongTien.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tổng số tiền đã đóng]")});
            this.tbDSHPLop_clTongTien.Name = "tbDSHPLop_clTongTien";
            this.tbDSHPLop_clTongTien.StyleName = "DetailData1";
            this.tbDSHPLop_clTongTien.StylePriority.UseBorderColor = false;
            this.tbDSHPLop_clTongTien.StylePriority.UseBorders = false;
            this.tbDSHPLop_clTongTien.StylePriority.UseTextAlignment = false;
            this.tbDSHPLop_clTongTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tbDSHPLop_clTongTien.Weight = 0.30081442516560464D;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlbNguoiLap,
            this.xrlbGV});
            this.PageFooter.Name = "PageFooter";
            // 
            // xrlbNguoiLap
            // 
            this.xrlbNguoiLap.LocationFloat = new DevExpress.Utils.PointFloat(422.5F, 10F);
            this.xrlbNguoiLap.Multiline = true;
            this.xrlbNguoiLap.Name = "xrlbNguoiLap";
            this.xrlbNguoiLap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbNguoiLap.SizeF = new System.Drawing.SizeF(135.8333F, 23F);
            this.xrlbNguoiLap.StylePriority.UseTextAlignment = false;
            this.xrlbNguoiLap.Text = "NGƯỜI LẬP BẢNG";
            this.xrlbNguoiLap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // frmRpDSHPLop
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "SP_DSHPLOP";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDSHPLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable tableDSHPLop;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tbDSHPLop_clHoTen;
        private DevExpress.XtraReports.UI.XRTableCell tbDSHPLop_clHP;
        private DevExpress.XtraReports.UI.XRTableCell tbDSHPLop_clTongTien;
        private DevExpress.XtraReports.UI.XRLabel xrlbKhoa;
        private DevExpress.XtraReports.UI.XRLabel xrlbMaLop;
        private DevExpress.XtraReports.UI.XRLabel xrlbTongTienINT_Sum;
        private DevExpress.XtraReports.UI.XRLabel xrlbTongSV_sum;
        private DevExpress.XtraReports.UI.XRLabel xrlbTongTienDD;
        private DevExpress.XtraReports.UI.XRLabel xrlbTongSV;
        private DevExpress.XtraReports.UI.XRLabel xrlbTongTienSTR;
        private DevExpress.XtraReports.UI.XRLabel xrlbGV;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrlbNguoiLap;
    }
}
