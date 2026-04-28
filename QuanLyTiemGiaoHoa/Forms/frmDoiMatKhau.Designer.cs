namespace QuanLyTiemGiaoHoa.Forms
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            chkHienMatKhau = new CheckBox();
            pictureBox1 = new PictureBox();
            btnHuyBo = new Button();
            btnCapNhat = new Button();
            txtMatKhauMoi = new TextBox();
            label2 = new Label();
            txtMatKhauCu = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtNhapMatKhauMoi = new TextBox();
            helpProvider1 = new HelpProvider();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(784, 290);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(127, 24);
            chkHienMatKhau.TabIndex = 21;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-85, -1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 449);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(192, 192, 255);
            btnHuyBo.Location = new Point(780, 328);
            btnHuyBo.Margin = new Padding(4, 3, 4, 3);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(131, 42);
            btnHuyBo.TabIndex = 18;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(255, 192, 192);
            btnCapNhat.Location = new Point(537, 328);
            btnCapNhat.Margin = new Padding(4, 3, 4, 3);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(135, 42);
            btnCapNhat.TabIndex = 19;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(537, 182);
            txtMatKhauMoi.Margin = new Padding(4, 3, 4, 3);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(374, 27);
            txtMatKhauMoi.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(537, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 13;
            label2.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(537, 115);
            txtMatKhauCu.Margin = new Padding(4, 3, 4, 3);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(374, 27);
            txtMatKhauCu.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(614, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(242, 41);
            label3.TabIndex = 14;
            label3.Text = "ĐỔI MẬT KHẨU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 15;
            label1.Text = "Mật khẩu cũ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 222);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 13;
            label4.Text = "Nhập lại mật khẩu mới :";
            // 
            // txtNhapMatKhauMoi
            // 
            txtNhapMatKhauMoi.Location = new Point(537, 247);
            txtNhapMatKhauMoi.Margin = new Padding(4, 3, 4, 3);
            txtNhapMatKhauMoi.Name = "txtNhapMatKhauMoi";
            txtNhapMatKhauMoi.PasswordChar = '*';
            txtNhapMatKhauMoi.Size = new Size(374, 27);
            txtNhapMatKhauMoi.TabIndex = 16;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://dth235770huynhthithanhthao.github.io/LTQL_DoAn_Buoi8_9/";
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(976, 407);
            Controls.Add(chkHienMatKhau);
            Controls.Add(pictureBox1);
            Controls.Add(btnHuyBo);
            Controls.Add(btnCapNhat);
            Controls.Add(txtNhapMatKhauMoi);
            Controls.Add(label4);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(label2);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkHienMatKhau;
        private PictureBox pictureBox1;
        private Button btnHuyBo;
        private Button btnCapNhat;
        public TextBox txtMatKhauMoi;
        private Label label2;
        public TextBox txtMatKhauCu;
        private Label label3;
        private Label label1;
        private Label label4;
        public TextBox txtNhapMatKhauMoi;
        private HelpProvider helpProvider1;
    }
}