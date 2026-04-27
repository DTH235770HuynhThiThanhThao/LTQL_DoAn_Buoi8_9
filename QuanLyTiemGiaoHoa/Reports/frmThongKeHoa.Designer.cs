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
            cboNhaCungCap = new ComboBox();
            cboLoaiHoa = new ComboBox();
            label2 = new Label();
            btnKetQua = new Button();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(-2, 75);
            reportViewer.Margin = new Padding(4, 3, 4, 3);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1576, 543);
            reportViewer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 22);
            label1.TabIndex = 1;
            label1.Text = "Nhà cung cấp:";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(194, 23);
            cboNhaCungCap.Margin = new Padding(4, 3, 4, 3);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(468, 30);
            cboNhaCungCap.TabIndex = 2;
            // 
            // cboLoaiHoa
            // 
            cboLoaiHoa.FormattingEnabled = true;
            cboLoaiHoa.Location = new Point(807, 23);
            cboLoaiHoa.Margin = new Padding(4, 3, 4, 3);
            cboLoaiHoa.Name = "cboLoaiHoa";
            cboLoaiHoa.Size = new Size(346, 30);
            cboLoaiHoa.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(704, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 3;
            label2.Text = "Loại hoa:";
            // 
            // btnKetQua
            // 
            btnKetQua.Location = new Point(1181, 23);
            btnKetQua.Margin = new Padding(4, 3, 4, 3);
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(194, 35);
            btnKetQua.TabIndex = 5;
            btnKetQua.Text = "Lộc kết quả";
            btnKetQua.UseVisualStyleBackColor = true;
            btnKetQua.Click += btnKetQua_Click;
            // 
            // frmThongKeHoa
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 616);
            Controls.Add(btnKetQua);
            Controls.Add(cboLoaiHoa);
            Controls.Add(label2);
            Controls.Add(cboNhaCungCap);
            Controls.Add(label1);
            Controls.Add(reportViewer);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
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
        private ComboBox cboNhaCungCap;
        private ComboBox cboLoaiHoa;
        private Label label2;
        private Button btnKetQua;
    }
}