using System;
using System.Windows.Forms;

namespace StorageManagementProject
{
    public partial class NewForm : Form
    {
        public Product ProductData { get; private set; }
        private bool isEditMode = false;

        public NewForm()
        {
            InitializeComponent();
            this.Text = "Add product";
            ProductData = new Product();
            this.FormClosing += NewForm_FormClosing;
        }

        public NewForm(Product existingProduct)
        {
            InitializeComponent();
            var date = existingProduct.DateAdded;
            if (date < dtpDateAdded.MinDate || date > dtpDateAdded.MaxDate)
                dtpDateAdded.Value = DateTime.Today;
            else
                dtpDateAdded.Value = date;
            this.Text = "Edit product";
            ProductData = existingProduct;
            isEditMode = true;
            this.FormClosing += NewForm_FormClosing;

            // Gán dữ liệu lên các control
            txtSKU.Text = existingProduct.Sku;
            txtName.Text = existingProduct.Name;
            numPrice.Value = existingProduct.Price > numPrice.Maximum ? numPrice.Maximum : existingProduct.Price;
            numStock.Value = existingProduct.Stock > numStock.Maximum ? numStock.Maximum : existingProduct.Stock;
            cboCategory.Text = existingProduct.Category;
            // Date is already set with bounds-check above
            txtSupplier.Text = existingProduct.Supplier;
            numVAT.Value = (decimal)Math.Min(existingProduct.VatRate, (double)numVAT.Maximum);
            txtNote.Text = existingProduct.Note;
        }

        private void NewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Skip confirmation when saving successfully
            if (this.DialogResult == DialogResult.OK)
                return;

            // Only prompt on user-initiated close
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to close this form?",
                    "Confirm Close",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control
            ProductData.Sku = txtSKU.Text;
            ProductData.Name = txtName.Text;
            ProductData.Price = numPrice.Value;
            ProductData.Stock = (int)numStock.Value;
            ProductData.Category = cboCategory.Text;
            ProductData.DateAdded = dtpDateAdded.Value;
            ProductData.Supplier = txtSupplier.Text;
            ProductData.VatRate = (double)numVAT.Value;
            ProductData.Note = txtNote.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
