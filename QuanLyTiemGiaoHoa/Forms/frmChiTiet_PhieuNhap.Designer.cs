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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            btnNhap.Location = new Point(670, 627);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(100, 33);
            btnNhap.TabIndex = 18;
            btnNhap.Text = "Nhập Excel...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(792, 627);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 33);
            btnXuat.TabIndex = 19;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(556, 627);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 33);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Location = new Point(393, 627);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(143, 33);
            btnInPhieuNhap.TabIndex = 15;
            btnInPhieuNhap.Text = "In phiếu nhập";
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.Location = new Point(223, 627);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(143, 33);
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
            groupBox2.Location = new Point(12, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1127, 427);
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
            dataGridView.Location = new Point(7, 99);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1114, 322);
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
            dataGridViewCellStyle3.Format = "N0";
            DonGiaNhap.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            ThanhTien.FillWeight = 94.92357F;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(990, 49);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 35);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanNhap
            // 
            btnXacNhanNhap.Location = new Point(830, 49);
            btnXacNhanNhap.Name = "btnXacNhanNhap";
            btnXacNhanNhap.Size = new Size(143, 35);
            btnXacNhanNhap.TabIndex = 3;
            btnXacNhanNhap.Text = "Xác nhận nhập";
            btnXacNhanNhap.UseVisualStyleBackColor = true;
            btnXacNhanNhap.Click += btnXacNhanNhap_Click;
            // 
            // numSoLuongNhap
            // 
            numSoLuongNhap.Location = new Point(641, 56);
            numSoLuongNhap.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongNhap.Name = "numSoLuongNhap";
            numSoLuongNhap.Size = new Size(150, 28);
            numSoLuongNhap.TabIndex = 2;
            numSoLuongNhap.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(641, 33);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 0;
            label6.Text = "Số lượng nhập(*):";
            // 
            // numDonGiaNhap
            // 
            numDonGiaNhap.Location = new Point(463, 55);
            numDonGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaNhap.Name = "numDonGiaNhap";
            numDonGiaNhap.Size = new Size(150, 28);
            numDonGiaNhap.TabIndex = 2;
            numDonGiaNhap.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 32);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá nhập(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 33);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 0;
            label4.Text = "Hoa(*):";
            // 
            // cboHoa
            // 
            cboHoa.FormattingEnabled = true;
            cboHoa.Location = new Point(6, 56);
            cboHoa.Name = "cboHoa";
            cboHoa.Size = new Size(418, 28);
            cboHoa.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(715, 30);
            label12.Name = "label12";
            label12.Size = new Size(112, 20);
            label12.TabIndex = 0;
            label12.Text = "Ngày nhập(*):";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(146, 72);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(387, 28);
            cboNhaCungCap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 75);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhà cung cấp(*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(146, 27);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(387, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 130);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 0;
            label3.Text = "Ghi chú hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
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
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1127, 166);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(834, 24);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(220, 28);
            dtpNgayNhap.TabIndex = 4;
            // 
            // txtGhiChuPhieuNhap
            // 
            txtGhiChuPhieuNhap.Location = new Point(145, 122);
            txtGhiChuPhieuNhap.Name = "txtGhiChuPhieuNhap";
            txtGhiChuPhieuNhap.Size = new Size(388, 28);
            txtGhiChuPhieuNhap.TabIndex = 2;
            // 
            // frmChiTiet_PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 691);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(btnThoat);
            Controls.Add(btnInPhieuNhap);
            Controls.Add(btnLuuPhieuNhap);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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