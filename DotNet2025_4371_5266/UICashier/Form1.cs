using BlApi;
using BO;

namespace UICashier
{
    public partial class Form1 : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        public static Customer? customer;
        public string? name { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string? name)
        {
            InitializeComponent();
            name = name ?? string.Empty;
            lblHelloCashier.Text = $"קופאי: {name}";
        }


        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                customer = _bl.Customer.Read(int.Parse(textBoxCustomerId.Text));
                if (customer != null)
                {
                    ProductsRead products = new ProductsRead(customer.Name);
                    ProductsRead.order.IsPreferredCustomer = true;
                    products.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Read Customer") || ex.Message.Contains("does not exist"))
                {
                    ProductsRead products = new ProductsRead("אורח");
                    ProductsRead.order.IsPreferredCustomer = false;
                    products.ShowDialog();
                }
                else
                    MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxCustomerId.Text = string.Empty;
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
