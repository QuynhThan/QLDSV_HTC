using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
 
        }

        private void barButtonItemDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Program.frmMain.Close();
            Program.frmMain = new frmMain();
            Program.frmMain.Show();*/
            Program.frmMain.Enabled = false;

            Program.frmDangNhap.Visible = true;
        }


    }
}
