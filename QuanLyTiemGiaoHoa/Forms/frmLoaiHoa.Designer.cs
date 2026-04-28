namespace QuanLyTiemGiaoHoa.Forms
{
    partial class frmLoaiHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiHoa));
            groupBox1 = new GroupBox();
            btnXuat = new Button();
            imageList1 = new ImageList(components);
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLoai = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            groupBox3 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            helpProvider1 = new HelpProvider();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenLoai);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.8F);
            groupBox1.Location = new Point(6, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1157, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại hoa";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Pink;
            btnXuat.Font = new Font("Times New Roman", 12F);
            btnXuat.ImageIndex = 13;
            btnXuat.ImageList = imageList1;
            btnXuat.Location = new Point(1027, 72);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 41);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất";
            btnXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
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
            // btnNhap
            // 
            btnNhap.BackColor = Color.PowderBlue;
            btnNhap.Font = new Font("Times New Roman", 12F);
            btnNhap.ImageIndex = 20;
            btnNhap.ImageList = imageList1;
            btnNhap.Location = new Point(914, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 41);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập";
            btnNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.Font = new Font("Times New Roman", 12F);
            btnThoat.ForeColor = Color.Red;
            btnThoat.ImageIndex = 15;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(796, 72);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 41);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.White;
            btnHuyBo.Font = new Font("Times New Roman", 12F);
            btnHuyBo.ImageIndex = 11;
            btnHuyBo.ImageList = imageList1;
            btnHuyBo.Location = new Point(680, 72);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(98, 41);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.White;
            btnLuu.Font = new Font("Times New Roman", 12F);
            btnLuu.ImageIndex = 19;
            btnLuu.ImageList = imageList1;
            btnLuu.Location = new Point(566, 72);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 41);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.ForeColor = Color.FromArgb(192, 0, 0);
            btnXoa.ImageIndex = 8;
            btnXoa.ImageList = imageList1;
            btnXoa.Location = new Point(446, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 41);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.ImageIndex = 9;
            btnSua.ImageList = imageList1;
            btnSua.Location = new Point(328, 72);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 41);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Font = new Font("Times New Roman", 12F);
            btnThem.ImageIndex = 7;
            btnThem.ImageList = imageList1;
            btnThem.Location = new Point(208, 72);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 41);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Font = new Font("Times New Roman", 12F);
            txtTenLoai.Location = new Point(208, 26);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(913, 30);
            txtTenLoai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(138, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên loại hoa(*):";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Font = new Font("Times New Roman", 10.8F);
            groupBox2.Location = new Point(6, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 73);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(192, 255, 255);
            btnTimKiem.Font = new Font("Times New Roman", 12F);
            btnTimKiem.ImageIndex = 16;
            btnTimKiem.ImageList = imageList1;
            btnTimKiem.Location = new Point(497, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(131, 35);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 12F);
            txtTimKiem.Location = new Point(7, 30);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(468, 30);
            txtTimKiem.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LavenderBlush;
            groupBox3.Controls.Add(dataGridView);
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(6, 244);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1157, 441);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách loại hoa";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1151, 412);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 32.0855637F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.FillWeight = 167.914459F;
            TenLoai.HeaderText = "Tên loại hoa";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1207, 718);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://dth235770huynhthithanhthao.github.io/LTQL_DoAn_Buoi8_9/";
            // 
            // frmLoaiHoa
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1207, 718);
            Controls.Add(groupBox4);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLoaiHoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại hoa";
            Load += frmLoaiHoa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenLoai;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private ImageList imageList1;
        private GroupBox groupBox4;
        private HelpProvider helpProvider1;
    }
}