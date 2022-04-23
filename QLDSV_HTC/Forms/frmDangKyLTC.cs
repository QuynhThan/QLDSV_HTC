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

        private int position = 0;
        private bool isLoading = false;
        DataTable dt = new DataTable();
        // === xem lại các gc datasource nên gán datasource khi đã chọn nien khoa học kỳ ?? có nên hay ko??
        // ===
        public frmDangKyLTC()
        {
            // tạo 1 data Reader để dọc dữ liệu từ SP_DSLTC_NIENKHOAHOCKY 
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAMH", typeof(string));
            dt.Columns.Add("TENMH", typeof(string));
            dt.Columns.Add("NHOM", typeof(int));
            dt.Columns.Add("TENGV", typeof(string));
            dt.Columns.Add("SOSVTOITHIEU", typeof(int));
            dt.Columns.Add("SOSVDADK", typeof(int));



            InitializeComponent();
        }

       
        private void loadDataSP_DSLTCDADANGKY()
        {
            try
            {

                this.dS.EnforceConstraints = false;
                this.sP_DSLTCDADANGKYTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.sP_DSLTCDADANGKYTableAdapter.Fill(this.dS.SP_DSLTCDADANGKY,
                    lblMaSV.Text.Trim(), cmbNienKhoa.SelectedValue.ToString().Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
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
                    , cmbNienKhoa.SelectedValue.ToString().Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));

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
            setColorRowsSelected();
            //gvDangKyLTC.CancelSelection();
            gvDangKyLTC.Focus();

        }
        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            lblMaSV.Text = Program.MUser;
            string cmd = "EXEC SP_LAYHOTENLOPSV '" + lblMaSV.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null)
            {
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

            cmd = "SELECT DISTINCT NIENKHOA FROM LOPTINCHI";
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
           

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            /*if (cmbNienKhoa.SelectedValue == "")
            {
                MessageBox.Show("Niên Khóa không được bỏ trống!!!!", "", MessageBoxButtons.OK);
                
                return;
            }*/
            loadData();
            barBtnReload.Enabled = true;

           // Console.WriteLine(gvDangKyLTC.SelectedRowsCount);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy đăng ký lớp tín chỉ đã chọn???", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int[] selectedRows = gvLTCDaDangKy.GetSelectedRows();

                List<int> listMALTC = new List<int>();
                foreach(int i in selectedRows)
                {
                    DataRow row = gvLTCDaDangKy.GetDataRow(i);
                    listMALTC.Add(Convert.ToInt32(row["MALTC"]));
                }

                string query = string.Format("UPDATE DANGKY SET HUYDANGKY = 1 WHERE MASV = '{0}' AND MALTC IN ({1})"
                        , lblMaSV.Text.Trim(), string.Join(",", listMALTC));
                Program.ExecSqlNonQuery(query);
                loadData();
               // Console.WriteLine(gvDangKyLTC.GetSelectedRows());
               // Console.WriteLine(gvDangKyLTC.SelectedRowsCount + "btnXoas");

            }

        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

     

        private void gvDangKyLTC_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (!isLoading)
            {
                DataRow row = gvDangKyLTC.GetFocusedDataRow();
                if (row == null) return;
                //Console.WriteLine(checkMALTC_DKI(Convert.ToInt32(row["MALTC"])));
                if (checkMALTC_DKI(Convert.ToInt32(row["MALTC"])))
                {
                    setColorRowsSelected();
                    return;
                }

                position = bdsSP_DSLTC_NIENKHOAHOCKY.Position;
                string query = string.Format("EXEC SP_DANGKY_LTC {0}, '{1}'", Convert.ToInt32(row["MALTC"]), lblMaSV.Text.Trim());
                Program.ExecSqlNonQuery(query);
                loadData();
                bdsSP_DSLTC_NIENKHOAHOCKY.Position = position;
            }
        }

        private void gvLTCDaDangKy_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btnXoa.Enabled = gvLTCDaDangKy.GetSelectedRows().Length > 0;
        }

        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        /*private void gvDangKyLTC_ShowingEditor(object sender, CancelEventArgs e)
        {
            DataRow row = gvDangKyLTC.GetFocusedDataRow();
           
            if ( Convert.ToBoolean(row["selection"]) == true)
                e.Cancel = true;
        }*/

      /*  private void gvDangKyLTC_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            DataRow row = gvDangKyLTC.GetDataRow(e.RowHandle);
            if (row == null) return;
            if (checkMALTC_DKI(Convert.ToInt32(row["MALTC"])))
            {
                gvDangKyLTC.SelectRow(e.RowHandle);
                //e.Appearance.BackColor = Color.Aqua;
            }
        }
*/


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

        private void setColorRowsSelected()
        {
            isLoading = true;
            for (int i = 0; i < gvDangKyLTC.DataRowCount; i++)
            {
                DataRow row = gvDangKyLTC.GetDataRow(i);
                if (row == null) return;
                if (checkMALTC_DKI(Convert.ToInt32(row["MALTC"])))
                {
                    gvDangKyLTC.SelectRow(i);

                }
            }
            isLoading = false;
            //Console.WriteLine(gvDangKyLTC.SelectedRowsCount);

        }
    }
}