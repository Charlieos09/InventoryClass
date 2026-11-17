using System;

namespace Inventory
{
    internal class ProductClass
    {
        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName = string.Empty;
        private string _Category = string.Empty;
        private string _ManufacturingDate = string.Empty;
        private string _ExpirationDate = string.Empty;
        private string _Description = string.Empty;

        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate,
            double Price, int Quantity, string Description)
        {
            _Quantity = Quantity;
            _SellingPrice = Price;
            _ProductName = ProductName;
            _Category = Category;
            _ManufacturingDate = MfgDate;
            _ExpirationDate = ExpDate;
            _Description = Description;
        }

        public string productName
        {
            get => _ProductName;
            set => _ProductName = value;
        }

        public string category
        {
            get => _Category;
            set => _Category = value;
        }

        public string manufacturingDate
        {
            get => _ManufacturingDate;
            set => _ManufacturingDate = value;
        }

        public string expirationDate
        {
            get => _ExpirationDate;
            set => _ExpirationDate = value;
        }

        public string description
        {
            get => _Description;
            set => _Description = value;
        }

        public int quantity
        {
            get => _Quantity;
            set => _Quantity = value;
        }

        public double sellingPrice
        {
            get => _SellingPrice;
            set => _SellingPrice = value;
        }
    }
}
