using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace QLDSV_HTC.Forms
{
    public partial class frmDSHPLop : DevExpress.XtraEditors.XtraForm
    {
        string GV = Program.userName;
        public frmDSHPLop()
        {
            InitializeComponent();
        }

        private void loadMaLop()
        {
            string cmd_1 = "SELECT MALOP FROM LOP";
            DataTable tb_1 = new DataTable();
            SqlDataAdapter dt_1 = new SqlDataAdapter(cmd_1, Program.Conn);
            dt_1 = new SqlDataAdapter(cmd_1, Program.Conn);
            dt_1.Fill(tb_1);
            cmbMaLop.DataSource = tb_1;
            cmbMaLop.DisplayMember = "MALOP";
            cmbMaLop.ValueMember = "MALOP";
            cmbMaLop.SelectedIndex = 0;
        }
        private void loadNienKhoa()
        {
            string cmd_2 = "SELECT DISTINCT NIENKHOA FROM HOCPHI";
            DataTable tb_2 = new DataTable();
            SqlDataAdapter dt_2 = new SqlDataAdapter(cmd_2, Program.Conn);
            dt_2 = new SqlDataAdapter(cmd_2, Program.Conn);
            dt_2.Fill(tb_2);
            cmbNienKhoa.DataSource = tb_2;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
            cmbNienKhoa.SelectedIndex = 0;
        }

        private void frmDSHPLop_Load(object sender, EventArgs e)
        {
            cmbHocKy.SelectedIndex = 0;
            loadMaLop();
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = cmbMaLop.Text.Trim();
            loadNienKhoa();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string KHOA = null;
            Program.myReader = Program.ExecSqlDataReader("SELECT MAKHOA FROM LOP WHERE MALOP = '" + cmbMaLop.Text.Trim() + "'");
            if (Program.myReader.HasRows)
            {
                while (Program.myReader.Read())
                {
                    KHOA = Program.myReader.GetString(0);
                }
            }
            else
            {
                return;
            }
            Program.myReader.Close();
            string MALOP = cmbMaLop.Text.Trim();
            string NK = cmbNienKhoa.Text.Trim();
            int HK  = int.Parse(cmbHocKy.Text.Trim());
            string cmd_2 = "SELECT HOTEN = HO + ' ' + TEN FROM GIANGVIEN WHERE MAGV = '" + GV + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd_2);
            while (Program.myReader.Read())
            {
                GV = Program.myReader.GetString(0);
            }
            Program.myReader.Close();
            GV = GV.ToUpper().Trim();
            frmRpDSHPLop rp = new frmRpDSHPLop(GV,KHOA,MALOP, NK, HK);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
            //rp.ShowPreviewDialog();
        }


    }
}