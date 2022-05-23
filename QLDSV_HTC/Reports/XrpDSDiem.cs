using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Forms
{
    public partial class XrpDSDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XrpDSDiem()
        {
            //InitializeComponent();
        }
        public XrpDSDiem(String KHOA, string MALOP,string KH, string GV)
        {
            InitializeComponent();
            xrlbKhoa.Text = "KHOA: " + KHOA;
            xrlbGV.Text =  GV;
            xrlbLop_KhoaHoc.Text = "LỚP: " + MALOP + " - KHÓA HỌC: " + KH;
            this.sqlDataSource1.Connection.ConnectionString = Program.Connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MALOP;
        }

    }
}
