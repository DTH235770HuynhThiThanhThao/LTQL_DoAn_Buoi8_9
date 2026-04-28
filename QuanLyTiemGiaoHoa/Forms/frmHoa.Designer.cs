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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoa));
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            groupBox3 = new GroupBox();
            btnTimKiem = new Button();
            imageList1 = new ImageList(components);
            txtTimKiem = new TextBox();
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
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            TenHoa = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            helpProvider1 = new HelpProvider();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(groupBox3);
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
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1322, 401);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(884, 24);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(214, 226);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 5;
            picHinhAnh.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FloralWhite;
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Location = new Point(15, 313);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(604, 76);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(192, 255, 255);
            btnTimKiem.ImageIndex = 16;
            btnTimKiem.ImageList = imageList1;
            btnTimKiem.Location = new Point(446, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(134, 40);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
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
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(7, 30);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(419, 30);
            txtTimKiem.TabIndex = 0;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(645, 89);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(221, 30);
            numDonGia.TabIndex = 4;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(645, 32);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(221, 30);
            numSoLuong.TabIndex = 4;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(195, 80);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(284, 30);
            cboNhaCungCap.TabIndex = 3;
            // 
            // cboLoaiHoa
            // 
            cboLoaiHoa.FormattingEnabled = true;
            cboLoaiHoa.Location = new Point(195, 25);
            cboLoaiHoa.Name = "cboLoaiHoa";
            cboLoaiHoa.Size = new Size(284, 30);
            cboLoaiHoa.TabIndex = 3;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = Color.FromArgb(255, 255, 192);
            btnDoiAnh.ImageIndex = 11;
            btnDoiAnh.ImageList = imageList1;
            btnDoiAnh.Location = new Point(1132, 29);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(122, 38);
            btnDoiAnh.TabIndex = 2;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Pink;
            btnXuat.ImageIndex = 13;
            btnXuat.ImageList = imageList1;
            btnXuat.Location = new Point(1182, 269);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(111, 38);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất";
            btnXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.PowderBlue;
            btnNhap.ImageIndex = 17;
            btnNhap.ImageList = imageList1;
            btnNhap.Location = new Point(1041, 269);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(116, 38);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập";
            btnNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.ForeColor = Color.Red;
            btnThoat.ImageIndex = 15;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(901, 269);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 38);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.White;
            btnHuyBo.ImageIndex = 11;
            btnHuyBo.ImageList = imageList1;
            btnHuyBo.Location = new Point(761, 269);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(123, 38);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.White;
            btnLuu.ImageIndex = 19;
            btnLuu.ImageList = imageList1;
            btnLuu.Location = new Point(616, 269);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(123, 38);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.ForeColor = Color.FromArgb(192, 0, 0);
            btnXoa.ImageIndex = 8;
            btnXoa.ImageList = imageList1;
            btnXoa.Location = new Point(473, 269);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 38);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.ImageIndex = 9;
            btnSua.ImageList = imageList1;
            btnSua.Location = new Point(332, 269);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 38);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.ImageIndex = 7;
            btnThem.ImageList = imageList1;
            btnThem.Location = new Point(191, 269);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 38);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenHoa
            // 
            txtTenHoa.Location = new Point(195, 141);
            txtTenHoa.Name = "txtTenHoa";
            txtTenHoa.Size = new Size(671, 30);
            txtTenHoa.TabIndex = 1;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(195, 200);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(671, 30);
            txtMoTa.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 89);
            label3.Name = "label3";
            label3.Size = new Size(145, 22);
            label3.TabIndex = 0;
            label3.Text = "Nhà cung cấp(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 150);
            label4.Name = "label4";
            label4.Size = new Size(138, 22);
            label4.TabIndex = 0;
            label4.Text = "Tên loại hoa(*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 91);
            label6.Name = "label6";
            label6.Size = new Size(102, 22);
            label6.TabIndex = 0;
            label6.Text = "Đơn giá(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 34);
            label5.Name = "label5";
            label5.Size = new Size(111, 22);
            label5.TabIndex = 0;
            label5.Text = "Số lượng(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 34);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 0;
            label2.Text = "Phân loại(*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 209);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 0;
            label1.Text = "Mô tả hoa:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LavenderBlush;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(11, 418);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1320, 347);
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
            dataGridView.Location = new Point(3, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1314, 318);
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
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://dth235770huynhthithanhthao.github.io/LTQL_DoAn_Buoi8_9/";
            // 
            // frmHoa
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1355, 777);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoa";
            Load += frmHoa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
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
        private ImageList imageList1;
        private HelpProvider helpProvider1;
    }
}