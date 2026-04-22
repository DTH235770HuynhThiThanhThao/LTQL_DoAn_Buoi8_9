namespace QuanLyTiemGiaoHoa.Forms
{
    partial class frmHoaDon_ChiTiet
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
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numSoLuongBan = new NumericUpDown();
            label6 = new Label();
            numDonGiaBan = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            cboHoa = new ComboBox();
            groupBox1 = new GroupBox();
            dtpNgayLap = new DateTimePicker();
            cboTrangThaiGiao = new ComboBox();
            label8 = new Label();
            numPhiGiaoHang = new NumericUpDown();
            label7 = new Label();
            txtGhiChuHoaDon = new TextBox();
            label12 = new Label();
            cboKhachHang = new ComboBox();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            label11 = new Label();
            txtDiaChiGiao = new TextBox();
            groupBox3 = new GroupBox();
            dtpNgayGiao = new DateTimePicker();
            label9 = new Label();
            txtTenNguoiNhan = new TextBox();
            txtSDTNhan = new TextBox();
            label15 = new Label();
            label13 = new Label();
            HoaID = new DataGridViewTextBoxColumn();
            TenHoa = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPhiGiaoHang).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboHoa);
            groupBox2.Location = new Point(12, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1127, 427);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HoaID, TenHoa, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Location = new Point(7, 99);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1114, 310);
            dataGridView.TabIndex = 5;
            dataGridView.CellClick += dataGridView_CellClick;
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
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(830, 49);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(143, 35);
            btnXacNhanBan.TabIndex = 3;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(641, 56);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(150, 28);
            numSoLuongBan.TabIndex = 2;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(641, 33);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 0;
            label6.Text = "Số lượng bán(*):";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(463, 55);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(150, 28);
            numDonGiaBan.TabIndex = 2;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 32);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá bán(*):";
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
            cboHoa.SelectionChangeCommitted += cboHoa_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(cboTrangThaiGiao);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(numPhiGiaoHang);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1127, 166);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(849, 72);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(204, 28);
            dtpNgayLap.TabIndex = 10;
            // 
            // cboTrangThaiGiao
            // 
            cboTrangThaiGiao.Enabled = false;
            cboTrangThaiGiao.FormattingEnabled = true;
            cboTrangThaiGiao.Location = new Point(849, 25);
            cboTrangThaiGiao.Name = "cboTrangThaiGiao";
            cboTrangThaiGiao.Size = new Size(204, 28);
            cboTrangThaiGiao.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(663, 33);
            label8.Name = "label8";
            label8.Size = new Size(180, 20);
            label8.TabIndex = 7;
            label8.Text = "Trạng thái giao hàng(*):";
            // 
            // numPhiGiaoHang
            // 
            numPhiGiaoHang.Location = new Point(849, 122);
            numPhiGiaoHang.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPhiGiaoHang.Name = "numPhiGiaoHang";
            numPhiGiaoHang.Size = new Size(204, 28);
            numPhiGiaoHang.TabIndex = 6;
            numPhiGiaoHang.ThousandsSeparator = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(711, 125);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 5;
            label7.Text = "Phí giao hàng(*):";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(145, 122);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(463, 28);
            txtGhiChuHoaDon.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(734, 78);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 0;
            label12.Text = "Ngày lập(*):";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(146, 72);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(387, 28);
            cboKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Khách hàng(*):";
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
            // btnNhap
            // 
            btnNhap.Location = new Point(665, 755);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(100, 33);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập Excel...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(787, 755);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 33);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(551, 755);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 33);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(388, 755);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(143, 33);
            btnInHoaDon.TabIndex = 7;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(218, 755);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(143, 33);
            btnLuuHoaDon.TabIndex = 8;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 84);
            label11.Name = "label11";
            label11.Size = new Size(119, 20);
            label11.TabIndex = 0;
            label11.Text = "Địa chỉ giao(*):";
            // 
            // txtDiaChiGiao
            // 
            txtDiaChiGiao.Location = new Point(146, 76);
            txtDiaChiGiao.Name = "txtDiaChiGiao";
            txtDiaChiGiao.Size = new Size(462, 28);
            txtDiaChiGiao.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpNgayGiao);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtTenNguoiNhan);
            groupBox3.Controls.Add(txtSDTNhan);
            groupBox3.Controls.Add(txtDiaChiGiao);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(12, 180);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1127, 125);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin giao hàng";
            // 
            // dtpNgayGiao
            // 
            dtpNgayGiao.Format = DateTimePickerFormat.Short;
            dtpNgayGiao.Location = new Point(849, 73);
            dtpNgayGiao.Name = "dtpNgayGiao";
            dtpNgayGiao.Size = new Size(204, 28);
            dtpNgayGiao.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(734, 79);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 11;
            label9.Text = "Ngày giao(*):";
            // 
            // txtTenNguoiNhan
            // 
            txtTenNguoiNhan.Location = new Point(145, 27);
            txtTenNguoiNhan.Name = "txtTenNguoiNhan";
            txtTenNguoiNhan.Size = new Size(388, 28);
            txtTenNguoiNhan.TabIndex = 9;
            // 
            // txtSDTNhan
            // 
            txtSDTNhan.Location = new Point(849, 27);
            txtSDTNhan.MaxLength = 10;
            txtSDTNhan.Name = "txtSDTNhan";
            txtSDTNhan.Size = new Size(204, 28);
            txtSDTNhan.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(734, 35);
            label15.Name = "label15";
            label15.Size = new Size(109, 20);
            label15.TabIndex = 0;
            label15.Text = "SĐT nhận(*):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 35);
            label13.Name = "label13";
            label13.Size = new Size(119, 20);
            label13.TabIndex = 0;
            label13.Text = "Người nhận(*):";
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
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.FillWeight = 80.2139053F;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            SoLuongBan.FillWeight = 70.4085F;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
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
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 817);
            Controls.Add(groupBox3);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPhiGiaoHang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numSoLuongBan;
        private Label label6;
        private NumericUpDown numDonGiaBan;
        private Label label5;
        private Label label4;
        private ComboBox cboHoa;
        private GroupBox groupBox1;
        private TextBox txtGhiChuHoaDon;
        private ComboBox cboKhachHang;
        private Label label2;
        private ComboBox cboNhanVien;
        private Label label3;
        private Label label1;
        private NumericUpDown numPhiGiaoHang;
        private Label label7;
        private ComboBox cboTrangThaiGiao;
        private Label label8;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
        private TextBox txtDiaChiGiao;
        private Label label11;
        private DateTimePicker dtpNgayLap;
        private Label label12;
        private GroupBox groupBox3;
        private TextBox txtTenNguoiNhan;
        private TextBox txtSDTNhan;
        private Label label15;
        private Label label13;
        private DateTimePicker dtpNgayGiao;
        private Label label9;
        private DataGridViewTextBoxColumn HoaID;
        private DataGridViewTextBoxColumn TenHoa;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}