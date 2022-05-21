
namespace QLDSV_HTC.Forms
{
    partial class frmBaoCaoPhieuDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnInPhieuDiem = new DevExpress.XtraEditors.SimpleButton();
            this.KHOA = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaSV
            // 
            this.txtMaSV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaSV.Location = new System.Drawing.Point(139, 109);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(206, 20);
            this.txtMaSV.TabIndex = 0;
            this.txtMaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSV_KeyPress);
            // 
            // btnInPhieuDiem
            // 
            this.btnInPhieuDiem.Location = new System.Drawing.Point(139, 151);
            this.btnInPhieuDiem.Name = "btnInPhieuDiem";
            this.btnInPhieuDiem.Size = new System.Drawing.Size(98, 23);
            this.btnInPhieuDiem.TabIndex = 1;
            this.btnInPhieuDiem.Text = "In phiếu điểm";
            this.btnInPhieuDiem.Click += new System.EventHandler(this.btnInPhieuDiem_Click);
            // 
            // KHOA
            // 
            this.KHOA.AutoSize = true;
            this.KHOA.Location = new System.Drawing.Point(96, 85);
            this.KHOA.Name = "KHOA";
            this.KHOA.Size = new System.Drawing.Size(37, 13);
            this.KHOA.TabIndex = 5;
            this.KHOA.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(139, 82);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(272, 21);
            this.cmbKhoa.TabIndex = 4;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(96, 112);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(39, 13);
            this.lblMaSV.TabIndex = 6;
            this.lblMaSV.Text = "Mã SV\r\n";
            // 
            // frmBaoCaoPhieuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.KHOA);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.btnInPhieuDiem);
            this.Controls.Add(this.txtMaSV);
            this.Name = "frmBaoCaoPhieuDiem";
            this.Text = "frmPhieuDiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSV;
        private DevExpress.XtraEditors.SimpleButton btnInPhieuDiem;
        private System.Windows.Forms.Label KHOA;
        public System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblMaSV;
    }
}