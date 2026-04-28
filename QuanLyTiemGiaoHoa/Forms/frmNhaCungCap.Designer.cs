namespace QuanLyTiemGiaoHoa.Forms
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
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
            txtTenNhaCungCap = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            helpProvider1 = new HelpProvider();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LavenderBlush;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(13, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1189, 437);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenNhaCungCap });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1183, 408);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 32.08556F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.FillWeight = 167.914459F;
            TenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
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
            groupBox1.Controls.Add(txtTenNhaCungCap);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1190, 135);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Pink;
            btnXuat.ImageIndex = 13;
            btnXuat.ImageList = imageList1;
            btnXuat.Location = new Point(1068, 77);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(103, 32);
            btnXuat.TabIndex = 3;
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
            btnNhap.ImageIndex = 17;
            btnNhap.ImageList = imageList1;
            btnNhap.Location = new Point(944, 77);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(103, 32);
            btnNhap.TabIndex = 4;
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
            btnThoat.Location = new Point(824, 77);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 32);
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
            btnHuyBo.Location = new Point(701, 77);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(103, 32);
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
            btnLuu.Location = new Point(578, 77);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(103, 32);
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
            btnXoa.Location = new Point(455, 77);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 32);
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
            btnSua.Location = new Point(329, 77);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 32);
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
            btnThem.Location = new Point(206, 77);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 32);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenNhaCungCap
            // 
            txtTenNhaCungCap.Location = new Point(206, 31);
            txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            txtTenNhaCungCap.Size = new Size(965, 30);
            txtTenNhaCungCap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(175, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên nhà cung cấp(*):";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FloralWhite;
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Location = new Point(13, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(644, 75);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(192, 255, 255);
            btnTimKiem.ImageIndex = 16;
            btnTimKiem.ImageList = imageList1;
            btnTimKiem.Location = new Point(510, 30);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 32);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(7, 30);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(485, 30);
            txtTimKiem.TabIndex = 0;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://dth235770huynhthithanhthao.github.io/LTQL_DoAn_Buoi8_9/";
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1216, 686);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà cung cấp";
            Load += frmNhaCungCap_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenNhaCungCap;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private ImageList imageList1;
        private HelpProvider helpProvider1;
    }
}