namespace StorageManagementProject
{
    partial class NewForm
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
            lblProDetail = new Label();
            lblSKU = new Label();
            lblName = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblCategory = new Label();
            txtSKU = new TextBox();
            txtName = new TextBox();
            numStock = new NumericUpDown();
            cboCategory = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblCreatedAt = new Label();
            lblSupplier = new Label();
            lblVatRate = new Label();
            lblNote = new Label();
            dtpDateAdded = new DateTimePicker();
            txtSupplier = new TextBox();
            numVAT = new NumericUpDown();
            txtNote = new TextBox();
            numPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVAT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // lblProDetail
            // 
            lblProDetail.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProDetail.Location = new Point(12, 9);
            lblProDetail.Name = "lblProDetail";
            lblProDetail.Size = new Size(417, 59);
            lblProDetail.TabIndex = 0;
            lblProDetail.Text = "Product Detail Form";
            lblProDetail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSKU
            // 
            lblSKU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSKU.Location = new Point(23, 82);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(62, 39);
            lblSKU.TabIndex = 1;
            lblSKU.Text = "SKU:";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(22, 121);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 39);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(22, 165);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(85, 39);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(22, 208);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(85, 39);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock:";
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(23, 254);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(117, 39);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category:";
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSKU.Location = new Point(173, 81);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(209, 34);
            txtSKU.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(173, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 34);
            txtName.TabIndex = 7;
            // 
            // numStock
            // 
            numStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numStock.Location = new Point(173, 208);
            numStock.Name = "numStock";
            numStock.Size = new Size(209, 34);
            numStock.TabIndex = 9;
            numStock.TextAlign = HorizontalAlignment.Center;
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(173, 248);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(209, 36);
            cboCategory.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(61, 519);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(260, 519);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedAt.Location = new Point(22, 296);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(144, 39);
            lblCreatedAt.TabIndex = 13;
            lblCreatedAt.Text = "Date Added:";
            // 
            // lblSupplier
            // 
            lblSupplier.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplier.Location = new Point(22, 335);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(107, 39);
            lblSupplier.TabIndex = 14;
            lblSupplier.Text = "Supplier:";
            // 
            // lblVatRate
            // 
            lblVatRate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVatRate.Location = new Point(22, 374);
            lblVatRate.Name = "lblVatRate";
            lblVatRate.Size = new Size(117, 39);
            lblVatRate.TabIndex = 15;
            lblVatRate.Text = "VAT Rate: ";
            // 
            // lblNote
            // 
            lblNote.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(23, 413);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(74, 39);
            lblNote.TabIndex = 16;
            lblNote.Text = "Note:";
            // 
            // dtpDateAdded
            // 
            dtpDateAdded.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateAdded.Location = new Point(173, 293);
            dtpDateAdded.Name = "dtpDateAdded";
            dtpDateAdded.Size = new Size(209, 34);
            dtpDateAdded.TabIndex = 17;
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(173, 333);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(209, 34);
            txtSupplier.TabIndex = 18;
            // 
            // numVAT
            // 
            numVAT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numVAT.Location = new Point(173, 374);
            numVAT.Name = "numVAT";
            numVAT.Size = new Size(209, 34);
            numVAT.TabIndex = 19;
            numVAT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNote.Location = new Point(173, 414);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(209, 80);
            txtNote.TabIndex = 20;
            // 
            // numPrice
            // 
            numPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPrice.Location = new Point(173, 168);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(209, 34);
            numPrice.TabIndex = 21;
            numPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // NewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 593);
            Controls.Add(numPrice);
            Controls.Add(txtNote);
            Controls.Add(numVAT);
            Controls.Add(txtSupplier);
            Controls.Add(dtpDateAdded);
            Controls.Add(lblNote);
            Controls.Add(lblVatRate);
            Controls.Add(lblSupplier);
            Controls.Add(lblCreatedAt);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboCategory);
            Controls.Add(numStock);
            Controls.Add(txtName);
            Controls.Add(txtSKU);
            Controls.Add(lblCategory);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(lblSKU);
            Controls.Add(lblProDetail);
            Name = "NewForm";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVAT).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProDetail;
        private Label lblSKU;
        private Label lblName;
        private Label lblPrice;
        private Label lblStock;
        private Label lblCategory;
        private TextBox txtSKU;
        private TextBox txtName;
        private NumericUpDown numStock;
        private ComboBox cboCategory;
        private Button btnSave;
        private Button btnCancel;
        private Label lblCreatedAt;
        private Label lblSupplier;
        private Label lblVatRate;
        private Label lblNote;
        private DateTimePicker dtpDateAdded;
        private TextBox txtSupplier;
        private NumericUpDown numVAT;
        private TextBox txtNote;
        private NumericUpDown numPrice;
    }
}