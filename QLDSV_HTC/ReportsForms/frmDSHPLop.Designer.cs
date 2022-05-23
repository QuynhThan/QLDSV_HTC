
namespace QLDSV_HTC.Forms
{
    partial class frmDSHPLop
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
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.lbHK = new System.Windows.Forms.Label();
            this.lbNienKhoa = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.cmbHocKy);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.cmbMaLop);
            this.panelControl1.Controls.Add(this.lbHK);
            this.panelControl1.Controls.Add(this.lbNienKhoa);
            this.panelControl1.Controls.Add(this.lbMaLop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 230);
            this.panelControl1.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIn.Location = new System.Drawing.Point(527, 168);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(90, 34);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbHocKy.Location = new System.Drawing.Point(472, 112);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(224, 24);
            this.cmbHocKy.TabIndex = 5;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(472, 63);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(224, 24);
            this.cmbNienKhoa.TabIndex = 4;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(472, 12);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(224, 24);
            this.cmbMaLop.TabIndex = 3;
            this.cmbMaLop.SelectedIndexChanged += new System.EventHandler(this.cmbMaLop_SelectedIndexChanged);
            // 
            // lbHK
            // 
            this.lbHK.AutoSize = true;
            this.lbHK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbHK.Location = new System.Drawing.Point(294, 110);
            this.lbHK.Name = "lbHK";
            this.lbHK.Size = new System.Drawing.Size(85, 26);
            this.lbHK.TabIndex = 2;
            this.lbHK.Text = "Học kỳ";
            this.lbHK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNienKhoa
            // 
            this.lbNienKhoa.AutoSize = true;
            this.lbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbNienKhoa.Location = new System.Drawing.Point(293, 63);
            this.lbNienKhoa.Name = "lbNienKhoa";
            this.lbNienKhoa.Size = new System.Drawing.Size(116, 26);
            this.lbNienKhoa.TabIndex = 1;
            this.lbNienKhoa.Text = "Niên khóa";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(293, 16);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(92, 26);
            this.lbMaLop.TabIndex = 0;
            this.lbMaLop.Text = "Mã lớp ";
            // 
            // frmDSHPLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1084, 540);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDSHPLop";
            this.Text = "DSHPLop";
            this.Load += new System.EventHandler(this.frmDSHPLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Label lbHK;
        private System.Windows.Forms.Label lbNienKhoa;
        private System.Windows.Forms.Label lbMaLop;
    }
}