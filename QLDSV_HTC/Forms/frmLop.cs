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
        private string action = "";
        private string oldMaLop, oldTenLop, oldKhoaHoc, oldMaKhoa = "";
        private int thisKhoa = Program.MKhoa;

        Stack<string> unduStack = new Stack<string>();
        public frmLop()
        {
            InitializeComponent();
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
            fillData();
            
            if (bdsLop.Count == 0)
            {
                barBtnXoa.Enabled = false;
            }
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);

            //PHAN QUYEN TREN DAY
            if(Program.mGroup == Program.quyen[0])
            {
                Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";

            }

            if (Program.mGroup == Program.quyen[1])
            {
                //Program.bds_dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
                cmbKhoa.Enabled = false;
            }
          
        }


        private void setBtnEnable(bool kt)
        {
            if(action == "add")
            {
                if (Program.mGroup == Program.quyen[0]) cmbKhoa.Enabled = !kt;
                barBtnThem.Enabled = barBtnXoa.Enabled
                    = barBtnSua.Enabled = barBtnReload.Enabled
                    = barBtnThoat.Enabled =gcLop.Enabled
                    = barBtnPhucHoi.Enabled 
                    = !kt;

                barBtnHuy.Enabled = barBtnGhi.Enabled
                    = grbNhapLop.Enabled =btnXong.Visible 
                    = kt;
                if (!kt)
                {
                    if (unduStack.Count > 0) barBtnPhucHoi.Enabled = true;
                    if (unduStack.Count == 0) barBtnPhucHoi.Enabled = false;
                }

            }
            if (action == "edit")
            {
                if (Program.mGroup == Program.quyen[0]) cmbKhoa.Enabled = !kt;
                barBtnThem.Enabled = barBtnXoa.Enabled
                    = barBtnSua.Enabled = barBtnReload.Enabled
                    = barBtnThoat.Enabled = gcLop.Enabled
                    = barBtnPhucHoi.Enabled 
                    = !kt;
                barBtnHuy.Enabled = barBtnGhi.Enabled
                    = grbNhapLop.Enabled 
                    = kt;
                if (!kt)
                {
                    if (unduStack.Count > 0) barBtnPhucHoi.Enabled = true;
                    if (unduStack.Count == 0) barBtnPhucHoi.Enabled = false;
                }
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoa.SelectedIndex != thisKhoa)
            {
                if (!barBtnThem.Enabled || !barBtnSua.Enabled)
                {
                    if (txtMaLop.Text.Trim() != "" || txtTenLop.Text.Trim() != ""
                        || txtKhoaHoc.Text.Trim() != "")
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn chuyển khoa?\nCác thông tin vừa nhập sẽ không được lưu!",
                        "frmLop", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    setBtnEnable(false);
                    if (action == "add")
                        bdsLop.RemoveCurrent();
                    if (action == "edit")
                        bdsLop.CancelEdit();
                }
                if (unduStack.Count > 0)
                {
                    if (MessageBox.Show("Chuyển khoa sẽ không thể phục hồi lại!!\nBạn có muốn chuyển khoa??", "frmLop", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        this.cmbKhoa.SelectedIndex = thisKhoa;
                        return;
                    }
                    else
                    {

                        unduStack.Clear();
                        barBtnPhucHoi.Enabled = false;
                    }
                }
                thisKhoa = this.cmbKhoa.SelectedIndex;
                //chuyen site
                Lib.CmbHelper(this.cmbKhoa);
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi Kết Nỗi Với Server Khác!!", "LỖI", MessageBoxButtons.OK);
                    this.cmbKhoa.SelectedIndex = Program.MKhoa;
                }
                else
                {
                    fillData();
                }
            }

        }

        //         ======================= btn even    ===================
        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            positionLop = bdsLop.Position;
            action = "add";
            setBtnEnable(true);
            bdsLop.AddNew();
            this.txtMaKhoa.Text = ((DataRowView)bdsLop[0])["MAKHOA"].ToString(); 
            txtMaLop.Focus();
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
    
            bdsLop.RemoveCurrent();
            setBtnEnable(false);
            bdsLop.Position = positionLop;
        }

        private void barBtnGhi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.isFillAllInfoLop())
            {
                return;
            }
            //==========Thêm Lệnh SQL Kiểm Tra Trùng MALOP TENLOP trogn tat ca sites
            if (action == "add" && !checkInfoLop() )
            {
                return;
            }
            if (action == "edit" && (oldMaLop!=txtMaLop.Text.Trim() || oldTenLop != txtTenLop.Text.Trim()) && !checkInfoLop())
            {
                return;
            }
            string message = "";
            if (action == "add") message = "Bạn có chắc chắn muốn ghi Lớp này vô CSDL??";
            if (action == "edit") message = "Bạn có chắc muốn lưu thay đổi???";
             // =============================================================================
            if (MessageBox.Show(message,"",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLop.EndEdit();
                    this.bdsLop.ResetCurrentItem();
                    this.LOPTableAdapter.Update(DS.LOP);
                    if(action == "add")
                    {
                        unduStack.Push(String.Format("DELETE FROM LOP WHERE MALOP = N'{0}'AND TENLOP = N'{1}'", txtMaLop.Text.Trim(), txtTenLop.Text.Trim()));
                    }
                    if (action == "edit")
                    {
                        unduStack.Push(String.Format("UPDATE LOP SET MALOP = N'{0}', TENLOP = N'{1}', KHOAHOC = N'{2}', MAKHOA = N'{3}'  WHERE MALOP = N'{4}'", 
                            oldMaLop, oldTenLop, oldKhoaHoc, oldMaKhoa, txtMaLop.Text.Trim()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi add Lớp vào csdl!!" + ex.Message, "", MessageBoxButtons.OK);

                    return;

                }
               if(action == "add")
                {
                    //tiep tuc thao tac them
                    bdsLop.AddNew();
                    this.txtMaKhoa.Text = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
                }
               if(action == "edit")
                {
                    setBtnEnable(false);
                    bdsLop.Position = positionLop;
                }
            }

        }
      
        
        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionLop = 0;
            fillData();
            MessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() != "" || txtTenLop.Text.Trim() != "" 
                || txtKhoaHoc.Text.Trim() != "" )
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy? \nCác thông tin vừa nhập sẽ không được lưu!",
                "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
            }
            setBtnEnable(false);
            if(action == "add")
                bdsLop.RemoveCurrent();
            if (action == "edit")
                bdsLop.CancelEdit();
            bdsLop.Position = positionLop;
           // 

        }

        private void barBtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cmd = unduStack.Pop();
            Program.ExecSqlNonQuery(cmd);

            fillData();
            if (unduStack.Count == 0) barBtnPhucHoi.Enabled = false;
            
        }


        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if(bdsSV.Count != 0)
            {
                MessageBox.Show("Lớp này đã có sinh viên rồi!\n Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?","",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    oldMaLop = txtMaLop.Text.Trim();
                    oldTenLop = txtTenLop.Text.Trim();
                    oldKhoaHoc = txtKhoaHoc.Text.Trim();
                    oldMaKhoa = txtMaKhoa.Text.Trim();
                    positionLop = bdsLop.Position;
                    bdsLop.RemoveCurrent();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.LOPTableAdapter.Update(DS.LOP);
                    unduStack.Push(string.Format("INSERT INTO LOP(MALOP,TENLOP,KHOAHOC,MAKHOA) " +
                        "VALUES(N'{0}', N'{1}',N'{2}',N'{3}')", oldMaLop, oldTenLop, oldKhoaHoc, oldMaKhoa));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa LỚP!!\n Vui lòng thử lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    fillData();
                    bdsLop.Position = positionLop;
                    return;
                }
            }
            if (bdsLop.Count == 0) barBtnXoa.Enabled = false;
            if (unduStack.Count == 0) barBtnPhucHoi.Enabled = false;
            if (unduStack.Count > 0) barBtnPhucHoi.Enabled = true;

        }
        private void barBtnSua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oldMaLop = txtMaLop.Text.Trim();
            oldTenLop = txtTenLop.Text.Trim();
            oldKhoaHoc = txtKhoaHoc.Text.Trim();
            oldMaKhoa = txtMaKhoa.Text.Trim();
            positionLop = bdsLop.Position;
            action = "edit";
            setBtnEnable(true);
        }

        private void txtMaLop_EditValueChanged(object sender, EventArgs e)
        {
            txtMaLop.Properties.CharacterCasing = CharacterCasing.Upper;
           
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (unduStack.Count > 0 && MessageBox.Show("Thoát sẽ không thể phục hồi lại!!\nBạn có muốn thoát??", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
               // this.cmbKhoa.SelectedIndex = thisKhoa;
                return;
            }
            this.Close();
        }
        //============Ham ho tro==================

        //kiem tra thong tin txt da diem du thong tin chua
        private bool isFillAllInfoLop()
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
            //check độ dài
            if(txtMaLop.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã Lớp tối đa 10 kí tự!!!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            if (txtTenLop.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên Lớp tối đa 50 kí tự!!!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            if (txtKhoaHoc.Text.Trim().Length > 9)
            {
                MessageBox.Show("Khóa học tối đa 9 kí tự!!!", "", MessageBoxButtons.OK);
                txtKhoaHoc.Focus();
                return false;
            }
            //
            string strLenh1 = "EXEC SP_CHECKMALOP '" +txtMaLop.Text.Trim() +"'";
            int check = Lib.checkData(strLenh1);
            if ( check == -1)
            {
                MessageBox.Show("Lỗi kết nối CSDL!", "", MessageBoxButtons.OK);
                return false;
            }
            if (check == 1)
            {
                //return true;
                MessageBox.Show("Mã Lớp đã tồn tại trong khoa này!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;

            }
            if(check == 2)
            {
                MessageBox.Show("Mã Lớp đã tồn tại trong khoa khác!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            //kiem tra lại trong bds (khi trên server xóa lớp nhưng trong bds chưa update)
            check = bdsLop.Find("MALOP", txtMaLop.Text);
            if (check != -1)
            {
                //ghi lai thong tin va fill laij data truongwf hop 'add' and 'edit'
                /*if(action == "add")
                {
                    oldMaLop = txtMaLop.Text.Trim();
                    oldTenLop = txtTenLop.Text.Trim();
                    oldKhoaHoc = txtKhoaHoc.Text.Trim();
                    oldMaKhoa = txtMaKhoa.Text.Trim();

                    fillData();

                    bdsLop.AddNew();
                    this.txtMaKhoa.Text = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
                    txtMaLop.Text = oldMaLop;
                    txtTenLop.Text = oldTenLop;
                    txtKhoaHoc.Text = oldKhoaHoc;
                    txtMaKhoa.Text = oldMaKhoa;
                }*/
                MessageBox.Show("Mã Lớp đã tồn tại trong khoa này!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            // kiem tra tenlop =========================================
            string strLenh2 = "EXEC SP_CHECKTENLOP N'" + txtTenLop.Text.Trim() + "'";
            check = Lib.checkData(strLenh2);
            if (check == -1)
            {
                MessageBox.Show("Lỗi kết nối CSDL!", "", MessageBoxButtons.OK);

                return false;
            }
            if (check == 1)
            {
                MessageBox.Show("Tên Lớp đã tồn tại trong khoa này!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();

                return false;
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
                //fillData();
            }

            return true;
        }

        

        
    }   
}