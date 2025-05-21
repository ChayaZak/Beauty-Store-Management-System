
namespace UIManager
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// שם המנהל
        /// </summary>
        public string? name { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string? name)
        {
            InitializeComponent();
            lblHelloManager.Text = name;
            lblHelloManager.Text = $"שלום {name}!";
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
