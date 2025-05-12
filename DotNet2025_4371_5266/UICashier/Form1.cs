using BlApi;
using BO;

namespace UICashier
{
    public partial class Form1 : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        public static Customer? customer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            customer = _bl.Customer.Read((int)numericUpDownCustomerId.Value);
            if (customer != null)
            {
                MessageBox.Show($"Welcome {customer.Name}");
                ProductsRead products = new ProductsRead();
                products.ShowDialog();
            }
            else
            {
                MessageBox.Show("Customer not found");
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.ShowDialog();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.SelectTab(1);
            customerMenu.ShowDialog();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.SelectTab(2);
            customerMenu.ShowDialog();
        }
    }
}
