using ClosedXML.Excel;
using QuanLyBanHang;
using QuanLyTiemGiaoHoa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace QuanLyTiemGiaoHoa.Forms
{
    public partial class frmHoa : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        bool xuLyThem = false;
        int id;
        bool dangTimKiem = false;
        int gocXoay = 0;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Images");
        Dictionary<int, int> gocXoayTheoID = new Dictionary<int, int>();
       

        public frmHoa()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboNhaCungCap.Enabled = giaTri;
            cboLoaiHoa.Enabled = giaTri;
            txtTenHoa.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiHoa.DataSource = context.LoaiHoa.ToList();
            cboLoaiHoa.ValueMember = "ID";
            cboLoaiHoa.DisplayMember = "TenLoai";

        }

        public void LayHangSanXuatVaoComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";

        }

        private void frmHoa_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();

            // chỉnh ảnh cho nó bự
            dataGridView.RowTemplate.Height = 100; // chỉnh độ cao dòng
            dataGridView.Columns["HinhAnh"].Width = 120;// cột ảnh

            if (dataGridView.Columns["HinhAnh"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                // 🔥 QUAN TRỌNG: nói cho nó biết dữ liệu là string
                imgCol.ValueType = typeof(object);
            }


            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;

            dataGridView.AutoGenerateColumns = false;

            // 🔥 CHẶN LỖI DataGridView (rất quan trọng)
            dataGridView.DataError += (s, e2) =>
            {
                e2.ThrowException = false;
            };



            // tránh add nhiều lần
            dataGridView.CellFormatting -= dataGridView_CellFormatting;
            dataGridView.CellFormatting += dataGridView_CellFormatting;

            var sp = context.Hoa.Select(r => new DanhSachHoa
            {
                ID = r.ID,
                LoaiHoaID = r.LoaiHoaID,
                TenLoai = r.LoaiHoa.TenLoai,
                NhaCungCapID = r.NhaCungCapID,
                TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                TenHoa = r.TenHoa,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                MoTa = r.MoTa,
                HinhAnh = r.HinhAnh
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            // Binding
            cboLoaiHoa.DataBindings.Clear();
            cboLoaiHoa.DataBindings.Add("SelectedValue", bindingSource, "LoaiHoaID");

            cboNhaCungCap.DataBindings.Clear();
            cboNhaCungCap.DataBindings.Add("SelectedValue", bindingSource, "NhaCungCapID");

            txtTenHoa.DataBindings.Clear();
            txtTenHoa.DataBindings.Add("Text", bindingSource, "TenHoa");

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa");

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong");

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia");

            // ⭐ FIX HIỂN THỊ ẢNH ở PictureBox
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e2) =>
            {
                if (e2.Value != null && !string.IsNullOrEmpty(e2.Value.ToString()))
                    e2.Value = Path.Combine(imagesFolder, e2.Value.ToString());
                else
                    e2.Value = null;
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dataGridView.DataSource = bindingSource;

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.RowIndex < 0) return;

                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    try
                    {
                        string filePath = Path.Combine(imagesFolder, e.Value.ToString());

                        if (File.Exists(filePath))
                        {
                            Image img = Image.FromFile(filePath);
                            Bitmap bmp = new Bitmap(img);
                            img.Dispose();

                            int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);

                            // 👉 LẤY GÓC XOAY
                            int soLanXoay = gocXoayTheoID.ContainsKey(id) ? gocXoayTheoID[id] : 0;

                            // 👉 XOAY ĐÚNG SỐ LẦN
                            for (int i = 0; i < soLanXoay; i++)
                            {
                                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            }

                            // 👉 GIỮ TỶ LỆ + KHUNG VUÔNG
                            int boxSize = 120;
                            Bitmap finalImg = new Bitmap(boxSize, boxSize);

                            using (Graphics g = Graphics.FromImage(finalImg))
                            {
                                g.Clear(Color.White);

                                float scale = Math.Min((float)boxSize / bmp.Width, (float)boxSize / bmp.Height);

                                int newW = (int)(bmp.Width * scale);
                                int newH = (int)(bmp.Height * scale);

                                int posX = (boxSize - newW) / 2;
                                int posY = (boxSize - newH) / 2;

                                g.DrawImage(bmp, posX, posY, newW, newH);
                            }

                            e.Value = finalImg;
                            e.FormattingApplied = true;
                        }
                    }
                    catch
                    {
                        e.Value = null;
                    }
                }
            }

            // format giá
            if (dataGridView.Columns[e.ColumnIndex].Name == "DonGia")
            {
                if (e.Value != null)
                {
                    decimal gia = Convert.ToDecimal(e.Value);
                    e.Value = gia.ToString("#,##0");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboNhaCungCap.Text = "";
            cboLoaiHoa.Text = "";
            txtTenHoa.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiHoa.Text))
                MessageBox.Show("Vui lòng chọn loại hoa.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrWhiteSpace(cboNhaCungCap.Text))
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrWhiteSpace(txtTenHoa.Text))
                MessageBox.Show("Vui lòng nhập tên hoa.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá phải lớn hơn 0.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (xuLyThem) // Thêm mới
                {
                    Hoa sp = new Hoa();

                    sp.LoaiHoaID =
                    Convert.ToInt32(cboLoaiHoa.SelectedValue);

                    sp.NhaCungCapID =
                    Convert.ToInt32(cboNhaCungCap.SelectedValue);

                    sp.TenHoa = txtTenHoa.Text;

                    sp.SoLuong = Convert.ToInt32(numSoLuong.Value);

                    sp.DonGia = Convert.ToInt32(numDonGia.Value);

                    sp.MoTa = txtMoTa.Text;

                    if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
                    {
                        sp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
                    }
                    context.Hoa.Add(sp);
                    context.SaveChanges();
                }
                else // Sửa
                {
                    Hoa sp = context.Hoa.Find(id);

                    if (sp != null)
                    {
                        sp.LoaiHoaID =
                        Convert.ToInt32(cboLoaiHoa.SelectedValue);

                        sp.NhaCungCapID =
                        Convert.ToInt32(cboNhaCungCap.SelectedValue);

                        sp.TenHoa = txtTenHoa.Text;

                        sp.SoLuong =
                        Convert.ToInt32(numSoLuong.Value);

                        sp.DonGia =
                        Convert.ToInt32(numDonGia.Value);

                        sp.MoTa = txtMoTa.Text;

                        if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
                        {
                            sp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
                        }

                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Đã lưu thành công!");

                frmHoa_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hoa " + txtTenHoa.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                Hoa sp = context.Hoa.Find(id);
                if (sp != null)
                {
                    context.Hoa.Remove(sp);
                }
                context.SaveChanges();

                frmHoa_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHoa_Load(sender, e);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName.GenerateSlug() + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                Hoa sp = context.Hoa.Find(id);
                sp.HinhAnh = fileName.GenerateSlug() + ext;
                context.Hoa.Update(sp);

                context.SaveChanges();
                frmHoa_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);

                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());

                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;

                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                Hoa sp = new Hoa();

                                var loai = context.LoaiHoa
                                    .FirstOrDefault(x => x.TenLoai == r["TenLoai"].ToString());

                                if (loai != null)
                                    sp.LoaiHoaID = loai.ID;

                                var hang = context.NhaCungCap
                                    .FirstOrDefault(x => x.TenNhaCungCap == r["TenNhaCungCap"].ToString());

                                if (hang != null)
                                    sp.NhaCungCapID = hang.ID;

                                sp.TenHoa = r["TenHoa"].ToString();
                                sp.SoLuong = Convert.ToInt32(r["SoLuong"]);
                                sp.DonGia = Convert.ToDecimal(r["DonGia"]);
                                sp.HinhAnh = r["HinhAnh"].ToString();

                                context.Hoa.Add(sp);
                            }

                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmHoa_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "Hoa_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[6]
                    {
                new DataColumn("TenLoai", typeof(string)),
                new DataColumn("TenNhaCungCap", typeof(string)),
                new DataColumn("TenHoa", typeof(string)),
                new DataColumn("SoLuong", typeof(int)),
                new DataColumn("DonGia", typeof(decimal)),
                new DataColumn("HinhAnh", typeof(string))
                    });

                    var hoa = context.Hoa.Select(r => new
                    {
                        r.LoaiHoa.TenLoai,
                        r.NhaCungCap.TenNhaCungCap,
                        r.TenHoa,
                        r.SoLuong,
                        r.DonGia,
                        r.HinhAnh
                    }).ToList();

                    foreach (var sp in hoa)
                    {
                        table.Rows.Add(
                            sp.TenLoai,
                            sp.TenNhaCungCap,
                            sp.TenHoa,
                            sp.SoLuong,
                            sp.DonGia,
                            sp.HinhAnh
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Hoa");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Xuất Excel thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Nếu đang tìm → bấm lại = reset
            if (dangTimKiem)
            {
                txtTimKiem.Clear();
                frmHoa_Load(sender, e);
                dangTimKiem = false;
                return;
            }

            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            var ketQua = context.Hoa
                .Where(x =>
                    x.TenHoa.ToLower().Contains(tuKhoa) ||
                    x.LoaiHoa.TenLoai.ToLower().Contains(tuKhoa) ||
                    x.NhaCungCap.TenNhaCungCap.ToLower().Contains(tuKhoa))
                .Select(r => new DanhSachHoa
                {
                    ID = r.ID,
                    LoaiHoaID = r.LoaiHoaID,
                    TenLoai = r.LoaiHoa.TenLoai,
                    NhaCungCapID = r.NhaCungCapID,
                    TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                    TenHoa = r.TenHoa,
                    SoLuong = r.SoLuong,
                    DonGia = r.DonGia,
                    HinhAnh = r.HinhAnh
                })
                .ToList();

            dataGridView.DataSource = ketQua;

            dangTimKiem = true;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);

                if (!gocXoayTheoID.ContainsKey(id))
                    gocXoayTheoID[id] = 0;

                gocXoayTheoID[id]++;

                if (gocXoayTheoID[id] >= 4)
                    gocXoayTheoID[id] = 0;

                dataGridView.Refresh();
            }
        }

       
    }
}
