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
    public partial class frmLopTinChi : Form
    {
        private string action = "";
        private int position = 0;
        String oldNienKhoa, oldHocKy, oldMaMH, oldNhom, oldMaGV, oldMaKhoa, oldSoSVToiThieu, oldHuyLop = "";
        Stack<string> undoStack = new Stack<string>();
        public frmLopTinChi()
        {
            InitializeComponent();
        }
        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            loadData();
            enableButton(false);
            loadMAGV();
            loadMAMH();
            loadKhoa();
            loadNienKhoa();
            loadHocKy();
            btnPhucHoi.Enabled = false;
            if (Program.mGroup == Program.quyen[1]) cmbKhoa.Enabled = false;
        }

        private Boolean dienHet()
        {
            if (txtNhom.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống nhóm!", "", MessageBoxButtons.OK);
                return false;
            }
            else if (txtSoSVToiThieu.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống số sinh viên tối thiểu!", "", MessageBoxButtons.OK);
                return false;
            }
            else if (cmbMaMH.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống môn học!", "", MessageBoxButtons.OK);
                return false;
            }
            else if (cmbMaGV.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống giảng viên!", "", MessageBoxButtons.OK);
                return false;
            }
            else if (cmbNienKhoa.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống niên khóa!", "", MessageBoxButtons.OK);
                return false;
            }
            else if (cmbHocKy.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống học kỳ!", "", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private bool CheckInfoLTC()
        {
            string cmd = "EXEC SP_CHECK_LTC '" + cmbNienKhoa.Text + "', '" + txtMaMH.Text + "', " + txtNhom.Text + ", " + cmbHocKy.Text;
            int check = Lib.checkData(cmd);
            
            if(check == -1)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "", MessageBoxButtons.OK); return false;
            }

            if(check == 1)
            {
                MessageBox.Show("Lớp tín chỉ này đã tồn tại trong khoa này!", "", MessageBoxButtons.OK); return false;
            }

            if (check == 2)
            {
                MessageBox.Show("Lớp tín chỉ này đã tồn tại trong khoa khác!", "", MessageBoxButtons.OK); return false;
            }
            return true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dienHet())
            {
                if (action == "add" && CheckInfoLTC())
                {
                    try
                    {
                        bdsLopTinChi.EndEdit();
                        bdsLopTinChi.ResetCurrentItem();
                        lOPTINCHITableAdapter.Update(DS.LOPTINCHI);
                        undoStack.Push(String.Format("DELETE FROM LOPTINCHI WHERE MALTC = {0}",((DataRowView)bdsLopTinChi[position])["MALTC"]));
                        MessageBox.Show("Thêm thành công! ", "", MessageBoxButtons.OK);
                        loadData();
                        bdsLopTinChi.AddNew();
                        cmbNienKhoa.SelectedItem = cmbHocKy.SelectedItem = null;
                        this.txtMaKhoa.Text = ((DataRowView)bdsLopTinChi[0])["MAKHOA"].ToString();
                        checkHuyLop.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm vào cơ sở dữ liệu! " + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
                else if (MessageBox.Show("Bạn có muốn chắc chắn muốn lưu?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        bdsLopTinChi.EndEdit();
                        bdsLopTinChi.ResetCurrentItem();
                        lOPTINCHITableAdapter.Update(DS.LOPTINCHI);
                        undoStack.Push(String.Format("UPDATE LOPTINCHI SET NIENKHOA = '{0}', " +
                            "HOCKY = {1}, MAMH = '{2}', NHOM = {3}, MAGV = '{4}', MAKHOA = '{5}', SOSVTOITHIEU = {6}, HUYLOP = '{7}'" +
                            " WHERE MALTC = {8}", oldNienKhoa, oldHocKy, oldMaMH, oldNhom, oldMaGV, oldMaKhoa, oldSoSVToiThieu, oldHuyLop, 
                            ((DataRowView)bdsLopTinChi[bdsLopTinChi.Position])["MALTC"]));
                        MessageBox.Show("Sửa thành công! ", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh lớp tín chỉ! " + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (undoStack.Count > 0) btnPhucHoi.Enabled = true;
                else btnPhucHoi.Enabled = false;
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
            else
            {
                loadData();
            }
        }

        private void loadKhoa()
        {
            Lib.BDataToCmb(this.cmbKhoa, Program.bds_dspm.DataSource);
            Program.bds_dspm.Filter = "TENKHOA <> 'HỌC PHÍ'";

        }

        private void loadHocKy()
        {
            cmbHocKy.Items.Add(1);
            cmbHocKy.Items.Add(2);
            cmbHocKy.Items.Add(3);
            cmbHocKy.Items.Add(4);
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy!", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            enableButton(false);
            gcLopTinChi.Enabled = true;
            if (action.Equals("add")) bdsLopTinChi.RemoveCurrent();
            else if (action.Equals("edit")) bdsLopTinChi.CancelEdit();
            bdsLopTinChi.Position = position;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Thoát sẽ không thể phục hồi lại!!\nBạn có muốn thoát??", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = "edit";
            oldNienKhoa = cmbNienKhoa.Text;
            oldHocKy = cmbHocKy.Text;
            oldMaMH = txtMaMH.Text;
            oldNhom = txtNhom.Text;
            oldMaGV = txtMaGV.Text;
            oldMaKhoa = txtMaKhoa.Text;
            oldSoSVToiThieu = txtSoSVToiThieu.Text;
            oldHuyLop = checkHuyLop.Checked.ToString();
            enableButton(true);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = 0;
            loadData();
            MessageBox.Show("Làm mới dữ liệu thành công!", "", MessageBoxButtons.OK);
        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMaMH.SelectedValue != null)
             txtMaMH.Text = cmbMaMH.SelectedValue.ToString();
       
        }

        private void cmbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaMH.SelectedValue != null)
                txtMaGV.Text = cmbMaGV.SelectedValue.ToString();
        }

       
        private void gvLopTinChi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gvLopTinChi.GetFocusedDataRow();
            if (data == null) return;
            cmbMaMH.SelectedValue = data["MAMH"];
            cmbMaGV.SelectedValue = data["MAGV"];
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cmd = undoStack.Pop();
            int vitri = bdsLopTinChi.Position; 
            Program.ExecSqlNonQuery(cmd);
            loadData();
            if (action == "edit") bdsLopTinChi.Position = vitri;
            else if (action == "add")
            {
                if (bdsLopTinChi.Count == 0) return;
                else if (bdsLopTinChi.Count >= vitri) bdsLopTinChi.Position = vitri;
            }
            if (undoStack.Count == 0) btnPhucHoi.Enabled = false;
        }

        private void loadNienKhoa()
        {
            int nam = DateTime.Now.Year;
            string nk = (nam - 1) + "-" + nam;
            cmbNienKhoa.Items.Add(nk);
            nk = nam + "-" + (nam + 1);
            cmbNienKhoa.Items.Add(nk);
        }

        private void loadMAGV()
        {
            string cmd = "SELECT MAGV, HOTEN = HO + ' ' + TEN  FROM GIANGVIEN";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if(Program.myReader == null)
            {
                MessageBox.Show("Lỗi load data!!!","",MessageBoxButtons.OK);
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("MAGV");
            dt.Columns.Add("HOTEN");

            while (Program.myReader.Read())
            {
                dt.Rows.Add(Program.myReader.GetString(0).Trim(), Program.myReader.GetString(0).Trim() + " | " + Program.myReader.GetString(1).Trim());
            }
            Program.myReader.Close();
            cmbMaGV.DataSource = dt;
            cmbMaGV.DisplayMember = "HOTEN";
            cmbMaGV.ValueMember = "MAGV";
        }

        private void loadMAMH()
        {
            string cmd = "SELECT MAMH, TENMH FROM MONHOC";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if(Program.myReader == null)
            {
                MessageBox.Show("Lỗi load data!!!", "", MessageBoxButtons.OK);
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("MAMH", typeof(string));
            dt.Columns.Add("TENMH", typeof(string));

            while (Program.myReader.Read())
            {
                dt.Rows.Add(Program.myReader.GetString(0).Trim(), Program.myReader.GetString(0).Trim() + " | " + Program.myReader.GetString(1).Trim());
            }
            Program.myReader.Close();
            cmbMaMH.DataSource = dt;
            cmbMaMH.DisplayMember = "TENMH";
            cmbMaMH.ValueMember = "MAMH";
        }

       
        private void loadData()
        {
            // TODO: This line of code loads data into the 'DS.GIANGVIEN' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.Connstr;
            this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.Connstr;
            this.dANGKYTableAdapter.Fill(this.DS.DANGKY);
        }
        

        private void enableButton(Boolean bl)
        {
            pnlLopTinChi.Enabled =  btnHuy.Enabled = btnGhi.Enabled = cmbMaMH.Visible = cmbMaGV.Visible = bl;
            txtMaKhoa.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = !bl;
            if (undoStack.Count > 0) btnPhucHoi.Enabled = true;
            else btnPhucHoi.Enabled = false;
            if (action == "add")
            {
                checkHuyLop.Enabled = gcLopTinChi.Enabled = !bl;
                
            } 
            else if(action == "edit")
            {
                checkHuyLop.Enabled = gcLopTinChi.Enabled = bl;
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsLopTinChi.Position;
            action = "add";            
            enableButton(true);
            bdsLopTinChi.AddNew();
            cmbNienKhoa.SelectedItem = cmbHocKy.SelectedItem = null;
            this.txtMaKhoa.Text = ((DataRowView)bdsLopTinChi[0])["MAKHOA"].ToString();
            checkHuyLop.Checked = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = bdsLopTinChi.Position, tg;
            if (bdsDangKy.Count > 0)
                MessageBox.Show("Lớp tín chỉ này đã có sinh viên đăng ký! Không được xóa!", "", MessageBoxButtons.OK);
            else if (MessageBox.Show("Bạn có chắc muốn xóa lớp tín chỉ này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    oldNienKhoa = cmbNienKhoa.Text.Trim();
                    oldHocKy = cmbHocKy.Text.Trim();
                    oldMaMH = txtMaMH.Text;
                    oldNhom = txtNhom.Text;
                    oldMaGV = txtMaGV.Text;
                    oldMaKhoa = txtMaKhoa.Text;
                    oldSoSVToiThieu = txtSoSVToiThieu.Text;
                    oldHuyLop = checkHuyLop.Checked.ToString();
                    bdsLopTinChi.RemoveCurrent();
                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.lOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
                    undoStack.Push(string.Format("INSERT INTO LOPTINCHI (NIENKHOA, HOCKY, MAMH, NHOM, MAGV, MAKHOA, SOSVTOITHIEU, HUYLOP) " +
                        "VALUES ('{0}', {1}, '{2}', {3}, '{4}', '{5}', {6}, '{7}')", oldNienKhoa, oldHocKy, oldMaMH, oldNhom, oldMaGV, oldMaKhoa,
                        oldSoSVToiThieu, oldHuyLop));
                    tg = bdsLopTinChi.Count;
                    if (tg > 1 && tg >= vitri)
                        bdsLopTinChi.Position = vitri - 1;
                    else if (tg == 1) bdsLopTinChi.Position = 0;
                    else btnXoa.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp tín chỉ!!\n Vui lòng thử lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    loadData();
                    return;
                }
                
            }
            if (undoStack.Count == 0) btnPhucHoi.Enabled = false;
            else btnPhucHoi.Enabled = true;
        }
    }
}
