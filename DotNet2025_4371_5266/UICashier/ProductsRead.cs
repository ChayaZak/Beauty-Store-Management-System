using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UICashier
{
    public partial class ProductsRead : Form
    {
        private static BlApi.IBl _bl = BlApi.Factory.Get();
        public static BO.Customer? customer;
        private IOrder _order;
        private Order order = new Order();
        public ProductsRead()
        {
            InitializeComponent();

            dataGridView1.DataSource = _bl.Product.ReadAll().ToList();

        }

        private void Products_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = _bl.Product.ReadAll().ToList();
        }

        /// <summary>
        /// הוספת מוצר להזמנה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            List<BO.SaleInProduct> salesInThisProduct = _bl.Order.AddProductToOrder(order, (int)numericUpDownProductId.Value, (int)numericUpDownProductAmount.Value);
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
            numericUpDownProductId.Value = 0;
            numericUpDownProductAmount.Value = 0;
        }

        /// <summary>
        /// ביצוע הזמנה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            _bl.Order.DoOrder(order);
            MessageBox.Show($"Order finished successfully");
        }

        
        

    }
}
