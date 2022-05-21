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

namespace QLDSV_HTC.ReportsForms
{
    public partial class frpt_DSLTC_NK_HK : Form
    {
        public frpt_DSLTC_NK_HK()
        {
            InitializeComponent();
        }

        private void loadNK()
        {
            //add data to cmbNienKhoa
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
                // disable frpt
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
        }
        private void frpt_DSLTC_NK_HK_Load(object sender, EventArgs e)
        {

            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);

            loadNK();

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
                loadNK();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            xrpt_DSLTC_NK_HK rpt = new xrpt_DSLTC_NK_HK(cmbNienKhoa.SelectedValue.ToString().Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            rpt.lblKhoa.Text = "KHOA " + cmbKhoa.Text.Trim();
            rpt.lblNKHK.Text = "Niên khóa: " + cmbNienKhoa.Text.Trim() + "  Học kỳ: " + txtHocKy.Text.Trim();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
