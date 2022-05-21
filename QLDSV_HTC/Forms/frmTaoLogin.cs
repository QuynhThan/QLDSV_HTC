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
    public partial class frmTaoLogin : Form
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void setDS_cmbNhom()
        {
            //datatable nhóm
            DataTable dt = new DataTable();
            dt.Columns.Add("NHOM", typeof(string));
            if(Program.mGroup == Program.quyen[0])
            {
                dt.Rows.Add("PGV");
                dt.Rows.Add("KHOA");
            }
            if (Program.mGroup == Program.quyen[1])
            {
                dt.Rows.Add("KHOA");
            }
            if (Program.mGroup == Program.quyen[3])
            {
                dt.Rows.Add("PKT");
            }

            cmbNhom.DataSource = dt;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";

        }
        private void setDS_cmbUser()
        {
            //datatable user
            string cmd = "SELECT MAGV,MAHOTENGV = MAGV + ' | ' + HO + ' ' + TEN FROM GIANGVIEN"; // CO THE THEM DK LOC NHUNG USER CHUA CO LOGIN
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
                Program.myReader.Close();
                return;
            }
            if (Program.myReader.FieldCount == 0)
            {
                MessageBox.Show("Hiện tại chưa có GIANGVIEN nào!!.", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                // disable frm
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("MAGV", typeof(string));
            dt.Columns.Add("MAHOTENGV", typeof(string));
            while (Program.myReader.Read())
            {
                dt.Rows.Add(Program.myReader.GetString(0), Program.myReader.GetString(1));
            }
            Program.myReader.Close();

            cmbUser.DataSource = dt;
            cmbUser.DisplayMember = "MAHOTENGV";
            cmbUser.ValueMember = "MAGV";

        }
        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
           
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);

            setDS_cmbNhom();
            setDS_cmbUser();

            //phân quyền
            if(Program.mGroup == Program.quyen[0])
            {
                Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";
                cmbKhoa.Enabled = cmbNhom.Enabled = true;
            }
            else           
            {
                //khoa - pkt ko duoc chon group
                // --- khi dang nhap thi bds_dspm da chon dung sit ===> chir can enable ko con filter lai
                /*if(Program.mGroup == Program.quyen[3])
                {
                    Program.bds_dspm.Filter = "TENKHOA = 'HỌC PHÍ'";
                }
                if(Program.mGroup == Program.quyen[1])
                {
                    Program.bds_dspm.Filter = "TENKHOA = 'KHOA'";
                }*/
                cmbKhoa.Enabled = cmbNhom.Enabled = false;
            }
            
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            //code kiem tra input
            if(txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được để trống!!!","",MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                if(MessageBox.Show("Mật khẩu trống!!\nBạn có muốn đặt mật khẩu mặc định '123'??", "", MessageBoxButtons.OKCancel) == DialogResult.OK){
                    txtPassword.Text = "123";
                }
                else
                {
                    txtPassword.Focus();
                    return;
                }
            }
            //
            if (MessageBox.Show("Bạn có chắc muốn tạo tài khoản với những thông tin trên??","",MessageBoxButtons.OKCancel) == DialogResult.OK){
                string cmd = string.Format("EXEC SP_TAO_LOGIN N'{0}',N'{1}',N'{2}',N'{3}'",
                    txtUsername.Text.Trim(), txtPassword.Text.Trim(), cmbUser.SelectedValue.ToString().Trim(), cmbNhom.SelectedValue.ToString().Trim());
                int kt = Program.ExecSqlNonQuery(cmd);
                if(kt != 0)
                {
                    /*if(kt == 1)
                    {
                        MessageBox.Show("Tài khoản đã được sử dụng!\nVui lòng sử dụng tài khoản khác!", "Lỗi", MessageBoxButtons.OK);
                    }
                    if(kt == 2)
                    {
                        MessageBox.Show("Giảng viên này đã có tài khoản rồi!!","Lỗi",MessageBoxButtons.OK);
                    }*/
                    MessageBox.Show("Tạo tài khoản thất bại!!\nVui lòng thử lại!!" ,"Lỗi",MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thành công!!\nTài khoản: " + txtUsername.Text.Trim() + 
                        "\nMật khẩu: " + txtPassword.Text.Trim(),"",MessageBoxButtons.OK);
                }
            }
        }
        ////// tai khoan tren site nao chi tạo tai khoan trên site đó, hay là tk nhóm pgv có thể tại tk cho site khác????
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lib.CmbHelper(this.cmbKhoa);
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi Kết Nỗi Với Server Khác!!", "LỖI", MessageBoxButtons.OK);
                this.cmbKhoa.SelectedIndex = Program.MKhoa;
            }
            else
            {
                //loadNK();
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }
    }
}
