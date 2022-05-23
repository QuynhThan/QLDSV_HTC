using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        string nk;
        int hk;
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            string cmd = "SELECT HO + ' ' +  TEN AS HOTEN, TENLOP FROM SINHVIEN,LOP WHERE SINHVIEN.MALOP = LOP.MALOP AND MASV = " + "'" + txtMaSV.Text.Trim() + "' AND DANGHIHOC = 'FALSE'";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader.HasRows)
            {
                while (Program.myReader.Read())
                {
                    txtTenSV.Text = Program.myReader.GetString(0);
                    txtMaLop.Text = Program.myReader.GetString(1);
                }
            }
            else
            {
                txtTenSV.Text ="";
                txtMaLop.Text = "";
            }

            Program.myReader.Close();
        }


        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == null)
                return;
            this.sP_DSHOCPHITableAdapter.Connection.ConnectionString = Program.Connstr;
            this.sP_DSHOCPHITableAdapter.Fill(this.DS.SP_DSHOCPHI, txtMaSV.Text.Trim());
        }

        private void sP_DSHOCPHIGridControl_Click_1(object sender, EventArgs e)
        {
            if(gridView1.IsEmpty || txtNienKhoa.Text == "" || txtHK.Text == "" || txtHP.Text == "")
            {
                return;
            }
            nk = ((DataRowView)bdsDSHOCPHI[bdsDSHOCPHI.Position])["Niên khóa"].ToString();
            hk = int.Parse(((DataRowView)bdsDSHOCPHI[bdsDSHOCPHI.Position])["Học kỳ"].ToString());
            this.sP_CTHOCPHITableAdapter.Connection.ConnectionString = Program.Connstr;
            this.sP_CTHOCPHITableAdapter.Fill(this.DS.SP_CTHOCPHI,txtMaSV.Text.Trim(), nk, hk);
        }

        private void btnThemCTHP_Click(object sender, EventArgs e)
        {
            bdsCTHP.AddNew();
            gridView1.UnselectRow(bdsDSHOCPHI.Position);
            //btnThemCTHP.Enabled = false;
            
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //bat loi rang buoc

            //
            if(int.Parse(gridView2.GetFocusedRowCellValue("SOTIENDONG").ToString()) < 0 || int.Parse(gridView2.GetFocusedRowCellValue("SOTIENDONG").ToString()) >( int.Parse(((DataRowView)bdsDSHOCPHI[bdsDSHOCPHI.Position])["Học phí"].ToString()) - int.Parse(((DataRowView)bdsDSHOCPHI[bdsDSHOCPHI.Position])["Tổng số tiền đóng"].ToString()) ) )
            {
                MessageBox.Show("Só tiền không hợp lệ?", "", MessageBoxButtons.OKCancel);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn lưu?", "",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    String cmd = "INSERT INTO CT_DONGHOCPHI(MASV, NIENKHOA, HOCKY, NGAYDONG, SOTIENDONG) VALUES ('" + txtMaSV.Text.Trim() + "','" 
                        + txtNienKhoa.Text.Trim() + "'," + txtHK.Text.Trim().Replace(",", string.Empty) +",'"
                        + DateTime.Now.ToString("yyyy-MM-dd")+"',"
                        + gridView2.GetFocusedRowCellValue("SOTIENDONG") +")";
                    MessageBox.Show(cmd, "", MessageBoxButtons.OK);
                    Program.ExecSqlNonQuery(cmd);
                    this.sP_DSHOCPHITableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.sP_DSHOCPHITableAdapter.Fill(this.DS.SP_DSHOCPHI, txtMaSV.Text.Trim());
                    this.sP_CTHOCPHITableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.sP_CTHOCPHITableAdapter.Fill(this.DS.SP_CTHOCPHI, txtMaSV.Text.Trim(), nk, hk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm vào csdl!!" + ex.Message, "", MessageBoxButtons.OK);

                    return;

                }

            }
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["NGAYDONG"], DateTime.Today);
            
        }

        private void btnThemHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sP_DSHOCPHITableAdapter.Connection.ConnectionString = Program.Connstr;
            this.sP_DSHOCPHITableAdapter.Fill(this.DS.SP_DSHOCPHI, txtMaSV.Text.Trim());
            bdsDSHOCPHI.AddNew();
        }

        private void btnGhiHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn lưu?", "",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    String cmd = "INSERT INTO HOCPHI(MASV,NIENKHOA,HOCKY,HOCPHI) VALUES('" + txtMaSV.Text.Trim() + "','" + txtNienKhoa.Text.Trim() + "'," + txtHK.Text.Trim().Replace(",", string.Empty) + ","+ txtHP.Text.Trim().Replace(",", string.Empty).Replace("." +
                        "", string.Empty)+ ")";
                    //String cmd = "EXEC SP_THEMHP '" + txtMaSV.Text.Trim() + "','" + txtNienKhoa.Text.Trim()+ "'," + txtHK.Text.Trim().Replace(",",string.Empty) + "," + txtHP.Text.Trim().Replace(",", string.Empty).Replace("." +
                    //"", string.Empty);
                    MessageBox.Show(cmd , "", MessageBoxButtons.OK);
                    Program.ExecSqlNonQuery(cmd);
                    this.sP_DSHOCPHITableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.sP_DSHOCPHITableAdapter.Fill(this.DS.SP_DSHOCPHI, txtMaSV.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm vào csdl!!" + ex.Message, "", MessageBoxButtons.OK);

                    return;

                }

            }
        }


        private void gridView2_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["NGAYDONG"], DateTime.Today);
        }

        private void txtNienKhoa_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.RowCount, gridView2.Columns["Niên khóa"], txtNienKhoa.Text.Trim());
        }

        private void txtHK_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.RowCount, gridView2.Columns["Học kỳ"], txtHK.Text.Trim());
        }

        private void txtHP_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.SetRowCellValue(gridView1.RowCount, gridView2.Columns["Học phí"],txtHP.Text.Trim());
            gridView1.SetRowCellValue(gridView1.RowCount, gridView2.Columns["Tổng số tiền đã đóng"], 0);
        }

        private void btnXoaHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (int.Parse(((DataRowView)bdsDSHOCPHI[bdsDSHOCPHI.Position])["Tổng số tiền đóng"].ToString()) > 0)
            {
                MessageBox.Show("Sinh viên đã đóng học phí rồi!\n Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    String cmd = "DELETE FROM HOCPHI WHERE MASV = '" + txtMaSV.Text.Trim() + "' AND NIENKHOA = '" + txtNienKhoa.Text.Trim() + "' AND HOCKY = '" + txtHK.Text.Trim() + "'";
                    Program.ExecSqlNonQuery(cmd);
                    this.sP_DSHOCPHITableAdapter.Connection.ConnectionString = Program.Connstr;
                    this.sP_DSHOCPHITableAdapter.Fill(this.DS.SP_DSHOCPHI, txtMaSV.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa HP!!\n Vui lòng thử lại!", "", MessageBoxButtons.OK);
                    return;
                }
            } 

        }

    }
}