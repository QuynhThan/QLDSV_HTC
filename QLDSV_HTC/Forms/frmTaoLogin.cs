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

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);

            //phân quyền
            if(Program.mGroup == Program.quyen[0])
            {
                Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";
                cmbKhoa.Enabled = cmbNhom.Enabled = true;
            }
            else           
            {
                //khoa - pkt ko duoc chon group
                cmbKhoa.Enabled = cmbNhom.Enabled = false;
            }
            
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            //code kiem tra input

            if(MessageBox.Show("Bạn có chắc muốn tạo tài khoản với những thông tin trên??","",MessageBoxButtons.OKCancel) == DialogResult.OK){
                string cmd = string.Format("EXEC SP_TAO_LOGIN N'{0},N'{1}',N'{2}',N'{3}'",
                    txtUsername.Text.Trim(), txtPassword.Text.Trim(), cmbUser.SelectedValue.ToString().Trim(), cmbNhom.SelectedValue.ToString().Trim());
                int kt = Program.ExecSqlNonQuery(cmd);
                if(kt != 0)
                {
                    MessageBox.Show("Tạo tài khoản thất bại!!\nVui lòng thử lại!!","Lỗi",MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thành công!!\nTài khoản: " + txtUsername.Text.Trim() + 
                        "\nMật khẩu: " + txtPassword.Text.Trim(),"",MessageBoxButtons.OK);
                }
            }
        }

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
    }
}
