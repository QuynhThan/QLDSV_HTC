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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {

        private int positionSV = 0;
        private int positionLop = 0;
        private string action = "";
        private string oldMaSV, oldHo, oldTen, oldPassWord,oldDiaChi,oldMaLop= "";
        private string oldNgaySinh;
        private bool oldPhai, oldDaNghiHoc;
        private int thisKhoa = Program.MKhoa;
        Stack<string> unduStack = new Stack<string>();

        //===== bấm undu thì quay lại position cũ=================OKKK
        //===== lỗi chuyển cmbKhoa cả 2 frm đều đổi 
        //===== bắt lỗi nhập họ tên in hoa ký tự đầu sau khoảng trắng (uppercase)//==============OKKKKKK
        //===== bắt lỗi check info sinh vien cho chuc nang edit     ==================== OKKKKKK

        public frmSinhVien()
        {
            InitializeComponent();
        }


        private void loadData()
        {

            

            DS.EnforceConstraints = false;
            try
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.Connstr;
               // this.hOCPHITableAdapter.Connection.ConnectionString = Program.Connstr;

                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.dANGKYTableAdapter.Fill(this.DS.DANGKY);
                //this.hOCPHITableAdapter.Fill(this.DS.HOCPHI);

            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data!!" + e.Message,"LỖI",MessageBoxButtons.OK);
                return;
            }
        }

        private void setBtnEnable(bool kt)
        {
            if (action == "add")
            {
                if (Program.mGroup == Program.quyen[0]) cmbKhoaSV.Enabled = !kt;
                barBtnThem.Enabled = barBtnXoa.Enabled
                    = barBtnSua.Enabled = barBtnReload.Enabled
                    = barBtnThoat.Enabled = gcSinhVien.Enabled
                    = gcLop.Enabled
                    = barBtnPhucHoi.Enabled
                    = !kt;

                barBtnHuy.Enabled = barBtnGhi.Enabled
                    = panelNhapSinhVien.Enabled
                    = btnXong.Visible
                    
                    = kt;
                if (!kt)
                {
                    if (unduStack.Count > 0) barBtnPhucHoi.Enabled = true;
                    if (unduStack.Count == 0) barBtnPhucHoi.Enabled = false;
                }

            }
            if (action == "edit")
            {
                if (Program.mGroup == Program.quyen[0]) cmbKhoaSV.Enabled = !kt;
                barBtnThem.Enabled = barBtnXoa.Enabled
                    = barBtnSua.Enabled = barBtnReload.Enabled
                    = barBtnThoat.Enabled = gcSinhVien.Enabled
                    = barBtnPhucHoi.Enabled
                    = gcLop.Enabled
                    = !kt;
                barBtnHuy.Enabled = barBtnGhi.Enabled
                    = panelNhapSinhVien.Enabled
                    = panelDaNghiHoc.Enabled
                    = kt;
                if (!kt)
                {
                    if (unduStack.Count > 0) barBtnPhucHoi.Enabled = true;
                    if (unduStack.Count == 0) barBtnPhucHoi.Enabled = false;
                }
            }
        }


        private void cmbKhoaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoaSV.SelectedIndex != thisKhoa) 
            {
                if (unduStack.Count > 0)
                {
                    if (MessageBox.Show("Chuyển khoa sẽ không thể phục hồi lại!!\nBạn có muốn chuyển khoa??", "frmSinhVien", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        this.cmbKhoaSV.SelectedIndex = thisKhoa;
                        return;
                    }
                    else
                    {
                        unduStack.Clear();
                        barBtnPhucHoi.Enabled = false;
                    }
                }
                if(!barBtnThem.Enabled || !barBtnSua.Enabled)
                {
                    if (action == "add")
                        bdsSinhVien.RemoveCurrent();
                    if (action == "edit")
                        bdsSinhVien.CancelEdit();
                    setBtnEnable(false);
                }
                thisKhoa = this.cmbKhoaSV.SelectedIndex;
                //chuyen site
                Lib.CmbHelper(this.cmbKhoaSV);
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi Kết Nỗi Với Server Khác!!", "LỖI", MessageBoxButtons.OK);
                    this.cmbKhoaSV.SelectedIndex = Program.MKhoa;
                }
                else
                {
                    loadData();
                    barBtnXoa.Enabled = barBtnSua.Enabled = bdsSinhVien.Count > 0;
                }
            }
        }


        
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            
            loadData();
            if (bdsSinhVien.Count == 0)
            {
                barBtnXoa.Enabled = false;
            }
           // DataTable dt = Program.bds_dspm.DataSource as DataTable;
            Lib.BDataToCmb(this.cmbKhoaSV, Program.bds_dspm.DataSource);

            //PHAN QUYEN TREN DAY
            if (Program.mGroup == Program.quyen[0])
            {
                Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";

            }

            if (Program.mGroup == Program.quyen[1])
            {
                //Program.bds_dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
                cmbKhoaSV.Enabled = false;
            }
        }

     ///===============================    button even=============================
        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionLop = bdsLop.Position;
            positionSV = bdsSinhVien.Position;


            action = "add";
            setBtnEnable(true);
            bdsSinhVien.AddNew();
            chkDaNghiHoc.Checked = false;
            chkPhai.Checked = false;
            txtMaSV.Focus();
        }

       

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() != "" || txtHo.Text.Trim() != "" || txtTen.Text.Trim() != "" || txtPassword.Text.Trim() != "" || txtDiaChi.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn đã xong ? \nCác thông tin vừa nhập sẽ không được lưu!",
                "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
            }

            bdsSinhVien.RemoveCurrent();
            setBtnEnable(false);
            bdsSinhVien.Position = positionSV;
            bdsLop.Position = positionLop;
        }


        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.isFillAllInfoSinhVien())
            {
                return;
            }
            // set password mặc định  = 123
            if (txtPassword.Text.Trim() == "")
            {
                if (MessageBox.Show("Mật khẩu chưa có!\nBạn có muốn đặt thành mật khẩu mặc định??('123')","",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                txtPassword.Text = "123";
            }
            //==========Thêm Lệnh SQL Kiểm Tra Trùng MASV trogn tat ca sites
            if (!checkInfoSinhVien())
            {
                return;
            }
            string message = "";
            if (action == "add") message = "Bạn có chắc chắn muốn ghi Sinh Viên này vô CSDL??";
            if (action == "edit") message = "Bạn có chắc muốn lưu thay đổi???";
            // =============================================================================
            if (MessageBox.Show(message, "",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsSinhVien.EndEdit();
                    this.bdsSinhVien.ResetCurrentItem();
                    this.sINHVIENTableAdapter.Update(DS.SINHVIEN);
                    if (action == "add")
                    {
                        unduStack.Push(String.Format("DELETE FROM SINHVIEN WHERE MASV='{0}' "+positionLop +","+ positionSV, txtMaSV.Text.Trim()));
                    }
                    if (action == "edit")
                    {
                        unduStack.Push(String.Format("UPDATE SINHVIEN SET " +
                            "MASV = N'{0}', HO = N'{1}', TEN = N'{2}', PHAI = '{3}', DIACHI = N'{4}', NGAYSINH = '{5}', MALOP = '{6}', DANGHIHOC = '{7}',PASSWORD = N'{8}' WHERE MASV = N'{9}' " + positionLop +","+ positionSV,
                            oldMaSV, oldHo,oldTen,oldPhai,oldDiaChi,oldNgaySinh.ToString().Trim(),oldMaLop,oldDaNghiHoc,oldPassWord,txtMaSV.Text.Trim()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi add Sinh Viên vào csdl!!" + ex.Message, "", MessageBoxButtons.OK);

                    return;

                }
                if (action == "add")
                {
                    //tiep tuc thao tac them
                    bdsSinhVien.AddNew();
                    chkDaNghiHoc.Checked = false;
                    chkPhai.Checked = false;
                }
                if (action == "edit")
                {
                    setBtnEnable(false);

                    bdsSinhVien.Position = positionSV;
                    bdsLop.Position = positionLop;
                    //
                }
            }
        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oldMaSV = txtMaSV.Text.Trim();
            oldHo = txtHo.Text.Trim();
            oldTen = txtTen.Text.Trim();
            oldDiaChi = txtDiaChi.Text.Trim();
            oldPassWord = txtPassword.Text.Trim();
            oldMaLop = txtMalop.Text.Trim();
            oldNgaySinh = dateNgaySinh.DateTime.ToString("yyyy/MM/dd");
            oldPhai = chkPhai.Checked;
            oldDaNghiHoc = chkDaNghiHoc.Checked;
            positionLop = bdsLop.Position;
            positionSV = bdsSinhVien.Position;

            action = "edit";
            setBtnEnable(true);
        }


        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDangKy.Count != 0)
            {
                MessageBox.Show("Sinh viên này đã đăng ký lớp tín chỉ rồi!\n Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            //Dang ky roi moi co hoc phi ---> ko can ktra học phí -->thi nhớ xóa bdsHocPhi
           /* if (bdsHocPhi.Count != 0)
            {
                MessageBox.Show("Sinh viên này đã có học phí rồi!\n Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Sinh Viên này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    oldMaSV = txtMaSV.Text.Trim();
                    oldHo = txtHo.Text.Trim();
                    oldTen = txtTen.Text.Trim();
                    oldDiaChi = txtDiaChi.Text.Trim();
                    oldPassWord = txtPassword.Text.Trim();
                    oldMaLop = txtMalop.Text.Trim();
                    oldNgaySinh = dateNgaySinh.DateTime.ToString("yyyy/MM/dd");
                    oldPhai = chkPhai.Checked;
                    oldDaNghiHoc = chkDaNghiHoc.Checked;

                    positionSV = bdsSinhVien.Position;
                    positionLop = bdsLop.Position;

                    bdsSinhVien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.sINHVIENTableAdapter.Update(DS.SINHVIEN);
                    unduStack.Push(string.Format("INSERT INTO SINHVIEN(MASV,HO,TEN,PHAI,DIACHI,NGAYSINH,MALOP,DANGHIHOC,PASSWORD) " +
                            "VALUES(N'{0}',N'{1}',N'{2}','{3}',N'{4}','{5}','{6}','{7}',N'{8}') "+positionLop+","+positionSV, 
                            oldMaSV,oldHo,oldTen,oldPhai,oldDiaChi,oldNgaySinh,oldMaLop,oldDaNghiHoc,oldPassWord));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa SINH VIÊN!!\n Vui lòng thử lại!\n" + ex.Message, "LỖI", MessageBoxButtons.OK);
                    loadData();
                    bdsSinhVien.Position = positionSV;
                    return;
                }
            }
            if (bdsSinhVien.Count == 0) barBtnXoa.Enabled = false;
            if (unduStack.Count == 0) barBtnPhucHoi.Enabled = false;
            if (unduStack.Count > 0) barBtnPhucHoi.Enabled = true;

        }

       
        //  bắt lỗi Nhập liệu họ tên sinh viên
        private void txtHo_EditValueChanged(object sender, EventArgs e)
        {
            //txtHo.Properties.CharacterCasing = CharacterCasing.Upper;
            txtHo.Text = Lib.ToCapitalize(txtHo.Text.Trim());
        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {
            //txtTen.Properties.CharacterCasing = CharacterCasing.Upper;
            txtTen.Text = Lib.ToCapitalize(txtTen.Text.Trim());
        }
        private void txtDiaChi_EditValueChanged(object sender, EventArgs e)
        {
            txtDiaChi.Text = Lib.ToCapitalize(txtDiaChi.Text.Trim());
        }
        private void gvDSLop_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            barBtnXoa.Enabled = barBtnSua.Enabled = bdsSinhVien.Count > 0;
        }

        //          =======================                                     //
        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            positionLop = bdsLop.Position;
            positionSV = bdsSinhVien.Position;
            loadData();
            bdsLop.Position = positionLop;
            bdsSinhVien.Position = positionSV;
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            //txtPassword.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
            txtPassword.Properties.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() != "" || txtHo.Text.Trim() != "" || txtTen.Text.Trim() != "" || txtPassword.Text.Trim() != "" || txtDiaChi.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn đã xong ? \nCác thông tin vừa nhập sẽ không được lưu!",
                "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (action == "add")
                bdsSinhVien.RemoveCurrent();
            if (action == "edit")
                bdsSinhVien.CancelEdit();
            setBtnEnable(false);
            bdsSinhVien.Position = positionSV;
            bdsLop.Position = positionLop;
        }
        private void barBtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cmd = unduStack.Pop();
            SplitPositionFromStack(ref cmd);
            int kt = Program.ExecSqlNonQuery(cmd);
            if(kt != 0)
            {
                MessageBox.Show("Phục hồi thất bại!!","LỖI",MessageBoxButtons.OK);
            }
            loadData();
            bdsLop.Position = positionLop;
            bdsSinhVien.Position = positionSV;
            if (unduStack.Count == 0) barBtnPhucHoi.Enabled = false;
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (unduStack.Count > 0 && MessageBox.Show("Thoát sẽ không thể phục hồi lại!!\nBạn có muốn thoát??", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                //this.cmbKhoa.SelectedIndex = thisKhoa;
                return;
            }
            this.Close();
        }


        // ================= HÀM HỖ TRỢ ==================================//
        private bool isFillAllInfoSinhVien()
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã Sinh Viên không được bỏ trống!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được bỏ trống!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được bỏ trống!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }
            
            return true;
        }
        private bool checkInfoSinhVien()
        {
            // check do dai
            if (txtMaSV.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã Sinh Viên tối đa 10 kí tự!!!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            if (txtHo.Text.Trim().Length > 50)
            {
                MessageBox.Show("Họ tối đa 50 kí tự!!!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }
            if (txtTen.Text.Trim().Length > 10)
            {
                MessageBox.Show("Tên tối đa 10 kí tự!!!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim().Length > 100)
            {
                MessageBox.Show("Địa chỉ tối đa 100 kí tự!!!", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            Console.WriteLine(Convert.ToInt32(DateTime.Now.Year.ToString().Trim()) - Convert.ToInt32(dateNgaySinh.DateTime.Year.ToString().Trim()));
            if( Convert.ToInt32(DateTime.Now.Year.ToString().Trim()) - Convert.ToInt32(dateNgaySinh.DateTime.Year.ToString().Trim()) < 18)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!!\nTuổi > 20", "", MessageBoxButtons.OK);
                dateNgaySinh.Focus();
                return false;
            }

            ///===kiem tra masv co trùng ko
            if(action == "edit" && txtMaSV.Text.Trim() == oldMaSV)
            {

                return true;
            }
            
            string strLenh1 = "EXEC SP_CHECKMASINHVIEN '" + txtMaSV.Text.Trim() + "'";
            int check = Lib.checkData(strLenh1);
            if (check == -1)
            {
                MessageBox.Show("Lỗi kết nối CSDL!", "", MessageBoxButtons.OK);
                return false;
            }
            if (check == 1)
            {

                MessageBox.Show("Mã Sinh Viên đã tồn tại trong khoa này!!!","",MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;

            }
            if (check == 2)
            {
                MessageBox.Show("Mã Sinh Viên đã tồn tại trong khoa khác!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            return true;
        }

        private void SplitPositionFromStack(ref string str)
        {
            //int po = Convert.ToInt32(str.Substring(str.LastIndexOf(" ")));
            string[] pos= str.Substring(str.LastIndexOf(" ")).Split(',');
            positionLop = Convert.ToInt32(pos[0]);
            positionSV = Convert.ToInt32(pos[1]);
            str = str.Substring(0, str.LastIndexOf(" "));
        }
    }
}