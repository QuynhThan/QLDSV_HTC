using DevExpress.XtraEditors;
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
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        string maltc;
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        private void loadNKHK()
        {
            string cmd_2 = "SELECT DISTINCT NIENKHOA FROM LOPTINCHI";
            DataTable tb_2 = new DataTable();
            SqlDataAdapter dt_2 = new SqlDataAdapter(cmd_2, Program.Conn);
            dt_2 = new SqlDataAdapter(cmd_2, Program.Conn);
            dt_2.Fill(tb_2);
            cmbNienKhoa.DataSource = tb_2;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
            cmbNienKhoa.SelectedIndex = 0;
        }
        private void loadDATA()
        {
            try
            {
                this.sP_LTCTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.sP_LTCTableAdapter.Fill(this.dS.SP_LTC, cmbNienKhoa.Text.Trim(), Convert.ToInt32(cmbHocKy.Text.Trim()));


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi load data!", "", MessageBoxButtons.OK);
                return;
            }
        }
        private void loadDIEM()
        {
            try
            {
                this.sP_DIEMTCTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.sP_DIEMTCTableAdapter.Fill(this.dS.SP_DIEMTC, maltc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi load diem!", "", MessageBoxButtons.OK);
                return;
            }

        }
        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            Lib.BDataToCmb(cmbKhoa, Program.bds_dspm);
            Program.bds_dspm.Filter = "TENKHOA <> 'HOC PHI'";
            loadNKHK();
            cmbHocKy.SelectedIndex = 0;
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
                loadNKHK();
            }
        }


        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            loadDIEM();
        }

        private void btnTaiLopTinChi_Click(object sender, EventArgs e)
        {

            loadDATA();
            btnNhapDiem.Enabled = true;
            btnGhiDiem.Enabled = true;
        }

        private void sP_LTCGridControl_Click(object sender, EventArgs e)
        {
            maltc = ((DataRowView)bds_SP_LTC[bds_SP_LTC.Position])["MALTC"].ToString();
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            int intmaltc = int.Parse(maltc);
            for (int i = 0; i < this.dS.SP_DIEMTC.Rows.Count; i++)
            {
                dt.Rows.Add(intmaltc, this.dS.SP_DIEMTC.Rows[i]["MASV"], this.dS.SP_DIEMTC.Rows[i]["DIEM_CC"], this.dS.SP_DIEMTC.Rows[i]["DIEM_GK"], this.dS.SP_DIEMTC.Rows[i]["DIEM_CK"]);
            }
            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_DANGKY";
            para.ParameterName = "@DIEMTHI";
            para.Value = dt;
            Program.KetNoi();
            SqlCommand cmd = new SqlCommand("SP_UPDATE_DIEM", Program.Conn);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(para);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ghi diem!" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (int.Parse(e.Value.ToString()) > 10 || int.Parse(e.Value.ToString()) < 0)
            {
                MessageBox.Show("Điểm không hợp lệ!" , "", MessageBoxButtons.OK);
                gridView2.SetRowCellValue(e.RowHandle,e.Column, 0);
            }
        }
    }
}