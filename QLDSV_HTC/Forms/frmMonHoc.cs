using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DevExpress.XtraGrid;

namespace QLDSV_HTC.Forms
{
    public partial class frmMonHoc : Form
    {
        private string action = "";
        public frmMonHoc()
        {
            InitializeComponent();
           
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.Connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);//roi
            this.pnlMonHoc.Visible = false;
            this.btnThem.Visible = false;
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCGridControl.Enabled = false;
            this.pnlMonHoc.Visible = true;
            this.btnThem.Visible = true;
            this.txtMaMonHoc.Text = "";
            this.txtTenMonHoc.Text = "";
            this.txtSoTietLyThuyet.Text = "";
            this.txtSoTietThucHanh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvMonHoc.AddNewRow();
            gvMonHoc.SetRowCellValue(GridControl.NewItemRowHandle, "MAMH", txtMaMonHoc.Text);
            gvMonHoc.SetRowCellValue(GridControl.NewItemRowHandle, "TENMH", txtTenMonHoc.Text);
            gvMonHoc.SetRowCellValue(GridControl.NewItemRowHandle, "SOTIET_LT", txtSoTietLyThuyet.Text);
            gvMonHoc.SetRowCellValue(GridControl.NewItemRowHandle, "SOTIET_TH", txtSoTietThucHanh.Text);
            txtMaMonHoc.ResetText();
            txtTenMonHoc.ResetText();
            txtSoTietLyThuyet.ResetText();
            txtSoTietThucHanh.ResetText();
            this.mONHOCGridControl.MainView = gvMonHoc;
        }

        private void barButtonGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraDienThongTin())
            {
                MessageBox.Show("Không được để trống thông tin môn học!","",MessageBoxButtons.OK);
                return;
            }
        }
        private Boolean kiemTraDienThongTin()
        {
            if (txtMaMonHoc.Text.Equals("") || txtTenMonHoc.Text.Equals("") || txtSoTietLyThuyet.Text.Equals("") || txtSoTietThucHanh.Text.Equals(""))
            {
                return true;
            }
            return false;
        }
       /* private Boolean kiemTraThongTInMonHoc()
        {

        }*/
    }
}
