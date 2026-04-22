namespace QuanLyTiemGiaoHoa.Forms
{
    partial class frmHoa
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
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboNhaCungCap = new ComboBox();
            cboLoaiHoa = new ComboBox();
            btnDoiAnh = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenHoa = new TextBox();
            txtMoTa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            TenHoa = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(cboLoaiHoa);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenHoa);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1202, 348);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(804, 22);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(216, 252);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 5;
            picHinhAnh.TabStop = false;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(586, 81);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(201, 28);
            numDonGia.TabIndex = 4;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(586, 29);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(201, 28);
            numSoLuong.TabIndex = 4;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(177, 73);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(259, 28);
            cboNhaCungCap.TabIndex = 3;
            // 
            // cboLoaiHoa
            // 
            cboLoaiHoa.FormattingEnabled = true;
            cboLoaiHoa.Location = new Point(177, 23);
            cboLoaiHoa.Name = "cboLoaiHoa";
            cboLoaiHoa.Size = new Size(259, 28);
            cboLoaiHoa.TabIndex = 3;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(1035, 22);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(94, 35);
            btnDoiAnh.TabIndex = 2;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1072, 293);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(112, 35);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(944, 293);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(112, 35);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(816, 293);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 35);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(689, 293);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 35);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(557, 293);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 35);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(427, 293);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 35);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(299, 293);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 35);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(171, 293);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 35);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenHoa
            // 
            txtTenHoa.Location = new Point(177, 128);
            txtTenHoa.Name = "txtTenHoa";
            txtTenHoa.Size = new Size(610, 28);
            txtTenHoa.TabIndex = 1;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(177, 182);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(610, 28);
            txtMoTa.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 81);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 0;
            label3.Text = "Nhà cung cấp(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 136);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 0;
            label4.Text = "Tên loại hoa(*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 81);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 0;
            label6.Text = "Đơn giá(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 31);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 0;
            label5.Text = "Số lượng(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 31);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 0;
            label2.Text = "Phân loại(*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 190);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Mô tả hoa:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Location = new Point(10, 364);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(528, 68);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(405, 19);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 36);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 27);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(381, 28);
            txtTimKiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(16, 438);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1200, 350);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hoa";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenNhaCungCap, TenHoa, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 24);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1194, 323);
            dataGridView.TabIndex = 0;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 56.1497421F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.FillWeight = 107.3084F;
            TenLoai.HeaderText = "Phân loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.FillWeight = 107.3084F;
            TenNhaCungCap.HeaderText = "Nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            // 
            // TenHoa
            // 
            TenHoa.DataPropertyName = "TenHoa";
            TenHoa.FillWeight = 107.3084F;
            TenHoa.HeaderText = "Tên hoa";
            TenHoa.MinimumWidth = 6;
            TenHoa.Name = "TenHoa";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.FillWeight = 107.3084F;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.FillWeight = 107.3084F;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.FillWeight = 107.3084F;
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            // 
            // frmHoa
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 800);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoa";
            Load += frmHoa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private PictureBox picHinhAnh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboNhaCungCap;
        private ComboBox cboLoaiHoa;
        private Button btnDoiAnh;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenHoa;
        private TextBox txtMoTa;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn TenHoa;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}