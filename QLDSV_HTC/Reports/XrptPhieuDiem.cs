using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Forms
{
    public partial class XrptPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptPhieuDiem()
        {
            InitializeComponent();
        }
        public XrptPhieuDiem(string masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.Connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Fill();
        }
    }
}
