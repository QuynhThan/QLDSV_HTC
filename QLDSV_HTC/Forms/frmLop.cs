using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        public frmLop()
        {
            InitializeComponent();
        }
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }
        private void fillData()
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.Connstr;

            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.Connstr;
            
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            this.LOPTableAdapter.Fill(this.DS.LOP); 
           
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            barBtnHuy.Enabled = false;
            btnAdd.Visible = false;
            fillData();

            //Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);
            //txtTest.Text = Program.Connstr;

            //PHAN QUYEN TREN DAY
            if (Program.mGroup == Program.quyen[1])
            {
                cmbKhoa.Enabled = false;
            }

        }



        private void gcLop_Click(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chuyen site
            Lib.CmbHelper(this.cmbKhoa);

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Loi ket noi voi server khac!!");
                this.cmbKhoa.SelectedItem = Program.MKhoa;
            }
            else
            {
                fillData();
            }
               Console.WriteLine("ten serverchonj: " + cmbKhoa.SelectedValue.ToString() + 
                  "\nten mkhoa: " + Program.MKhoa + " -- " + cmbKhoa.SelectedIndex);
        }

        //         ======================= btn even    ===================
        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //cap nhat barbtn Lop
            barBtnThem.Enabled = barBtnXoa.Enabled = barBtnThoat.Enabled = false;
            barBtnHuy.Enabled = btnAdd.Visible = true;
            
            cmbKhoa.Enabled = false;
            LOPGridControl.Enabled = false;

            //groupBoxNhapLop.Enabled = true;
            bdsLop.AddNew();
            this.txtMaKhoa.Text = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.isFillAllInfoLop() )
            {
                return;
            }
            //==========Thêm Lệnh SQL Kiểm Tra Trùng MALOP TENLOP trogn cả 2 sites




            bdsLop.EndEdit();
            bdsLop.AddNew();
            this.txtMaKhoa.Text = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();

        }

        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLop_Load(sender, e);
            //fillData();
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = true;
            if( txtMaLop.Text.Trim() != "" || txtTenLop.Text.Trim() != "" || txtKhoaHoc.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy? \nCác thông tin vừa nhập sẽ không được lưu!",
                "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    check = false;
                }
            }
            if (check)
            {
                //cap nhat barbtn Lop
                barBtnThem.Enabled = barBtnXoa.Enabled = barBtnThoat.Enabled = true;
                btnAdd.Visible = false;

                cmbKhoa.Enabled = true;
                LOPGridControl.Enabled = true;

                bdsLop.CancelEdit();
                frmLop_Load(sender, e);
                barBtnHuy.Enabled = false;
            }

        }


        //============Ham ho tro==================

        //kiem tra thong tin txt da diem du thong tin chua
        private Boolean isFillAllInfoLop()
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được bỏ trống!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được bỏ trống!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            if (txtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được bỏ trống!", "", MessageBoxButtons.OK);
                txtKhoaHoc.Focus();
                return false;
            }
            return true;
        }
    }
}