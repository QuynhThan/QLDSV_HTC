using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Forms
{
    public partial class frmRpDSHPLop : DevExpress.XtraReports.UI.XtraReport
    {
        string Tong = "";
        public frmRpDSHPLop()
        {
            //InitializeComponent();
        }
        public frmRpDSHPLop(string GV,string KHOA,string MALOP,string NK, int HK)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.Connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MALOP;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = NK;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = HK;
            xrlbMaLop.Text = "MÃ LỚP: " + MALOP;
            xrlbKhoa.Text = "KHOA: " + KHOA;
            xrlbGV.Text = GV;
        }


        private void xrlbTongTienINT_Sum_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Tong = xrlbTongTienINT_Sum.Text;
        }

        private void xrlbTongTienSTR_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Tong = Tong.Replace("$",string.Empty);
            Tong = Tong.Replace(",",string.Empty);
            xrlbTongTienSTR.Text ="(" +  Lib.NumberToText( int.Parse(Tong)) + ")";
        }


    }
}
