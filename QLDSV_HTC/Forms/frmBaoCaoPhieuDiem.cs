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
    public partial class frmBaoCaoPhieuDiem : Form
    {
        public frmBaoCaoPhieuDiem()
        {
            InitializeComponent();
            loadKhoa();
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

        private void loadKhoa()
        {
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);
            Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";
        }

        private string kiemTraMaSV()
        {
            string cmd = "EXEC SP_LAY_HOTENSV '" + txtMaSV.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
                MessageBox.Show("Lỗi load data!!!", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return "";
            }
            else if(Program.myReader.HasRows == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return "";
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("HOTEN");
            string a = "";
            while (Program.myReader.Read())
                a = Program.myReader.GetString(0).Trim();
            
            Program.myReader.Close();
            return a;
        }

        private void btnInPhieuDiem_Click(object sender, EventArgs e)
        {
            string hoten = "";
            if (txtMaSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Không được để trống mã SV", "", MessageBoxButtons.OK);
                return;
            }
            hoten = kiemTraMaSV();
           if (hoten == "")
            {
                return;
            }
            else 
            {
                XrptPhieuDiem rp = new XrptPhieuDiem(txtMaSV.Text.Trim());
                rp.lblHoten.Text = "Họ tên sinh viên: " + hoten;
                if (!rp.lblHoten.Text.Equals(""))
                {
                    rp.lblMaSV.Text = "Mã số sv: " + txtMaSV.Text.Trim();
                    rp.lblGiangVienLapPhieu.Text = "Giảng viên lập phiếu: " + Program.mHoTen;
                    rp.lblNgayLap.Text = "Ngày lập: " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                    ReportPrintTool print = new ReportPrintTool(rp);
                    print.ShowPreviewDialog();
                }
            }
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            sender.ToString().ToUpper();
        }
    }
}
