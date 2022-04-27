using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Reports
{
    public partial class xrpt_DSSV_DANGKY_LTC : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_DSSV_DANGKY_LTC()
        {
            //InitializeComponent();
        }
        public xrpt_DSSV_DANGKY_LTC(string nk, int hk, string monhoc, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.Connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hk;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = monhoc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();
        }
    }
}
