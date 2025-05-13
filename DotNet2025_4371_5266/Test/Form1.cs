using UIManager;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();
            productMenu.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SaleMenu saleMenu = new SaleMenu();
            saleMenu.Show();
        }
    }
}
