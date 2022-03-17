using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class frmDangNhap : Form
    {

        private static SqlConnection Conn_pub = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }
        private int KetNoi_CSDLGOC()
        {
            if (Conn_pub != null && Conn_pub.State == System.Data.ConnectionState.Open)
                Conn_pub.Close();
            try
            {
                Conn_pub.ConnectionString = Program.Connstr_pub;
                Conn_pub.Open();
                return 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi co so du lieu" + ex.ToString());
                return 0;
            }
        }

        private void LayDSPM(string cmd)
        {
            DataTable dt = new DataTable();
            if (Conn_pub.State == ConnectionState.Closed)
                Conn_pub.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Conn_pub);
            da.Fill(dt);
            Conn_pub.Close();

            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            //Lib.BDataToCmb(cmbKhoa, Program.bds_dspm.DataSource);
            //Program.MKhoa = 0;
            //cmbKhoa.SelectedIndex = 0;
            //Program.ServerName = "QUYNH\\SERVER1";//cmbKhoa.SelectedValue.ToString();

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM V_GET_SUBSCRIBES");

            cmbKhoa.SelectedIndex = 1; 
            cmbKhoa.SelectedIndex = 0;

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            /* Program.frmMain = new frmMain();
             Program.frmMain.Show();*/
            if(txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Tai khoan hoac mat khau khong duoc bo trong");
                return;
            }

            Program.MLogin = txtTK.Text;
            Program.MPass = txtMK.Text;
            if (Program.KetNoi() == 0) return;

            Program.MKhoa = cmbKhoa.SelectedIndex;
            Program.MLoginDN = Program.MLogin;
            Program.MPassDN = Program.MPass;

            string strLenh = "EXEC SP_DANGNHAP '" + Program.MLogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;

            Program.myReader.Read();

            Program.userName = Program.myReader.GetString(0);
            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            

            Program.frmMain.lblMaSV.Text = "MaSV: " + Program.userName;
            Program.frmMain.lblHoTen.Text = "Ho Ten: " + Program.mHoTen;
            Program.frmMain.lblGroup.Text = "Nhom: " + Program.mGroup;


            //PHAN QUYEN TREN DAY
            if (Program.mGroup == Program.quyen[3])
            {
                Program.frmMain.barBtnLop.Enabled = Program.frmMain.barBtnSinhVien.Enabled = Program.frmMain.barBtnMonHoc.Enabled
                    = Program.frmMain.barBtnDiem.Enabled = Program.frmMain.barBtnLopTinChi.Enabled =Program.frmMain.barBtnTaoLogin.Enabled = false;
                Program.frmMain.rbBaoCao.Visible = false;
            }
            if (Program.mGroup == Program.quyen[2])
            {
                Program.frmMain.barBtnLop.Enabled = Program.frmMain.barBtnSinhVien.Enabled = Program.frmMain.barBtnMonHoc.Enabled
                    = Program.frmMain.barBtnDiem.Enabled = Program.frmMain.barBtnHocPhi.Enabled =Program.frmMain.barBtnTaoLogin.Enabled = false;
                Program.frmMain.rbBaoCao.Visible = false;
            }
            if (Program.mGroup == Program.quyen[0] || Program.mGroup == Program.quyen[1])
            {
                Program.frmMain.barBtnLop.Enabled = Program.frmMain.barBtnSinhVien.Enabled = Program.frmMain.barBtnMonHoc.Enabled
                    = Program.frmMain.barBtnDiem.Enabled = Program.frmMain.barBtnHocPhi.Enabled = Program.frmMain.barBtnTaoLogin.Enabled = true;
                Program.frmMain.rbBaoCao.Visible = true;
            }
            Program.frmMain.Enabled = true;
            Program.frmDangNhap.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.ServerName = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khong co chi nhanh tron db" + ex.ToString());
            }
        }
    }
}
