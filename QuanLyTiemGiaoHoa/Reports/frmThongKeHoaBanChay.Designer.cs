namespace QuanLyTiemGiaoHoa.Reports
{
    partial class frmThongKeHoaBanChay
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
            btnHienTatCa = new Button();
            btnLocKetQua = new Button();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(1151, 28);
            btnHienTatCa.Margin = new Padding(4, 3, 4, 3);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(150, 32);
            btnHienTatCa.TabIndex = 10;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(977, 29);
            btnLocKetQua.Margin = new Padding(4, 3, 4, 3);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(150, 32);
            btnLocKetQua.TabIndex = 9;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 5;
            label2.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = " dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(616, 28);
            dtpDenNgay.Margin = new Padding(4, 3, 4, 3);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(283, 30);
            dtpDenNgay.TabIndex = 7;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = " dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(125, 28);
            dtpTuNgay.Margin = new Padding(4, 3, 4, 3);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(283, 30);
            dtpTuNgay.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 6;
            label1.Text = "Từ ngày:";
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(-1, 77);
            reportViewer.Margin = new Padding(4, 3, 4, 3);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1422, 473);
            reportViewer.TabIndex = 11;
            // 
            // frmThongKeHoaBanChay
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 548);
            Controls.Add(reportViewer);
            Controls.Add(btnHienTatCa);
            Controls.Add(btnLocKetQua);
            Controls.Add(label2);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongKeHoaBanChay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê hoa bán chạy";
            Load += frmThongKeHoaBanChay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHienTatCa;
        private Button btnLocKetQua;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}