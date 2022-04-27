using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

using QLDSV_HTC.Reports;

namespace QLDSV_HTC.ReportsForms
{
    public partial class frpt_DSSV_DANGKY_LTC : Form
    {
        public frpt_DSSV_DANGKY_LTC()
        {
            InitializeComponent();
        }

        private void load_NK_MH()
        {

            string cmd = "SELECT DISTINCT NIENKHOA FROM LOPTINCHI";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
                Program.myReader.Close();
                return;
            }
            if (Program.myReader.FieldCount == 0)
            {
                MessageBox.Show("Hiện tại chưa có lớp tín chỉ nào!!.", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                // disable frm dang ky
                return;
            }
            DataTable dt_nk = new DataTable();
            dt_nk.Columns.Add("NIENKHOA", typeof(string));
            while (Program.myReader.Read())
            {
                dt_nk.Rows.Add(Program.myReader.GetString(0));
            }
            Program.myReader.Close();
            cmbNienKhoa.DataSource = dt_nk;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";

            cmd = "SELECT MAMH, TENMH FROM MONHOC";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
                Program.myReader.Close();
                return;
            }
            if (Program.myReader.FieldCount == 0)
            {
                MessageBox.Show("Hiện tại chưa có môn học nào!!.", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                // disable frm dang ky
                return;
            }
            DataTable dt_mh = new DataTable();
            dt_mh.Columns.Add("MAMH", typeof(string));
            dt_mh.Columns.Add("TENMH", typeof(string));
            while (Program.myReader.Read())
            {
                dt_mh.Rows.Add(Program.myReader.GetString(0), Program.myReader.GetString(1));
            }
            Program.myReader.Close();
            cmbMonHoc.DataSource = dt_mh;
            cmbMonHoc.DisplayMember = "TENMH";
            cmbMonHoc.ValueMember = "MAMH";
        }
        private void frpt_DSSV_DANGKY_LTC_Load(object sender, EventArgs e)
        {
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);

            load_NK_MH();

            //phan quyen
            if (Program.mGroup == Program.quyen[0])
            {
                Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";

            }

            if (Program.mGroup == Program.quyen[1])
            {
                //Program.bds_dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
                cmbKhoa.Enabled = false;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //bat loi nhap lieu

            //
            xrpt_DSSV_DANGKY_LTC rpt = new xrpt_DSSV_DANGKY_LTC(cmbNienKhoa.Text.Trim(),Convert.ToInt32(txtHocKy.Text.Trim()),cmbMonHoc.SelectedValue.ToString().Trim(),Convert.ToInt32(txtNhom.Text.Trim()));
            rpt.lblKhoa.Text = "KHOA " + cmbKhoa.Text.Trim();
            rpt.lblNKHK.Text = "Niên khóa: " + cmbNienKhoa.Text.Trim() + "  Học kỳ: " + txtHocKy.Text.Trim();
            rpt.lblMHNHOM.Text = "Môn học: " + cmbMonHoc.Text.Trim() + " - Nhóm: " + txtNhom.Text.Trim();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
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
                load_NK_MH();
            }
        }
    }
}
