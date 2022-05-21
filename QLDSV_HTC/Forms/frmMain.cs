using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QLDSV_HTC.Forms;
using QLDSV_HTC.ReportsForms;
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
            /*Lib.BDataToCmb(this.cmbKhoaSV, Program.bds_dspm.DataSource);

            //PHAN QUYEN TREN DAY
            if (Program.mGroup == Program.quyen[0])
            {
                Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";

            }

            if (Program.mGroup == Program.quyen[1])
            {
                //Program.bds_dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
                cmbKhoaSV.Enabled = false;
            }*/

        }
        // TODO : HANDLE CONTROL CHILDREN
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }
        private void barButtonItemDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Program.frmMain.Close();
            Program.frmMain = new frmMain();
            Program.frmMain.Show();*/
            // Dong tat ca cac frm con dang open
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Program.bds_dspm.RemoveFilter();
            Program.ServerName = Program.frmDangNhap.cmbKhoa.SelectedValue.ToString();
            Program.frmMain.Enabled = false;

            Program.frmDangNhap.Visible = true;
        }

        private void barButtonItemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                ShowMdiChildren(typeof(frmLop));
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barBtnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmSinhVien));
        }

        private void barBtnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmMonHoc));
        }

        private void barBtnDangKyLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDangKyLTC));


        }

        private void barBtnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmTaoLogin));
        }

        private void barBtnDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frpt_DSLTC_NK_HK));
        }



        private void barBtnDSSV_DKLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frpt_DSSV_DANGKY_LTC));
        }
        private void barBtnLopTinChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmLopTinChi));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmBaoCaoBangDiem));
        }

        private void btnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmBaoCaoPhieuDiem));
        }
    }
}
