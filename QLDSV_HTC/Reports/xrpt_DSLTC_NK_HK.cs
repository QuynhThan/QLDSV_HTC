using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC
{
    public partial class xrpt_DSLTC_NK_HK : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_DSLTC_NK_HK()
        {
            
        }
        public xrpt_DSLTC_NK_HK(string NK, int HK)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.Connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = NK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = HK;
            this.sqlDataSource1.Fill();
        }

    }
}
