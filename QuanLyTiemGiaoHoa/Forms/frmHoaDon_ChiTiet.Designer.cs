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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon_ChiTiet));
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            HoaID = new DataGridViewTextBoxColumn();
            TenHoa = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            imageList1 = new ImageList(components);
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
            helpProvider1 = new HelpProvider();
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
            groupBox2.BackColor = Color.LavenderBlush;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboHoa);
            groupBox2.Location = new Point(13, 342);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1240, 371);
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
            dataGridView.Location = new Point(8, 109);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1225, 253);
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
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 224, 192);
            btnXoa.ForeColor = Color.Red;
            btnXoa.ImageIndex = 8;
            btnXoa.ImageList = imageList1;
            btnXoa.Location = new Point(1089, 54);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 38);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "info.png");
            imageList1.Images.SetKeyName(1, "edit (1).png");
            imageList1.Images.SetKeyName(2, "chart-histogram.png");
            imageList1.Images.SetKeyName(3, "stats.png");
            imageList1.Images.SetKeyName(4, "home (1).png");
            imageList1.Images.SetKeyName(5, "home.png");
            imageList1.Images.SetKeyName(6, "home_1946436.png");
            imageList1.Images.SetKeyName(7, "add.png");
            imageList1.Images.SetKeyName(8, "delete.png");
            imageList1.Images.SetKeyName(9, "edit.png");
            imageList1.Images.SetKeyName(10, "exit.png");
            imageList1.Images.SetKeyName(11, "refresh.png");
            imageList1.Images.SetKeyName(12, "save.png");
            imageList1.Images.SetKeyName(13, "exit (1).png");
            imageList1.Images.SetKeyName(14, "sign-out-alt.png");
            imageList1.Images.SetKeyName(15, "cross-circle.png");
            imageList1.Images.SetKeyName(16, "search.png");
            imageList1.Images.SetKeyName(17, "address-card.png");
            imageList1.Images.SetKeyName(18, "check.png");
            imageList1.Images.SetKeyName(19, "download.png");
            imageList1.Images.SetKeyName(20, "address-card (1).png");
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.BackColor = Color.FromArgb(255, 255, 192);
            btnXacNhanBan.ImageIndex = 18;
            btnXacNhanBan.ImageList = imageList1;
            btnXacNhanBan.Location = new Point(913, 54);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(157, 38);
            btnXacNhanBan.TabIndex = 3;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(705, 62);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(165, 30);
            numSoLuongBan.TabIndex = 2;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(705, 36);
            label6.Name = "label6";
            label6.Size = new Size(144, 22);
            label6.TabIndex = 0;
            label6.Text = "Số lượng bán(*):";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(509, 60);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(165, 30);
            numDonGiaBan.TabIndex = 2;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(509, 35);
            label5.Name = "label5";
            label5.Size = new Size(135, 22);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá bán(*):";
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
            cboHoa.SelectionChangeCommitted += cboHoa_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
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
            groupBox1.Location = new Point(13, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1240, 183);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(934, 79);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(224, 30);
            dtpNgayLap.TabIndex = 10;
            // 
            // cboTrangThaiGiao
            // 
            cboTrangThaiGiao.Enabled = false;
            cboTrangThaiGiao.FormattingEnabled = true;
            cboTrangThaiGiao.Location = new Point(934, 28);
            cboTrangThaiGiao.Name = "cboTrangThaiGiao";
            cboTrangThaiGiao.Size = new Size(224, 30);
            cboTrangThaiGiao.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(729, 36);
            label8.Name = "label8";
            label8.Size = new Size(198, 22);
            label8.TabIndex = 7;
            label8.Text = "Trạng thái giao hàng(*):";
            // 
            // numPhiGiaoHang
            // 
            numPhiGiaoHang.Location = new Point(934, 134);
            numPhiGiaoHang.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPhiGiaoHang.Name = "numPhiGiaoHang";
            numPhiGiaoHang.Size = new Size(224, 30);
            numPhiGiaoHang.TabIndex = 6;
            numPhiGiaoHang.ThousandsSeparator = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(782, 138);
            label7.Name = "label7";
            label7.Size = new Size(145, 22);
            label7.TabIndex = 5;
            label7.Text = "Phí giao hàng(*):";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(160, 134);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(509, 30);
            txtGhiChuHoaDon.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(807, 86);
            label12.Name = "label12";
            label12.Size = new Size(110, 22);
            label12.TabIndex = 0;
            label12.Text = "Ngày lập(*):";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(161, 79);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(425, 30);
            cboKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 0;
            label2.Text = "Khách hàng(*):";
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
            // btnNhap
            // 
            btnNhap.BackColor = Color.PowderBlue;
            btnNhap.ImageIndex = 20;
            btnNhap.ImageList = imageList1;
            btnNhap.Location = new Point(726, 728);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(141, 36);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập Excel";
            btnNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Pink;
            btnXuat.ImageIndex = 13;
            btnXuat.ImageList = imageList1;
            btnXuat.Location = new Point(896, 728);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(134, 36);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.ForeColor = Color.Red;
            btnThoat.ImageIndex = 15;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(600, 728);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 36);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.White;
            btnInHoaDon.ImageIndex = 12;
            btnInHoaDon.ImageList = imageList1;
            btnInHoaDon.Location = new Point(421, 728);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(157, 36);
            btnInHoaDon.TabIndex = 7;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.BackColor = Color.White;
            btnLuuHoaDon.ImageIndex = 19;
            btnLuuHoaDon.ImageList = imageList1;
            btnLuuHoaDon.Location = new Point(234, 728);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(157, 36);
            btnLuuHoaDon.TabIndex = 8;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 92);
            label11.Name = "label11";
            label11.Size = new Size(136, 22);
            label11.TabIndex = 0;
            label11.Text = "Địa chỉ giao(*):";
            // 
            // txtDiaChiGiao
            // 
            txtDiaChiGiao.Location = new Point(161, 84);
            txtDiaChiGiao.Name = "txtDiaChiGiao";
            txtDiaChiGiao.Size = new Size(508, 30);
            txtDiaChiGiao.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LavenderBlush;
            groupBox3.Controls.Add(dtpNgayGiao);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtTenNguoiNhan);
            groupBox3.Controls.Add(txtSDTNhan);
            groupBox3.Controls.Add(txtDiaChiGiao);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(13, 198);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1240, 138);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin giao hàng";
            // 
            // dtpNgayGiao
            // 
            dtpNgayGiao.Format = DateTimePickerFormat.Short;
            dtpNgayGiao.Location = new Point(934, 80);
            dtpNgayGiao.Name = "dtpNgayGiao";
            dtpNgayGiao.Size = new Size(224, 30);
            dtpNgayGiao.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(807, 87);
            label9.Name = "label9";
            label9.Size = new Size(119, 22);
            label9.TabIndex = 11;
            label9.Text = "Ngày giao(*):";
            // 
            // txtTenNguoiNhan
            // 
            txtTenNguoiNhan.Location = new Point(160, 30);
            txtTenNguoiNhan.Name = "txtTenNguoiNhan";
            txtTenNguoiNhan.Size = new Size(426, 30);
            txtTenNguoiNhan.TabIndex = 9;
            // 
            // txtSDTNhan
            // 
            txtSDTNhan.Location = new Point(934, 30);
            txtSDTNhan.MaxLength = 10;
            txtSDTNhan.Name = "txtSDTNhan";
            txtSDTNhan.Size = new Size(224, 30);
            txtSDTNhan.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(807, 38);
            label15.Name = "label15";
            label15.Size = new Size(117, 22);
            label15.TabIndex = 0;
            label15.Text = "SĐT nhận(*):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 38);
            label13.Name = "label13";
            label13.Size = new Size(131, 22);
            label13.TabIndex = 0;
            label13.Text = "Người nhận(*):";
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://dth235770huynhthithanhthao.github.io/LTQL_DoAn_Buoi8_9/";
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1266, 778);
            Controls.Add(groupBox3);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private ImageList imageList1;
        private HelpProvider helpProvider1;
    }
}