using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// Ensure that the namespace 'StorageManagementProject.Models' exists in your project and that Product.cs is inside it.
// If Product.cs is not in the 'Models' sub-namespace, update the using directive to match the actual namespace of Product.cs.
// For example, if Product.cs is in the 'StorageManagementProject' namespace, change the using directive to:

using StorageManagementProject; // Remove or update this line if 'Models' does not exist

// If Product.cs is in a different namespace, use that namespace here instead.

namespace StorageManagementProject
{
    public partial class WareHouseForm : Form
    {
        // 🧱 Danh sách sản phẩm
        private List<Product> products = new List<Product>();
        private List<Product> filteredProducts = new List<Product>();

        public WareHouseForm()
        {
            InitializeComponent();
        }

        // 🧩 Khi form tải
        private void WareHouseForm_Load(object sender, EventArgs e)
        {
            // Dữ liệu mẫu — bạn có thể thay bằng dữ liệu đọc từ Excel sau này
            products = new List<Product>
            {
                new Product { Sku = "SP001", Name = "Oreo", Category = "Snack", Stock = 50, Price = 5, VatRate = 0.1, DateAdded = DateTime.Today },
                new Product { Sku = "SP002", Name = "Coca Cola", Category = "Drink", Stock = 100, Price = 10, VatRate = 0.08, DateAdded = DateTime.Today },
                new Product { Sku = "SP003", Name = "Lays", Category = "Snack", Stock = 30, Price = 7, VatRate = 0.1, DateAdded = DateTime.Today },
                new Product { Sku = "SP004", Name = "Pepsi", Category = "Drink", Stock = 70, Price = 9, VatRate = 0.08, DateAdded = DateTime.Today }
            };

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

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa {selectedProduct.Name}?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                products.Remove(selectedProduct);
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = products;
                dgvProductDetails.DataSource = null;
            }
        }
    }
}
