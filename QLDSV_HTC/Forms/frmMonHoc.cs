using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;

namespace QLDSV_HTC.Forms
{
    public partial class frmMonHoc : Form
    {
        private string action = "";
        string oldMaMH, oldTenMH, oldSoTietLT, oldSoTietTH;
        Stack<string> undoStack = new Stack<string>();

        public frmMonHoc()
        {
            InitializeComponent();
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                DS.EnforceConstraints = false;
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.Connstr;
                this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.Connstr;
                this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
                enabledButton(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu! " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void fillData()
        {
            DS.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.Connstr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.Connstr;
            this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enabledButton(false);
            gcMonHoc.Enabled = false;
            if (undoStack.Count == 0) btnPhucHoi.Enabled = false;
            action = "add";
            //vitri = bdsMONHOC.Position;
            bdsMONHOC.AddNew();
        }
        private void enabledButton(Boolean kt)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = kt;
            pnlMonHoc.Enabled = btnGhi.Enabled = btnHuy.Enabled = !kt;
            btnReload.Enabled = true;
            if (undoStack.Count > 0) btnPhucHoi.Enabled = true;
            else btnPhucHoi.Enabled = false;
        }
        private int check_MaMH()
        {
            if(bdsMONHOC.Find("MAMH", txtMaMonHoc.Text) != -1)
            {
                MessageBox.Show("Mã môn học đã tồn tại!", "", MessageBoxButtons.OK);
                return 0;
            }
            else if(bdsMONHOC.Find("TENMH", txtTenMonHoc.Text) != -1)
            {
                MessageBox.Show("Tên môn học đã tồn tại!", "", MessageBoxButtons.OK);
                return 0;
            }
            return 1;
        }
        private void barButtonGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraDienThongTin())
            {
                return;
            }
            string message = "";
            if (action == "add" && check_MaMH() == 1) message = "Bạn có muốn thêm môn học này vào cơ sở dữ liệu?";
            else message = "Bạn có muốn hiệu chỉnh môn học này?";
            if (MessageBox.Show(message,"", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsMONHOC.EndEdit();
                    bdsMONHOC.ResetCurrentItem();
                    MONHOCTableAdapter.Update(DS.MONHOC);
                    
                    if(action=="add")
                    {
                        undoStack.Push(String.Format("DELETE FROM MONHOC WHERE MAMH = '{0}'", txtMaMonHoc.Text.Trim()));
                        MessageBox.Show("Thêm vào thành công!", "", MessageBoxButtons.OK);
                        bdsMONHOC.AddNew();
                        txtMaMonHoc.Focus();
                    }

                    else 
                    {
                        undoStack.Push(String.Format("UPDATE MONHOC SET MAMH = '{0}', TENMH = N'{1}', SOTIET_LT = {2}, SOTIET_TH = {3}  WHERE MAMH = '{4}'",
                            oldMaMH, oldTenMH, oldSoTietLT, oldSoTietTH, txtMaMonHoc.Text.Trim()));
                        MessageBox.Show("Sửa thành công!", "", MessageBoxButtons.OK);
                        enabledButton(true);
                    }
                    if(undoStack.Count > 0)
                        btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm hoặc hiệu chỉnh môn học!" + ex.Message,"", MessageBoxButtons.OK);
                }
            }
        }
        private Boolean kiemTraDienThongTin()
        {
            if (txtMaMonHoc.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Mã môn học!", "", MessageBoxButtons.OK);
                return true;
            }
            else if(txtSoTietLyThuyet.Text.Equals("")){
                MessageBox.Show("Không được để trống Số tiết lý thuyết!", "", MessageBoxButtons.OK);
                return true;
            }
            else if (txtSoTietThucHanh.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Số tiết thực hành!", "", MessageBoxButtons.OK);
                return true;
            }
            else if (txtTenMonHoc.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên môn học!", "", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát??", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            this.Close();
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn hủy?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (action == "add") bdsMONHOC.RemoveCurrent();
                if (action == "edit") bdsMONHOC.CancelEdit();
                fillData();
                enabledButton(true);
                gcMonHoc.Enabled = true;
            }
        }

        

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = bdsMONHOC.Position;
            string cmd = undoStack.Pop();
            try
            {
                Program.ExecSqlNonQuery(cmd);
                fillData();
                bdsMONHOC.Position = vitri;
                if (undoStack.Count == 0) btnPhucHoi.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phục hồi môn học! " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = bdsMONHOC.Position,tg;
            if(bdsLOPTINCHI.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì môn học đã tồn tại trong lớp tín chỉ", "", MessageBoxButtons.OK);
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    oldMaMH = txtMaMonHoc.Text;
                    oldTenMH = txtTenMonHoc.Text;
                    oldSoTietLT = txtSoTietLyThuyet.Text;
                    oldSoTietTH = txtSoTietThucHanh.Text;
                    bdsMONHOC.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                    undoStack.Push(string.Format("INSERT INTO MONHOC (MAMH, TENMH, SOTIET_LT, SOTIET_TH) " +
                        "VALUES ('{0}', {1}, '{2}', {3})", oldMaMH, oldTenMH, oldSoTietLT, oldSoTietTH));
                    tg = bdsMONHOC.Count;
                    if (tg > 1 && tg >= vitri)
                        bdsMONHOC.Position = vitri - 1;
                    else if (tg == 1) bdsMONHOC.Position = 0;
                    else btnXoa.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
                    bdsMONHOC.Position = bdsMONHOC.Find("MAMH", oldMaMH);
                }
            }
            if (undoStack.Count == 0) btnPhucHoi.Enabled = false;
            else btnPhucHoi.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enabledButton(false);
            action = "edit";
            gcMonHoc.Enabled = true;
            oldMaMH = txtMaMonHoc.Text;
            oldTenMH = txtTenMonHoc.Text;
            oldSoTietLT = txtSoTietLyThuyet.Text;
            oldSoTietTH = txtSoTietThucHanh.Text;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                fillData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu!" + ex.Message, "", MessageBoxButtons.OK);
            }
            
        }
    }
}
