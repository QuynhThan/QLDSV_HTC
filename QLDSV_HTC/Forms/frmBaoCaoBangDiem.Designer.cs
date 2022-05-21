
namespace QLDSV_HTC.Forms
{
    partial class frmBaoCaoBangDiem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label mAMHLabel1;
            System.Windows.Forms.Label lblNhom;
            this.KHOA = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV_HTC.DS();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.txtNhom = new System.Windows.Forms.TextBox();
            this.mONHOCTableAdapter = new QLDSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.lOPTINCHITableAdapter = new QLDSV_HTC.DSTableAdapters.LOPTINCHITableAdapter();
            this.btnInBangDiem = new DevExpress.XtraEditors.SimpleButton();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            mAMHLabel1 = new System.Windows.Forms.Label();
            lblNhom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(70, 116);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(47, 13);
            hOCKYLabel.TabIndex = 29;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(51, 84);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(66, 13);
            nIENKHOALabel.TabIndex = 28;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // mAMHLabel1
            // 
            mAMHLabel1.AutoSize = true;
            mAMHLabel1.Location = new System.Drawing.Point(73, 138);
            mAMHLabel1.Name = "mAMHLabel1";
            mAMHLabel1.Size = new System.Drawing.Size(43, 13);
            mAMHLabel1.TabIndex = 34;
            mAMHLabel1.Text = "MAMH:";
            // 
            // lblNhom
            // 
            lblNhom.AutoSize = true;
            lblNhom.Location = new System.Drawing.Point(73, 165);
            lblNhom.Name = "lblNhom";
            lblNhom.Size = new System.Drawing.Size(43, 13);
            lblNhom.TabIndex = 32;
            lblNhom.Text = "NHÓM:";
            // 
            // KHOA
            // 
            this.KHOA.AutoSize = true;
            this.KHOA.Location = new System.Drawing.Point(77, 57);
            this.KHOA.Name = "KHOA";
            this.KHOA.Size = new System.Drawing.Size(37, 13);
            this.KHOA.TabIndex = 3;
            this.KHOA.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(120, 54);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(272, 21);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(120, 108);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(181, 21);
            this.cmbHocKy.TabIndex = 31;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLTC, "NIENKHOA", true));
            this.cmbNienKhoa.DataSource = this.bdsLTC;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(120, 81);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(181, 21);
            this.cmbNienKhoa.TabIndex = 30;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "LOPTINCHI";
            this.bdsLTC.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.bdsMH;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(120, 135);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(181, 21);
            this.cmbTenMH.TabIndex = 35;
            this.cmbTenMH.ValueMember = "TENMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // txtNhom
            // 
            this.txtNhom.Location = new System.Drawing.Point(120, 162);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(181, 20);
            this.txtNhom.TabIndex = 33;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // btnInBangDiem
            // 
            this.btnInBangDiem.Location = new System.Drawing.Point(130, 204);
            this.btnInBangDiem.Name = "btnInBangDiem";
            this.btnInBangDiem.Size = new System.Drawing.Size(75, 23);
            this.btnInBangDiem.TabIndex = 36;
            this.btnInBangDiem.Text = "In bảng điểm";
            this.btnInBangDiem.Click += new System.EventHandler(this.btnInBangDiem_Click);
            // 
            // frmBaoCaoBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 582);
            this.Controls.Add(this.btnInBangDiem);
            this.Controls.Add(this.cmbTenMH);
            this.Controls.Add(mAMHLabel1);
            this.Controls.Add(lblNhom);
            this.Controls.Add(this.txtNhom);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.KHOA);
            this.Controls.Add(this.cmbKhoa);
            this.Name = "frmBaoCaoBangDiem";
            this.Text = "frmBaoCaoBangDiem";
            this.Load += new System.EventHandler(this.frmBaoCaoBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KHOA;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsLTC;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        public System.Windows.Forms.ComboBox cmbKhoa;
        public System.Windows.Forms.ComboBox cmbHocKy;
        public System.Windows.Forms.ComboBox cmbNienKhoa;
        public System.Windows.Forms.ComboBox cmbTenMH;
        public System.Windows.Forms.TextBox txtNhom;
        public DevExpress.XtraEditors.SimpleButton btnInBangDiem;
    }
}