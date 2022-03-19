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

        private int positionLop = 0;
        BindingSource bdsLopTemp = new BindingSource();

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
           
            try
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.Connstr;
                
                this.LOPTableAdapter.Fill(this.DS.LOP); 
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Fill data!!" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            
            barBtnLuu.Enabled = barBtnPhucHoi.Enabled = barBtnHuy.Enabled = barBtnGhi.Enabled = false;
            btnAdd.Visible = btnXong.Visible = false;
            grbNhapLop.Enabled = false;

            fillData();
            
            if (bdsLop.Count == 0)
            {
                barBtnXoa.Enabled = false;
            }
            //Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);
            //txtTest.Text = Program.Connstr;

            //PHAN QUYEN TREN DAY
            if (Program.mGroup == Program.quyen[1])
            {
                cmbKhoa.Enabled = false;
            }
          
        }




        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //chuyen site
            Lib.CmbHelper(this.cmbKhoa);


            // khong cho chuyen ve site HOC PHI trong form lớp
            if(cmbKhoa.SelectedItem != cmbKhoa.Items[2])
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Loi ket noi voi server khac!!");
                    this.cmbKhoa.SelectedIndex= Program.MKhoa;
                }
                else
                {
                    fillData();
                }
            }
            /*Console.WriteLine("ten serverchonj: " + cmbKhoa.SelectedValue.ToString() +
               "\nten mkhoa: " + Program.MKhoa + " -- " + cmbKhoa.SelectedIndex);*/
        }

        //         ======================= btn even    ===================
        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //cap nhat barbtn Lop
            barBtnReload.Enabled = barBtnThem.Enabled 
                = barBtnXoa.Enabled = barBtnThoat.Enabled = false;
            barBtnHuy.Enabled = barBtnGhi.Enabled = true;
            btnXong.Visible = true;
            btnAdd.Visible = true;

            cmbKhoa.Enabled = false;
            LOPGridControl.Enabled = false;
            grbNhapLop.Enabled = true;

            //groupBoxNhapLop.Enabled = true;
            bdsLop.AddNew();
            this.txtMaKhoa.Text = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.isFillAllInfoLop())
            {
                return;
            }
            //==========Thêm Lệnh SQL Kiểm Tra Trùng MALOP TENLOP trogn tat ca sites
            if (!checkInfoLop())
            {
                return;
            }
            bdsLop.EndEdit();
            this.bdsLop.ResetCurrentItem();

            Console.WriteLine("bdslopcoount = " + bdsLop.Count + "\nbdsloptemp = " + bdsLopTemp.Count);

            barBtnLuu.Enabled = barBtnPhucHoi.Enabled = true;
            bdsLop.AddNew();
            this.txtMaKhoa.Text = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
        }
        private void btnXong_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() != "" || txtTenLop.Text.Trim() != "" || txtKhoaHoc.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn đã xong ? \nCác thông tin vừa nhập sẽ không được lưu!",
                "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
            }
            //cap nhat barbtn Lop
            barBtnReload.Enabled = barBtnThem.Enabled = barBtnXoa.Enabled = barBtnThoat.Enabled = true;
            barBtnGhi.Enabled = false;
            btnAdd.Visible = btnXong.Visible = false;


            LOPGridControl.Enabled = true;
            grbNhapLop.Enabled = false;


           // bdsLop.CancelEdit();
            bdsLop.RemoveCurrent();
            //bdsLop.CancelEdit();
            //frmLop_Load(sender, e);
            //barBtnHuy.Enabled = false;
        }

        private void barBtnGhi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.isFillAllInfoLop())
            {
                return;
            }
            //==========Thêm Lệnh SQL Kiểm Tra Trùng MALOP TENLOP trogn tat ca sites
            if (!checkInfoLop())
            {
                return;
            }

            // =============================================================================
            if(MessageBox.Show("Bạn có chắc chắn muốn ghi lớp này vô CSDL??","",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                barBtnPhucHoi.Enabled = true;
                try
                {
                    bdsLop.EndEdit();
                    this.bdsLop.ResetCurrentItem();
                    this.LOPTableAdapter.Update(DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi add Lớp vào csdl!!" + ex.Message, "", MessageBoxButtons.OK);

                    return;

                }

                bdsLop.AddNew();
                this.txtMaKhoa.Text = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            }

        }
      
        
        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(barBtnLuu.Enabled == true)
            {
                if(MessageBox.Show("Dữ liệu chưa được lưu!\n Nếu Reload, các hành động vừa rồi sẽ không được lưu lại!\n" +
                    "Bạn có chắc muốn Reload","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
            }
            frmLop_Load(sender, e);
            //fillData();
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() != "" || txtTenLop.Text.Trim() != "" 
                || txtKhoaHoc.Text.Trim() != "" || barBtnLuu.Enabled == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy? \nCác hành động vừa rồi sẽ không được lưu!",
                "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
            }
            //cap nhat barbtn Lop
            barBtnReload.Enabled = barBtnThem.Enabled = barBtnXoa.Enabled = barBtnThoat.Enabled = true;
            barBtnLuu.Enabled = barBtnGhi.Enabled = barBtnHuy.Enabled = false;
            btnXong.Visible = btnAdd.Visible = false;


            if (Program.mGroup == Program.quyen[0]) cmbKhoa.Enabled = true;
            LOPGridControl.Enabled = true;
            grbNhapLop.Enabled = false;


            bdsLop.CancelEdit();
            //frmLop_Load(sender, e);
            fillData();
           // 

        }

        private void barBtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có chăc muốn phục hồi dữ liệu về trạng thái ban đầu", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                barBtnLuu.Enabled = false;
                //cap nhat barbtn Lop
                barBtnReload.Enabled = barBtnThem.Enabled
                    = barBtnXoa.Enabled = barBtnThoat.Enabled = true;
                barBtnHuy.Enabled = barBtnGhi.Enabled =barBtnPhucHoi.Enabled = false;
                btnAdd.Visible = btnXong.Visible = false;

                if (Program.mGroup == Program.quyen[0]) cmbKhoa.Enabled = true;
                LOPGridControl.Enabled = true;
                grbNhapLop.Enabled = false;
                fillData();
                MessageBox.Show("Phục hồi dữ liệu thành công!", "", MessageBoxButtons.OK);
            }
        }


        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string malop = "";
            if(bdsSV.Count != 0)
            {
                MessageBox.Show("Lớp này đã có sinh viên rồi!\n Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?","",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();
                    barBtnPhucHoi.Enabled = true;
                    barBtnLuu.Enabled = true;
                    cmbKhoa.Enabled = false;
                    /*this.LOPTableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.LOPTableAdapter.Update(DS.LOP);*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa LỚP!!\n Vui lòng thử lại!", "", MessageBoxButtons.OK);
                    fillData();
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }
            }
            if (bdsLop.Count == 0) barBtnXoa.Enabled = false;
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // bien luu lai thong tin lop
            string maLopCu = txtMaLop.Text.Trim();
            string tenLopCu = txtTenLop.Text.Trim();
            string khoaHocCu = txtKhoaHoc.Text.Trim();

            //cap nhat barbtn Lop
            barBtnReload.Enabled = barBtnThem.Enabled
                = barBtnXoa.Enabled = barBtnThoat.Enabled = false;
            barBtnHuy.Enabled = barBtnGhi.Enabled = true;

            cmbKhoa.Enabled = false;
            LOPGridControl.Enabled = false;
            grbNhapLop.Enabled = true;



        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(barBtnLuu.Enabled == true)
            {
                if(MessageBox.Show("Dữ liệu chưa được lưu!! \nNếu thoát các thao tác vừa rồi sẽ không được lưu!! \nBạn có chắc chắn muốn thoát???",
                    "",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                  
            }
            this.Close();
        }
        private void barBtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // bool check = true;
            /*if(txtMaLop.Text.Trim() != "" || txtTenLop.Text.Trim() != "" || txtKhoaHoc.Text.Trim() != "")
            {
                if(MessageBox.Show("Thông tin tren box sẽ không được lưu lại!!", "", 
                    MessageBoxButtons.OKCancel) == DialogResult.Cancel) ;
                {
                    return;
                }
            }*/
            if (MessageBox.Show("Bạn có chắc chắn muốn ghi dữ liệu này vô CSDL??", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                barBtnPhucHoi.Enabled = false;
                try
                {
                    //bdsLop.EndEdit();
                    //this.bdsLop.ResetCurrentItem();
                    barBtnLuu.Enabled = false;
                    //cap nhat barbtn Lop
                    barBtnReload.Enabled = barBtnThem.Enabled
                        = barBtnXoa.Enabled = barBtnThoat.Enabled = true;
                    barBtnHuy.Enabled = barBtnGhi.Enabled = false;
                    btnAdd.Visible = btnXong.Visible = false;

                    if (Program.mGroup == Program.quyen[0]) cmbKhoa.Enabled = true;
                    LOPGridControl.Enabled = true;
                    grbNhapLop.Enabled = false;
                    bdsLop.CancelEdit();
                    this.LOPTableAdapter.Update(DS.LOP);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi add Lớp vào csdl!!" + ex.Message, "", MessageBoxButtons.OK);

                    return;

                }
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
        private bool checkInfoLop()
        {
            int check = 0;
            
            string strLenh1 = "EXEC SP_CHECKMALOP '" +txtMaLop.Text +"'";
            check = Lib.checkData(strLenh1);
            if ( check == -1)
            {
                MessageBox.Show("Lỗi kết nối CSDL!", "", MessageBoxButtons.OK);
                return false;
            }
            if (check == 1)
            {
                if (bdsLop.Find("MALOP", txtMaLop.Text) != -1 )
                {
                    //return true;
                    MessageBox.Show("Mã Lớp đã tồn tại trong khoa này!", "", MessageBoxButtons.OK);
                    txtMaLop.Focus();
                    return false;
                }
                
            }
            if(check == 2)
            {
                MessageBox.Show("Mã Lớp đã tồn tại trong khoa khác!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }

            check = bdsLop.Find("MALOP", txtMaLop.Text);
            if(check != -1)
            {
                MessageBox.Show("Mã Lớp đã tồn tại trong khoa này!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            // kiem tra tenlop =========================================
            string strLenh2 = "EXEC SP_CHECKTENLOP N'" + txtTenLop.Text + "'";
            check = Lib.checkData(strLenh2);
            if (check == -1)
            {
                MessageBox.Show("Lỗi kết nối CSDL!", "", MessageBoxButtons.OK);

                return false;
            }
            if (check == 1)
            {
                if (bdsLop.Find("TENLOP", txtTenLop.Text) != -1)
                {
                    MessageBox.Show("Tên Lớp đã tồn tại trong khoa này!", "", MessageBoxButtons.OK);
                    txtTenLop.Focus();

                    return false;
                }
                
            }
            if (check == 2)
            {
                MessageBox.Show("Tên Lớp đã tồn tại trong khoa khác!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();

                return false;
            }
            check = bdsLop.Find("TENLOP", txtTenLop.Text);
            if (check != -1)
            {
                MessageBox.Show("Tên Lớp đã tồn tại trong khoa này!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            
            return true;
        }

        private void bdsLop_CurrentChanged(object sender, EventArgs e)
        {

        }
    }   
}