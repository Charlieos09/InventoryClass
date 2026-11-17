namespace Inventory
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            txtSellPrice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            cbCategory = new ComboBox();
            richTxtDescription = new RichTextBox();
            label7 = new Label();
            gridViewProductList = new DataGridView();
            label8 = new Label();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(70, 44);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(213, 23);
            txtProductName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 47);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 168);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Qty.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 105);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Mfg. Date";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(70, 160);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(213, 23);
            txtQuantity.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 134);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Exp. Date";
            // 
            // textBox4
            // 
            txtSellPrice.Location = new Point(70, 189);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(213, 23);
            txtSellPrice.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 76);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 197);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 10;
            label6.Text = "Sell Price";
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(68, 99);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(215, 23);
            dtPickerMfgDate.TabIndex = 12;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(68, 128);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(215, 23);
            dtPickerExpDate.TabIndex = 13;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(70, 73);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(213, 23);
            cbCategory.TabIndex = 14;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(468, 44);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(320, 168);
            richTxtDescription.TabIndex = 15;
            richTxtDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 26);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 16;
            label7.Text = "Description";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 274);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(776, 175);
            gridViewProductList.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(123, 28);
            label8.TabIndex = 18;
            label8.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(678, 236);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(110, 32);
            btnAddProduct.TabIndex = 19;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddProduct);
            Controls.Add(label8);
            Controls.Add(gridViewProductList);
            Controls.Add(label7);
            Controls.Add(richTxtDescription);
            Controls.Add(cbCategory);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtSellPrice);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            btnAddProduct.Click += btnAddProduct_Click;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private TextBox txtQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSellPrice;
        private Label label5;
        private Label label6;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private ComboBox cbCategory;
        private RichTextBox richTxtDescription;
        private Label label7;
        private DataGridView gridViewProductList;
        private Label label8;
        private Button btnAddProduct;
    }
}
