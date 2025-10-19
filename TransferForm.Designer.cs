namespace StorageManagementProject
{
    partial class TransferForm
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
            lblTransfer = new Label();
            lblFrom = new Label();
            lblTo = new Label();
            lblChooseProduct = new Label();
            lblQuantity = new Label();
            txtFromWarehouse = new TextBox();
            txtToWarehouse = new TextBox();
            txtProductInfo = new TextBox();
            nudQuantity = new NumericUpDown();
            btnTransfer = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTransfer
            // 
            lblTransfer.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransfer.Location = new Point(68, 9);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new Size(248, 52);
            lblTransfer.TabIndex = 0;
            lblTransfer.Text = "Transfer Form";
            // 
            // lblFrom
            // 
            lblFrom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrom.Location = new Point(12, 83);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(155, 33);
            lblFrom.TabIndex = 1;
            lblFrom.Text = " From Warehouse:";
            // 
            // lblTo
            // 
            lblTo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTo.Location = new Point(12, 134);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(155, 33);
            lblTo.TabIndex = 2;
            lblTo.Text = "To Warehouse:";
            // 
            // lblChooseProduct
            // 
            lblChooseProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChooseProduct.Location = new Point(12, 184);
            lblChooseProduct.Name = "lblChooseProduct";
            lblChooseProduct.Size = new Size(155, 33);
            lblChooseProduct.TabIndex = 3;
            lblChooseProduct.Text = "Product:";
            // 
            // lblQuantity
            // 
            lblQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(12, 232);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(155, 33);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // txtFromWarehouse
            // 
            txtFromWarehouse.Location = new Point(185, 83);
            txtFromWarehouse.Name = "txtFromWarehouse";
            txtFromWarehouse.Size = new Size(178, 27);
            txtFromWarehouse.TabIndex = 5;
            // 
            // txtToWarehouse
            // 
            txtToWarehouse.Location = new Point(185, 133);
            txtToWarehouse.Name = "txtToWarehouse";
            txtToWarehouse.Size = new Size(178, 27);
            txtToWarehouse.TabIndex = 6;
            // 
            // txtProductInfo
            // 
            txtProductInfo.Location = new Point(185, 184);
            txtProductInfo.Name = "txtProductInfo";
            txtProductInfo.Size = new Size(178, 27);
            txtProductInfo.TabIndex = 7;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(185, 238);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(178, 27);
            nudQuantity.TabIndex = 8;
            nudQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(68, 287);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(94, 29);
            btnTransfer.TabIndex = 9;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(234, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Button";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 328);
            Controls.Add(btnCancel);
            Controls.Add(btnTransfer);
            Controls.Add(nudQuantity);
            Controls.Add(txtProductInfo);
            Controls.Add(txtToWarehouse);
            Controls.Add(txtFromWarehouse);
            Controls.Add(lblQuantity);
            Controls.Add(lblChooseProduct);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            Controls.Add(lblTransfer);
            Name = "Form3";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransfer;
        private Label lblFrom;
        private Label lblTo;
        private Label lblChooseProduct;
        private Label lblQuantity;
        private TextBox txtFromWarehouse;
        private TextBox txtToWarehouse;
        private TextBox txtProductInfo;
        private NumericUpDown nudQuantity;
        private Button btnTransfer;
        private Button btnCancel;
    }
}