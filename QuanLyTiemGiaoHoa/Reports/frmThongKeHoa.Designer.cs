namespace QuanLyTiemGiaoHoa.Reports
{
    partial class frmThongKeHoa
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            cbNhaCungCap = new ComboBox();
            cbLoaiHoa = new ComboBox();
            label2 = new Label();
            btnKetQua = new Button();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(-2, 68);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1147, 494);
            reportViewer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhà cung cấp:";
            // 
            // cbNhaCungCap
            // 
            cbNhaCungCap.FormattingEnabled = true;
            cbNhaCungCap.Location = new Point(141, 21);
            cbNhaCungCap.Name = "cbNhaCungCap";
            cbNhaCungCap.Size = new Size(342, 28);
            cbNhaCungCap.TabIndex = 2;
            // 
            // cbLoaiHoa
            // 
            cbLoaiHoa.FormattingEnabled = true;
            cbLoaiHoa.Location = new Point(587, 21);
            cbLoaiHoa.Name = "cbLoaiHoa";
            cbLoaiHoa.Size = new Size(253, 28);
            cbLoaiHoa.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 24);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Loại hoa:";
            // 
            // btnKetQua
            // 
            btnKetQua.Location = new Point(859, 21);
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(141, 32);
            btnKetQua.TabIndex = 5;
            btnKetQua.Text = "Lộc kết quả";
            btnKetQua.UseVisualStyleBackColor = true;
            // 
            // frmThongKeHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 560);
            Controls.Add(btnKetQua);
            Controls.Add(cbLoaiHoa);
            Controls.Add(label2);
            Controls.Add(cbNhaCungCap);
            Controls.Add(label1);
            Controls.Add(reportViewer);
            Name = "frmThongKeHoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê hoa";
            Load += frmThongKeHoa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Label label1;
        private ComboBox cbNhaCungCap;
        private ComboBox cbLoaiHoa;
        private Label label2;
        private Button btnKetQua;
    }
}