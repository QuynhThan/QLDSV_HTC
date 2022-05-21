using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Forms
{
    public partial class XrptBangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptBangDiemMonHoc()
        {
            InitializeComponent();
        }
        public XrptBangDiemMonHoc(string nk, int hocky, string tenmh, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.Connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = tenmh;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();
        }
    }
}
