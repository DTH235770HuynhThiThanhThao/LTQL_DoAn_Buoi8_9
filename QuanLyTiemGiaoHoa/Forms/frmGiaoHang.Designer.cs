namespace QuanLyTiemGiaoHoa.Forms
{
    partial class frmGiaoHang
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            txtDiaChiGiao = new TextBox();
            label9 = new Label();
            txtSDTNhan = new TextBox();
            label6 = new Label();
            txtTenNguoiNhan = new TextBox();
            label5 = new Label();
            txtKhachHang = new TextBox();
            label4 = new Label();
            dtpNgayGiao = new DateTimePicker();
            cboTrangThaiGiao = new ComboBox();
            label8 = new Label();
            numTongTien = new NumericUpDown();
            label7 = new Label();
            txtGhiChuGiaoHang = new TextBox();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            TenNguoiNhan = new DataGridViewTextBoxColumn();
            DienThoaiNhan = new DataGridViewTextBoxColumn();
            DiaChiGiao = new DataGridViewTextBoxColumn();
            NgayGiao = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            TrangThaiGiao = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            btnXuat = new Button();
            btnThoat = new Button();
            btnBatDauGiao = new Button();
            btnGiaoThanhCong = new Button();
            btnHuyGiao = new Button();
            btnLamMoi = new Button();
            btnInPhieuGiao = new Button();
            btnLuuThayDoi = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTongTien).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtDiaChiGiao);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSDTNhan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenNguoiNhan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtKhachHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpNgayGiao);
            groupBox1.Controls.Add(cboTrangThaiGiao);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(numTongTien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGhiChuGiaoHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1742, 245);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin giao hàng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Location = new Point(1274, 118);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(462, 75);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(345, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 40);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(303, 30);
            txtTimKiem.TabIndex = 0;
            // 
            // txtDiaChiGiao
            // 
            txtDiaChiGiao.Location = new Point(820, 128);
            txtDiaChiGiao.Name = "txtDiaChiGiao";
            txtDiaChiGiao.ReadOnly = true;
            txtDiaChiGiao.Size = new Size(301, 30);
            txtDiaChiGiao.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(682, 136);
            label9.Name = "label9";
            label9.Size = new Size(136, 22);
            label9.TabIndex = 12;
            label9.Text = "Địa chỉ giao(*):";
            // 
            // txtSDTNhan
            // 
            txtSDTNhan.Location = new Point(161, 133);
            txtSDTNhan.MaxLength = 10;
            txtSDTNhan.Name = "txtSDTNhan";
            txtSDTNhan.ReadOnly = true;
            txtSDTNhan.Size = new Size(406, 30);
            txtSDTNhan.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 139);
            label6.Name = "label6";
            label6.Size = new Size(117, 22);
            label6.TabIndex = 12;
            label6.Text = "SĐT nhận(*):";
            // 
            // txtTenNguoiNhan
            // 
            txtTenNguoiNhan.Location = new Point(820, 77);
            txtTenNguoiNhan.Name = "txtTenNguoiNhan";
            txtTenNguoiNhan.ReadOnly = true;
            txtTenNguoiNhan.Size = new Size(301, 30);
            txtTenNguoiNhan.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(682, 82);
            label5.Name = "label5";
            label5.Size = new Size(131, 22);
            label5.TabIndex = 12;
            label5.Text = "Người nhận(*):";
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(162, 79);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.ReadOnly = true;
            txtKhachHang.Size = new Size(404, 30);
            txtKhachHang.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1258, 35);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 10;
            label4.Text = "Ngày giao(*):";
            // 
            // dtpNgayGiao
            // 
            dtpNgayGiao.Format = DateTimePickerFormat.Short;
            dtpNgayGiao.Location = new Point(1382, 26);
            dtpNgayGiao.Name = "dtpNgayGiao";
            dtpNgayGiao.Size = new Size(205, 30);
            dtpNgayGiao.TabIndex = 9;
            // 
            // cboTrangThaiGiao
            // 
            cboTrangThaiGiao.FormattingEnabled = true;
            cboTrangThaiGiao.Location = new Point(820, 30);
            cboTrangThaiGiao.Name = "cboTrangThaiGiao";
            cboTrangThaiGiao.Size = new Size(301, 30);
            cboTrangThaiGiao.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(615, 38);
            label8.Name = "label8";
            label8.Size = new Size(198, 22);
            label8.TabIndex = 7;
            label8.Text = "Trạng thái giao hàng(*):";
            // 
            // numTongTien
            // 
            numTongTien.Location = new Point(1382, 80);
            numTongTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numTongTien.Name = "numTongTien";
            numTongTien.ReadOnly = true;
            numTongTien.Size = new Size(206, 30);
            numTongTien.TabIndex = 6;
            numTongTien.ThousandsSeparator = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1258, 82);
            label7.Name = "label7";
            label7.Size = new Size(113, 22);
            label7.TabIndex = 5;
            label7.Text = "Tổng tiền(*):";
            // 
            // txtGhiChuGiaoHang
            // 
            txtGhiChuGiaoHang.Location = new Point(162, 179);
            txtGhiChuGiaoHang.Name = "txtGhiChuGiaoHang";
            txtGhiChuGiaoHang.Size = new Size(404, 30);
            txtGhiChuGiaoHang.TabIndex = 2;
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
            cboNhanVien.Size = new Size(406, 30);
            cboNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 187);
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
            label1.Size = new Size(158, 22);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên giao(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(13, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1742, 402);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách giao hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, TenNguoiNhan, DienThoaiNhan, DiaChiGiao, NgayGiao, TongTienHoaDon, TrangThaiGiao, GhiChu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1736, 373);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 42.7807465F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.FillWeight = 111.492294F;
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.FillWeight = 111.492294F;
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            // 
            // TenNguoiNhan
            // 
            TenNguoiNhan.DataPropertyName = "TenNguoiNhan";
            TenNguoiNhan.HeaderText = "Người nhận";
            TenNguoiNhan.MinimumWidth = 6;
            TenNguoiNhan.Name = "TenNguoiNhan";
            // 
            // DienThoaiNhan
            // 
            DienThoaiNhan.DataPropertyName = "DienThoaiNhan";
            DienThoaiNhan.HeaderText = "SĐT nhận";
            DienThoaiNhan.MinimumWidth = 6;
            DienThoaiNhan.Name = "DienThoaiNhan";
            // 
            // DiaChiGiao
            // 
            DiaChiGiao.DataPropertyName = "DiaChiGiao";
            DiaChiGiao.HeaderText = "Địa chỉ giao";
            DiaChiGiao.MinimumWidth = 6;
            DiaChiGiao.Name = "DiaChiGiao";
            // 
            // NgayGiao
            // 
            NgayGiao.DataPropertyName = "NgayGiao";
            NgayGiao.FillWeight = 111.492294F;
            NgayGiao.HeaderText = "Ngày giao";
            NgayGiao.MinimumWidth = 6;
            NgayGiao.Name = "NgayGiao";
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle1.Format = "N0";
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle1;
            TongTienHoaDon.FillWeight = 111.492294F;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            // 
            // TrangThaiGiao
            // 
            TrangThaiGiao.DataPropertyName = "TrangThaiGiao";
            TrangThaiGiao.FillWeight = 111.492294F;
            TrangThaiGiao.HeaderText = "Trạng thái giao";
            TrangThaiGiao.MinimumWidth = 6;
            TrangThaiGiao.Name = "TrangThaiGiao";
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.FillWeight = 111.492294F;
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1451, 702);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(103, 36);
            btnXuat.TabIndex = 16;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1314, 702);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 36);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBatDauGiao
            // 
            btnBatDauGiao.Location = new Point(933, 702);
            btnBatDauGiao.Name = "btnBatDauGiao";
            btnBatDauGiao.Size = new Size(157, 36);
            btnBatDauGiao.TabIndex = 12;
            btnBatDauGiao.Text = "Bắt đầu giao";
            btnBatDauGiao.UseVisualStyleBackColor = true;
            btnBatDauGiao.Click += btnBatDauGiao_Click;
            // 
            // btnGiaoThanhCong
            // 
            btnGiaoThanhCong.Location = new Point(746, 702);
            btnGiaoThanhCong.Name = "btnGiaoThanhCong";
            btnGiaoThanhCong.Size = new Size(157, 36);
            btnGiaoThanhCong.TabIndex = 13;
            btnGiaoThanhCong.Text = "Giao thành công";
            btnGiaoThanhCong.UseVisualStyleBackColor = true;
            btnGiaoThanhCong.Click += btnGiaoThanhCong_Click;
            // 
            // btnHuyGiao
            // 
            btnHuyGiao.Location = new Point(1123, 702);
            btnHuyGiao.Name = "btnHuyGiao";
            btnHuyGiao.Size = new Size(157, 36);
            btnHuyGiao.TabIndex = 12;
            btnHuyGiao.Text = "Hủy giao";
            btnHuyGiao.UseVisualStyleBackColor = true;
            btnHuyGiao.Click += btnHuyGiao_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(378, 702);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(157, 36);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnInPhieuGiao
            // 
            btnInPhieuGiao.Location = new Point(562, 702);
            btnInPhieuGiao.Name = "btnInPhieuGiao";
            btnInPhieuGiao.Size = new Size(157, 36);
            btnInPhieuGiao.TabIndex = 12;
            btnInPhieuGiao.Text = "In phiếu giao";
            btnInPhieuGiao.UseVisualStyleBackColor = true;
            btnInPhieuGiao.Click += btnInPhieuGiao_Click;
            // 
            // btnLuuThayDoi
            // 
            btnLuuThayDoi.Location = new Point(207, 702);
            btnLuuThayDoi.Name = "btnLuuThayDoi";
            btnLuuThayDoi.Size = new Size(141, 36);
            btnLuuThayDoi.TabIndex = 17;
            btnLuuThayDoi.Text = "Lưu thay đổi";
            btnLuuThayDoi.UseVisualStyleBackColor = true;
            btnLuuThayDoi.Click += btnLuuThayDoi_Click;
            // 
            // frmGiaoHang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1791, 782);
            Controls.Add(btnLuuThayDoi);
            Controls.Add(btnXuat);
            Controls.Add(btnThoat);
            Controls.Add(btnInPhieuGiao);
            Controls.Add(btnLamMoi);
            Controls.Add(btnHuyGiao);
            Controls.Add(btnBatDauGiao);
            Controls.Add(btnGiaoThanhCong);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmGiaoHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giao hàng";
            Load += frmGiaoHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTongTien).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboTrangThaiGiao;
        private Label label8;
        private NumericUpDown numTongTien;
        private Label label7;
        private TextBox txtGhiChuGiaoHang;
        private Label label2;
        private ComboBox cboNhanVien;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DateTimePicker dtpNgayGiao;
        private Label label4;
        private TextBox txtDiaChiGiao;
        private Label label9;
        private TextBox txtSDTNhan;
        private Label label6;
        private TextBox txtTenNguoiNhan;
        private Label label5;
        private TextBox txtKhachHang;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnBatDauGiao;
        private Button btnGiaoThanhCong;
        private GroupBox groupBox3;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Button btnHuyGiao;
        private Button btnLamMoi;
        private Button btnInPhieuGiao;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn TenNguoiNhan;
        private DataGridViewTextBoxColumn DienThoaiNhan;
        private DataGridViewTextBoxColumn DiaChiGiao;
        private DataGridViewTextBoxColumn NgayGiao;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewTextBoxColumn TrangThaiGiao;
        private DataGridViewTextBoxColumn GhiChu;
        private Button btnLuuThayDoi;
    }
}