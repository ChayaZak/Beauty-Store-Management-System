using System;
using System.Linq;

namespace BO
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
        public List<SaleInProduct> Sales { get; set; }

        public Product()
        {
            Price = 0;
            QuantityInStock = 0;
            Sales = new List<SaleInProduct>();
        }

        public Product(int id, string? productName, Category category, double price, int quantityInStock, List<SaleInProduct>? sales = null)
        {
            Id = id;
            ProductName = productName;
            Category = category;
            Price = price;
            QuantityInStock = quantityInStock;
            Sales = sales ?? new List<SaleInProduct>();
        }

        public override string? ToString() => Tools.ToStringProperty(this);

    }
}
