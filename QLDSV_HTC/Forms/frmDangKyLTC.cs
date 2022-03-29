using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace QLDSV_HTC.Forms
{
    public partial class frmDangKyLTC : DevExpress.XtraEditors.XtraForm
    {

        public frmDangKyLTC()
        {
            InitializeComponent();
        }

       
        private void loadDataSP_DSLTCDADANGKY()
        {
            try
            {

                this.dS.EnforceConstraints = false;
                this.sP_DSLTCDADANGKYTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.sP_DSLTCDADANGKYTableAdapter.Fill(this.dS.SP_DSLTCDADANGKY,
                    txtMaSV.Text.Trim(), txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            }
            catch
            {
                MessageBox.Show("Lỗi load data DSLTCDADANGKY!!!", "", MessageBoxButtons.OK);
                return;
            }
        }
        private void loadDataSP_DSLTC_NIENKHOAHOCKY()
        {
            try
            {
                this.dS.EnforceConstraints = false;
                this.sP_DSLTC_NIENKHOAHOCKYTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.sP_DSLTC_NIENKHOAHOCKYTableAdapter.Fill(this.dS.SP_DSLTC_NIENKHOAHOCKY
                    , txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            }
            catch
            {
                MessageBox.Show("Lỗi load data DSLTC_NIENKHOAHOCKY!!!!!", "", MessageBoxButtons.OK);
                return;
            }
        }
        private void loadData()
        {
            loadDataSP_DSLTC_NIENKHOAHOCKY();
            loadDataSP_DSLTCDADANGKY();

            //  disable row in gvdangkyltc
            

        }
        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            lblMaSV.Text = Program.MUser;
            string cmd = "EXEC SP_LAYHOTENLOPSV '" + lblMaSV.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
                //groupBoxDKLTC.Visible = false;
                Program.myReader.Close();
                return;
            }
            if (Program.myReader.FieldCount == 0)
            {
                MessageBox.Show("Mã SV không tồn tại!!!\nVui lòng thử lại.", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                lblMaSV.Focus();
                return;
            }
            Program.myReader.Read();
            lblHoTen.Text = Program.myReader.GetString(0);
            lblMaLop.Text = Program.myReader.GetString(1);
            lblTenLop.Text = Program.myReader.GetString(2);
            Program.myReader.Close();
            groupBoxDKLTC.Enabled = true;
            panelDN.Enabled = false;
        }
           /*
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!!!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            string cmd = "EXEC SP_LAYHOTENLOPSV '" + txtMaSV.Text.Trim() +"'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
                //groupBoxDKLTC.Visible = false;
                Program.myReader.Close();
                return;
            }
            if(Program.myReader.FieldCount == 0)
            {
                MessageBox.Show("Mã SV không tồn tại!!!\nVui lòng thử lại.", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                txtMaSV.Focus();
                return;
            }
            Program.myReader.Read();
            lblHoTen.Text = Program.myReader.GetString(0);
            lblMaLop.Text = Program.myReader.GetString(1);
            lblTenLop.Text = Program.myReader.GetString(2);
            Program.myReader.Close();
            groupBoxDKLTC.Enabled = true;
            barBtnDangXuat.Enabled = true;
            panelDN.Enabled = false;
        }*/

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên Khóa không được bỏ trống!!!!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }
            gcDangKyLTC.DataSource = this.bdsSP_DSLTC_NIENKHOAHOCKY;
            gcLTCDaDangKy.DataSource = this.bdsSP_DSLTCDADANGKY;
            loadData();
            barBtnReload.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy đăng ký lớp tín chỉ đã chọn???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int[] selectRows = gvLTCDaDangKy.GetSelectedRows();

                List<int> listMALTC = new List<int>();
                foreach(int i in selectRows)
                {
                    DataRow row = gvLTCDaDangKy.GetDataRow(i);
                    listMALTC.Add(Convert.ToInt32(row["MALTC"]));
                }

                string query = string.Format("UPDATE DANGKY SET HUYDANGKY = 1 WHERE MASV = '{0}' AND MALTC IN ({1})"
                        , txtMaSV.Text.Trim(), string.Join(",", listMALTC));
                Program.ExecSqlNonQuery(query);
                loadData();
            }

        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barBtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lblHoTen.Text = "";
            lblMaLop.Text = "";
            lblTenLop.Text = "";
            txtMaSV.Text = "";
            groupBoxDKLTC.Enabled = false;
            barBtnDangXuat.Enabled = false;
            barBtnReload.Enabled = false;
            panelDN.Enabled = true;

            gcDangKyLTC.DataSource = null;
            gcLTCDaDangKy.DataSource = null;


        }

        private void gvDangKyLTC_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
           
            DataRow row = gvDangKyLTC.GetFocusedDataRow();
            if (row == null) return;
            if (checkMALTC_DKI(Convert.ToInt32(row["MALTC"]))) return;
            
            string query = string.Format("EXEC SP_DANGKY_LTC {0}, {1}", Convert.ToInt32(row["MALTC"]), txtMaSV.Text.Trim());
            Program.ExecSqlNonQuery(query);
            loadData();
        }

        private void gvLTCDaDangKy_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btnXoa.Enabled = gvLTCDaDangKy.GetSelectedRows().Length > 0;
        }

        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void gvDangKyLTC_ShowingEditor(object sender, CancelEventArgs e)
        {
            DataRow row = gvDangKyLTC.GetFocusedDataRow();
           
            if ( Convert.ToBoolean(row["selection"]) == true)
                e.Cancel = true;
        }

        private void gvDangKyLTC_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            
            DataRow row = gvDangKyLTC.GetDataRow(e.RowHandle);
            if (row == null) return;
            if (checkMALTC_DKI(Convert.ToInt32(row["MALTC"])))
            {
                gvDangKyLTC.SelectRow(e.RowHandle);
                //e.Appearance.BackColor = Color.Aqua;
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            txtMaSV.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            this.btnXoa.BackColor = Color.Red;
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            this.btnXoa.BackColor = Color.Tomato;
        }

        ///-------------------------////
        private bool checkMALTC_DKI(int maltc)
        {
            List<int> listtmp = new List<int>();
            for (int i = 0; i < gvLTCDaDangKy.DataRowCount; i++)
            {
                DataRow r = gvLTCDaDangKy.GetDataRow(i);
                listtmp.Add(Convert.ToInt32(r["MALTC"]));
            }
            return listtmp.Contains(maltc);

        }
    }
}