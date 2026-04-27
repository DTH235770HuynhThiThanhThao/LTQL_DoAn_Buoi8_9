namespace QuanLyTiemGiaoHoa.Forms
{
    partial class frmChiTiet_PhieuNhap
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnInPhieuNhap = new Button();
            btnLuuPhieuNhap = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            HoaID = new DataGridViewTextBoxColumn();
            TenHoa = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnXacNhanNhap = new Button();
            numSoLuongNhap = new NumericUpDown();
            label6 = new Label();
            numDonGiaNhap = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            cboHoa = new ComboBox();
            label12 = new Label();
            cboNhaCungCap = new ComboBox();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtpNgayNhap = new DateTimePicker();
            txtGhiChuPhieuNhap = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaNhap).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(737, 690);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(110, 36);
            btnNhap.TabIndex = 18;
            btnNhap.Text = "Nhập Excel...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(871, 690);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(103, 36);
            btnXuat.TabIndex = 19;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(612, 690);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 36);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Location = new Point(432, 690);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(157, 36);
            btnInPhieuNhap.TabIndex = 15;
            btnInPhieuNhap.Text = "In phiếu nhập";
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.Location = new Point(245, 690);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(157, 36);
            btnLuuPhieuNhap.TabIndex = 16;
            btnLuuPhieuNhap.Text = "Lưu phiếu nhập";
            btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanNhap);
            groupBox2.Controls.Add(numSoLuongNhap);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numDonGiaNhap);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboHoa);
            groupBox2.Location = new Point(13, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1240, 470);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HoaID, TenHoa, DonGiaNhap, SoLuongNhap, ThanhTien });
            dataGridView.Location = new Point(8, 109);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1225, 354);
            dataGridView.TabIndex = 5;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // HoaID
            // 
            HoaID.DataPropertyName = "HoaID";
            HoaID.FillWeight = 65.8070755F;
            HoaID.HeaderText = "ID";
            HoaID.MinimumWidth = 6;
            HoaID.Name = "HoaID";
            // 
            // TenHoa
            // 
            TenHoa.DataPropertyName = "TenHoa";
            TenHoa.FillWeight = 188.646927F;
            TenHoa.HeaderText = "Tên hoa";
            TenHoa.MinimumWidth = 6;
            TenHoa.Name = "TenHoa";
            // 
            // DonGiaNhap
            // 
            DonGiaNhap.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle1.Format = "N0";
            DonGiaNhap.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaNhap.FillWeight = 80.2139053F;
            DonGiaNhap.HeaderText = "Đơn giá nhập";
            DonGiaNhap.MinimumWidth = 6;
            DonGiaNhap.Name = "DonGiaNhap";
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            SoLuongNhap.FillWeight = 70.4085F;
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 6;
            SoLuongNhap.Name = "SoLuongNhap";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle2.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle2;
            ThanhTien.FillWeight = 94.92357F;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1089, 54);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 38);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanNhap
            // 
            btnXacNhanNhap.Location = new Point(913, 54);
            btnXacNhanNhap.Name = "btnXacNhanNhap";
            btnXacNhanNhap.Size = new Size(157, 38);
            btnXacNhanNhap.TabIndex = 3;
            btnXacNhanNhap.Text = "Xác nhận nhập";
            btnXacNhanNhap.UseVisualStyleBackColor = true;
            btnXacNhanNhap.Click += btnXacNhanNhap_Click;
            // 
            // numSoLuongNhap
            // 
            numSoLuongNhap.Location = new Point(705, 62);
            numSoLuongNhap.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongNhap.Name = "numSoLuongNhap";
            numSoLuongNhap.Size = new Size(165, 30);
            numSoLuongNhap.TabIndex = 2;
            numSoLuongNhap.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(705, 36);
            label6.Name = "label6";
            label6.Size = new Size(153, 22);
            label6.TabIndex = 0;
            label6.Text = "Số lượng nhập(*):";
            // 
            // numDonGiaNhap
            // 
            numDonGiaNhap.Location = new Point(509, 60);
            numDonGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaNhap.Name = "numDonGiaNhap";
            numDonGiaNhap.Size = new Size(165, 30);
            numDonGiaNhap.TabIndex = 2;
            numDonGiaNhap.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(509, 35);
            label5.Name = "label5";
            label5.Size = new Size(144, 22);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá nhập(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 36);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 0;
            label4.Text = "Hoa(*):";
            // 
            // cboHoa
            // 
            cboHoa.FormattingEnabled = true;
            cboHoa.Location = new Point(7, 62);
            cboHoa.Name = "cboHoa";
            cboHoa.Size = new Size(459, 30);
            cboHoa.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(786, 33);
            label12.Name = "label12";
            label12.Size = new Size(122, 22);
            label12.TabIndex = 0;
            label12.Text = "Ngày nhập(*):";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(161, 79);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(425, 30);
            cboNhaCungCap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 82);
            label2.Name = "label2";
            label2.Size = new Size(145, 22);
            label2.TabIndex = 0;
            label2.Text = "Nhà cung cấp(*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(161, 30);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(425, 30);
            cboNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 143);
            label3.Name = "label3";
            label3.Size = new Size(146, 22);
            label3.TabIndex = 0;
            label3.Text = "Ghi chú hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 38);
            label1.Name = "label1";
            label1.Size = new Size(149, 22);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập(*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(txtGhiChuPhieuNhap);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1240, 183);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(917, 26);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(242, 30);
            dtpNgayNhap.TabIndex = 4;
            // 
            // txtGhiChuPhieuNhap
            // 
            txtGhiChuPhieuNhap.Location = new Point(160, 134);
            txtGhiChuPhieuNhap.Name = "txtGhiChuPhieuNhap";
            txtGhiChuPhieuNhap.Size = new Size(426, 30);
            txtGhiChuPhieuNhap.TabIndex = 2;
            // 
            // frmChiTiet_PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 760);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(btnThoat);
            Controls.Add(btnInPhieuNhap);
            Controls.Add(btnLuuPhieuNhap);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChiTiet_PhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            Load += frmChiTiet_PhieuNhap_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaNhap).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnInPhieuNhap;
        private Button btnLuuPhieuNhap;
        private DateTimePicker dtpNgayGiao;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Button btnXoa;
        private Button btnXacNhanNhap;
        private NumericUpDown numSoLuongNhap;
        private Label label6;
        private NumericUpDown numDonGiaNhap;
        private Label label5;
        private Label label4;
        private ComboBox cboHoa;
        private TextBox txtGhiChuHoaDon;
        private Label label12;
        private ComboBox cboNhaCungCap;
        private Label label2;
        private ComboBox cboNhanVien;
        private Label label3;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtGhiChuPhieuNhap;
        private DataGridViewTextBoxColumn HoaID;
        private DataGridViewTextBoxColumn TenHoa;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}