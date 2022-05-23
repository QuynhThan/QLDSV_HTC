
namespace QLDSV_HTC.Forms
{
    partial class frmBangDiemTK
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new System.Windows.Forms.Button();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.lbKhoa);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.lbMaLop);
            this.panelControl1.Controls.Add(this.cmbMaLop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1110, 176);
            this.panelControl1.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIn.Location = new System.Drawing.Point(509, 141);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 30);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbMaLop.Location = new System.Drawing.Point(338, 86);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(86, 26);
            this.lbMaLop.TabIndex = 1;
            this.lbMaLop.Text = "Mã lớp";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(509, 90);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(212, 24);
            this.cmbMaLop.TabIndex = 0;
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbKhoa.Location = new System.Drawing.Point(338, 42);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(68, 26);
            this.lbKhoa.TabIndex = 3;
            this.lbKhoa.Text = "Khoa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(509, 46);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(212, 24);
            this.cmbKhoa.TabIndex = 4;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // frmBangDiemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 554);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmBangDiemTK";
            this.Text = "frmBangDiemTK";
            this.Load += new System.EventHandler(this.frmBangDiemTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lbKhoa;
    }
}