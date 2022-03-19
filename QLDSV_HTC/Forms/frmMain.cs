﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QLDSV_HTC.Forms;
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
    }
}