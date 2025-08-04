using BO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UICashier
{
    public partial class ProductsRead : Form
    {
        private static BlApi.IBl _bl = BlApi.Factory.Get();
        public static BO.Customer? customer;
        public static Order order = new Order();
        public string? name { get; set; }
        public ProductsRead()
        {
            InitializeComponent();
            dataGridView1.DataSource = _bl.Product.ReadAll().ToList();
            dataGridView1.Columns["QuantityInStock"].Visible = false;
        }
        public ProductsRead(string? name)
        {
            InitializeComponent();
            name = name ?? string.Empty;
            lblHelloCustomer.Text = $"שלום {name}";
            dataGridView1.DataSource = _bl.Product.ReadAll().ToList();
            dataGridView1.Columns["QuantityInStock"].Visible = false;
        }



        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                List<BO.SaleInProduct> salesInThisProduct = _bl.Order.AddProductToOrder(order, (int)numericUpDownProductId.Value, (int)numericUpDownProductAmount.Value);
                lblTotalPrice.Text = order.TotalPrice.ToString();
                lblProducts.Text = getProductsList(order.Products);
                if (salesInThisProduct.Count > 0)
                {
                    string sales = "Sales in this product:\n";
                    foreach (var sale in salesInThisProduct)
                    {
                        sales += $"{sale}\n";
                    }
                    MessageBox.Show(sales);
                }
                else
                {
                    MessageBox.Show("No sales in this product");
                }
                MessageBox.Show($"Product with ID: {(int)numericUpDownProductId.Value} added to order successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                numericUpDownProductId.Value = 0;
                numericUpDownProductAmount.Value = 0;
            }
        }


        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Order.DoOrder(order);
                MessageBox.Show($"Order finished successfully, For payment: {order.TotalPrice} Shekels");
                lblTotalPrice.Text= string.Empty;
                lblProducts.Text = string.Empty;
                order= new Order();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getProductsList(List<BO.ProductInOrder?> products)
        {
            string productsListText = "Products List:\n";
            productsListText += "----------------------\n";
            productsListText += string.Join(Environment.NewLine, products.Select(p =>
                $"Name: {p.ProductName}\n" +
                $"Price to product: {p.BasePrice}\n" +
                $"Final Price: {p.FinalPrice}\n" +
                $"Quantity: {p.QuantityInOrder}\n" +
                "----------------------"));

            return productsListText;

        }
    }
}
