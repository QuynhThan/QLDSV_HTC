using DevExpress.XtraReports.UI;
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
    public partial class frmBaoCaoBangDiem : Form
    {
        public frmBaoCaoBangDiem()
        {
            InitializeComponent();
        }

        private void loadNienKhoa()
        {
            string cmd = "SELECT * FROM V_LAY_NIENKHOA";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
                MessageBox.Show("Lỗi load data!!!", "", MessageBoxButtons.OK);
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("NIENKHOA");

            while (Program.myReader.Read())
            {
                dt.Rows.Add(Program.myReader.GetString(0));
            }
            Program.myReader.Close();
            cmbNienKhoa.DataSource = dt;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";

        }

        private void loadKhoa()
        {
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);
            Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";
        }

        private void frmBaoCaoBangDiem_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.Connstr;
            // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            loadKhoa();
            loadNienKhoa();
            if (Program.mGroup == "KHOA") cmbKhoa.Enabled = false;
            cmbKhoa.SelectedIndex = Program.MKhoa;
        }

        private bool daDienDu()
        {
            if (txtNhom.Text.Trim().Equals("")) MessageBox.Show("Không được để trống nhóm", "", MessageBoxButtons.OK);
            else if (cmbHocKy.Text.Trim().Equals("")) MessageBox.Show("Không được để trống học kỳ", "", MessageBoxButtons.OK);
            return true;
        }

        public void btnInBangDiem_Click(object sender, EventArgs e)
        {
            if (daDienDu())
            {
                XrptBangDiemMonHoc rp = new XrptBangDiemMonHoc(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), cmbTenMH.Text, int.Parse(txtNhom.Text.Trim()));
                rp.lblTenKhoa.Text = "KHOA: " + cmbKhoa.Text;
                rp.lblNienKhoa.Text = "Niên khóa: " + cmbNienKhoa.Text;
                rp.lblMonHoc.Text = "Môn học: " + cmbTenMH.Text;
                rp.lblHocKy.Text = "Học kỳ: " + cmbHocKy.Text;
                rp.lblNhom.Text = "Nhóm: " + txtNhom.Text;
                rp.lblNgayLap.Text = "Ngày lập: "  + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                rp.lblGiangVienLap.Text = "Giảng viên lập bảng điểm: " + Program.mHoTen;
                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
        }


        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lib.CmbHelper(cmbKhoa);

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Loi ket noi voi server khac!!");
                this.cmbKhoa.SelectedIndex = Program.MKhoa;
            }
        }
    }
}
