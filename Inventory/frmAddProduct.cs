using System.Globalization;
using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private readonly BindingSource showProductList = new();
        private readonly string[] ListOfProductCategory =
        {
            "Beverages",
            "Bread/Bakery",
            "Canned/Jarred Goods",
            "Dairy",
            "Frozen Goods",
            "Meat",
            "Personal Care"
        };

        private string _ProductName = string.Empty;
        private string _Category = string.Empty;
        private string _MfgDate = string.Empty;
        private string _ExpDate = string.Empty;
        private string _Description = string.Empty;
        private int _Quantity;
        private double _SellPrice;

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object? sender, EventArgs e)
        {
            foreach (string categoryName in ListOfProductCategory)
                cbCategory.Items.Add(categoryName);

            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }

        public string Product_Name(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException("Product name must contain letters only.");

            return name;
        }

        public int Quantity(string qty)
        {
            if (string.IsNullOrWhiteSpace(qty) || !Regex.IsMatch(qty, @"^[0-9]+$") ||
                !int.TryParse(qty, NumberStyles.None, CultureInfo.InvariantCulture, out int quantity))
                throw new NumberFormatException("Quantity must be a whole number.");

            return quantity;
        }

        public double SellingPrice(string price)
        {
            if (string.IsNullOrWhiteSpace(price) || !Regex.IsMatch(price, @"^(\d*\.)?\d+$") ||
                !double.TryParse(price, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double sellingPrice))
                throw new CurrencyFormatException("Selling price must be a valid number, for example 12.50.");

            return sellingPrice;
        }

        private void btnAddProduct_Click(object? sender, EventArgs e)
        {
            btnAddProduct.Enabled = false;
            try
            {
                _ProductName = Product_Name(txtProductName.Text.Trim());
                _Category = cbCategory.SelectedItem?.ToString() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(_Category))
                    throw new StringFormatException("Please select a product category.");
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text.Trim());
                _SellPrice = SellingPrice(txtSellPrice.Text.Trim());

                showProductList.Add(new ProductClass(
                    _ProductName,
                    _Category,
                    _MfgDate,
                    _ExpDate,
                    _SellPrice,
                    _Quantity,
                    _Description));

                txtProductName.Clear();
                cbCategory.SelectedIndex = -1;
                txtQuantity.Clear();
                txtSellPrice.Clear();
                richTxtDescription.Clear();
                txtProductName.Focus();
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(this, ex.Message, "Invalid product name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(this, ex.Message, "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(this, ex.Message, "Invalid selling price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnAddProduct.Enabled = true;
            }
        }
    }

    internal sealed class NumberFormatException : Exception
    {
        public NumberFormatException(string message) : base(message) { }
    }

    internal sealed class StringFormatException : Exception
    {
        public StringFormatException(string message) : base(message) { }
    }

    internal sealed class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string message) : base(message) { }
    }
}
