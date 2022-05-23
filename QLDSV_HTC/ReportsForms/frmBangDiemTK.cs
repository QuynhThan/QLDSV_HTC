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
    public partial class frmBangDiemTK : DevExpress.XtraEditors.XtraForm
    {
        string GV = Program.userName;
        string KH = "";
        public frmBangDiemTK()
        {
            InitializeComponent();
        }

        private void frmBangDiemTK_Load(object sender, EventArgs e)
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

            Lib.BDataToCmb(cmbKhoa, Program.bds_dspm);
            Program.bds_dspm.Filter = "TENKHOA <> 'HOC PHI'";
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lib.CmbHelper(cmbKhoa);
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Loi ket noi voi server khac!!");
                this.cmbKhoa.SelectedIndex = Program.MKhoa;
            }
            else
            {
                
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string cmd_1 = "SELECT KHOAHOC FROM LOP WHERE MALOP = '" + cmbMaLop.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd_1);
            while(Program.myReader.Read())
            {
               KH = Program.myReader.GetString(0);
            }
            Program.myReader.Close();
            string cmd_2 = "SELECT HOTEN = HO + ' ' + TEN FROM GIANGVIEN WHERE MAGV = '" + GV+ "'";
            Program.myReader = Program.ExecSqlDataReader(cmd_2);
            while (Program.myReader.Read())
            {
                GV = Program.myReader.GetString(0);
            }
            Program.myReader.Close();
            GV = GV.ToUpper().Trim();
            XrpDSDiem rp = new XrpDSDiem(cmbKhoa.Text,cmbMaLop.Text,KH,GV);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}