using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// Ensure that the namespace 'StorageManagementProject.Models' exists in your project and that Product.cs is inside it.
// If Product.cs is not in the 'Models' sub-namespace, update the using directive to match the actual namespace of Product.cs.
// For example, if Product.cs is in the 'StorageManagementProject' namespace, change the using directive to:

using StorageManagementProject; // Remove or update this line if 'Models' does not exist

// If Product.cs is in a different namespace, use that namespace here instead.
using System.IO;
using ClosedXML.Excel;

namespace StorageManagementProject
{
    public partial class WareHouseForm : Form
    {
        // 🧱 Danh sách sản phẩm
        private List<Product> products = new List<Product>();
        private List<Product> filteredProducts = new List<Product>();

        // Excel integration
        private readonly string excelFilePath = Path.Combine(Application.StartupPath, "products.xlsx");
        private bool useExcel = false;

        public WareHouseForm()
        {
            InitializeComponent();
        }

        // 🧩 Khi form tải
        private void WareHouseForm_Load(object sender, EventArgs e)
        {
            // Try to load from Excel if a valid .xlsx exists
            if (File.Exists(excelFilePath))
            {
                try
                {
                    products = LoadFromExcel(excelFilePath);
                    useExcel = true;
                }
                catch (Exception ex)
                {
                    useExcel = false;
                    ShowUsingDummyDataNotice($"Không thể đọc file Excel: {ex.Message}.\nSẽ sử dụng dữ liệu mẫu.");
                    InitializeDummyProducts();
                }
            }
            else
            {
                useExcel = false;
                ShowUsingDummyDataNotice("Không tìm thấy file Excel (.xlsx). Sẽ sử dụng dữ liệu mẫu.");
                InitializeDummyProducts();
            }

            // Gán dữ liệu cho DataGridView danh sách sản phẩm
            dgvProductList.DataSource = products;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.MultiSelect = false;

            // Hiển thị sản phẩm đầu tiên khi mở form
            if (products.Any())
            {
                dgvProductList.Rows[0].Selected = true;
                ShowProductDetails(products[0]);
            }
        }

        private void InitializeDummyProducts()
        {
            products = new List<Product>
            {
                new Product { Sku = "SP001", Name = "Oreo", Category = "Snack", Stock = 50, Price = 5, VatRate = 0.1, DateAdded = DateTime.Today },
                new Product { Sku = "SP002", Name = "Coca Cola", Category = "Drink", Stock = 100, Price = 10, VatRate = 0.08, DateAdded = DateTime.Today },
                new Product { Sku = "SP003", Name = "Lays", Category = "Snack", Stock = 30, Price = 7, VatRate = 0.1, DateAdded = DateTime.Today },
                new Product { Sku = "SP004", Name = "Pepsi", Category = "Drink", Stock = 70, Price = 9, VatRate = 0.08, DateAdded = DateTime.Today }
            };
        }

        private void ShowUsingDummyDataNotice(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<Product> LoadFromExcel(string path)
        {
            using var wb = new XLWorkbook(path);
            var ws = wb.Worksheets.FirstOrDefault();
            if (ws == null)
                throw new InvalidOperationException("Workbook không có worksheet nào.");

            var used = ws.RangeUsed();
            if (used == null)
                return new List<Product>();

            // Map headers (row 1)
            var headers = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            var firstRow = used.Range(ws.FirstRowUsed().RowNumber(), used.FirstColumn().ColumnNumber(), ws.FirstRowUsed().RowNumber(), used.LastColumn().ColumnNumber());
            for (int col = 1; col <= firstRow.ColumnCount(); col++)
            {
                var header = firstRow.Cell(1, col).GetString().Trim();
                if (!string.IsNullOrWhiteSpace(header) && !headers.ContainsKey(header))
                    headers[header] = col;
            }

            // Expected columns
            string[] expected = new[] { "Sku", "Name", "Price", "Stock", "Category", "DateAdded", "Supplier", "VatRate", "Note" };
            // If not all expected headers exist, treat as invalid structure
            if (!expected.All(h => headers.ContainsKey(h)))
                throw new InvalidOperationException("Cấu trúc Excel không hợp lệ (thiếu cột bắt buộc).");

            var list = new List<Product>();
            foreach (var row in used.RowsUsed().Skip(1)) // skip header
            {
                // Stop if the row is completely empty
                bool empty = expected.All(h => string.IsNullOrWhiteSpace(row.Cell(headers[h]).GetString()));
                if (empty) continue;

                var p = new Product
                {
                    Sku = row.Cell(headers["Sku"]).GetString(),
                    Name = row.Cell(headers["Name"]).GetString(),
                    Price = row.Cell(headers["Price"]).GetValue<decimal>(),
                    Stock = row.Cell(headers["Stock"]).GetValue<int>(),
                    Category = row.Cell(headers["Category"]).GetString(),
                    DateAdded = row.Cell(headers["DateAdded"]).GetDateTime(),
                    Supplier = row.Cell(headers["Supplier"]).GetString(),
                    VatRate = row.Cell(headers["VatRate"]).GetValue<double>(),
                    Note = row.Cell(headers["Note"]).GetString()
                };
                list.Add(p);
            }

            return list;
        }

        private void SaveToExcel(string path)
        {
            using var wb = new XLWorkbook();
            var ws = wb.AddWorksheet("Products");
            // Headers
            ws.Cell(1, 1).Value = "Sku";
            ws.Cell(1, 2).Value = "Name";
            ws.Cell(1, 3).Value = "Price";
            ws.Cell(1, 4).Value = "Stock";
            ws.Cell(1, 5).Value = "Category";
            ws.Cell(1, 6).Value = "DateAdded";
            ws.Cell(1, 7).Value = "Supplier";
            ws.Cell(1, 8).Value = "VatRate";
            ws.Cell(1, 9).Value = "Note";

            int r = 2;
            foreach (var p in products)
            {
                ws.Cell(r, 1).Value = p.Sku;
                ws.Cell(r, 2).Value = p.Name;
                ws.Cell(r, 3).Value = p.Price;
                ws.Cell(r, 4).Value = p.Stock;
                ws.Cell(r, 5).Value = p.Category;
                ws.Cell(r, 6).Value = p.DateAdded;
                ws.Cell(r, 7).Value = p.Supplier;
                ws.Cell(r, 8).Value = p.VatRate;
                ws.Cell(r, 9).Value = p.Note;
                r++;
            }

            // Format columns
            ws.Column(3).Style.NumberFormat.Format = "0.00"; // Price
            ws.Column(6).Style.DateFormat.Format = "yyyy-MM-dd"; // DateAdded
            ws.Columns().AdjustToContents();

            wb.SaveAs(path);
        }

        // 🧩 Khi chọn sản phẩm trong DataGridView
        private void dgvProductList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductList.CurrentRow == null) return;

            var selectedProduct = dgvProductList.CurrentRow.DataBoundItem as Product;
            if (selectedProduct != null)
            {
                ShowProductDetails(selectedProduct);
            }
        }

        // 🧩 Hiển thị chi tiết sản phẩm ở DataGridView thứ hai
        private void ShowProductDetails(Product product)
        {
            dgvProductDetails.DataSource = null; // reset
            dgvProductDetails.DataSource = new List<Product> { product };
        }

        // 🧩 Sự kiện tìm kiếm
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvProductList.DataSource = products;
            }
            else
            {
                filteredProducts = products
                    .Where(p =>
                        p.Name.ToLower().Contains(keyword) ||
                        p.Category.ToLower().Contains(keyword) ||
                        p.Sku.ToString().Contains(keyword))
                    .ToList();

                dgvProductList.DataSource = filteredProducts;
            }
        }

        // 🧩 Nút Thêm sản phẩm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open NewForm to create a new product
            using (var form = new NewForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK && form.ProductData != null)
                {
                    products.Add(form.ProductData);
                    dgvProductList.DataSource = null;
                    dgvProductList.DataSource = products;

                    if (useExcel)
                    {
                        try { SaveToExcel(excelFilePath); } catch (Exception ex) { MessageBox.Show($"Lỗi ghi Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }

                    // Select the newly added product
                    var row = dgvProductList.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => (r.DataBoundItem as Product) == form.ProductData);
                    if (row != null) row.Selected = true;
                }
            }
        }

        // 🧩 Nút Sửa sản phẩm
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProductList.CurrentRow == null) return;

            var selectedProduct = dgvProductList.CurrentRow.DataBoundItem as Product;
            if (selectedProduct == null) return;

            // Open NewForm in edit mode by passing the selected product
            using (var form = new NewForm(selectedProduct))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // The product object is modified in place; refresh grid
                    dgvProductList.DataSource = null;
                    dgvProductList.DataSource = products;

                    if (useExcel)
                    {
                        try { SaveToExcel(excelFilePath); } catch (Exception ex) { MessageBox.Show($"Lỗi ghi Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }

                    // Reselect the edited product
                    var row = dgvProductList.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => (r.DataBoundItem as Product) == selectedProduct);
                    if (row != null) row.Selected = true;
                }
            }
        }

        // 🧩 Nút Xóa sản phẩm
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProductList.CurrentRow == null) return;

            var selectedProduct = dgvProductList.CurrentRow.DataBoundItem as Product;
            if (selectedProduct == null) return;

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa {selectedProduct.Name}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (confirm == DialogResult.Yes)
            {
                products.Remove(selectedProduct);
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = products;
                dgvProductDetails.DataSource = null;

                if (useExcel)
                {
                    try { SaveToExcel(excelFilePath); } catch (Exception ex) { MessageBox.Show($"Lỗi ghi Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    }
}
