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

        /// <summary>
        /// התחברות לקוח למערכת לפי מזהה לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                customer = _bl.Customer.Read(int.Parse(textBoxCustomerId.Text));
                if (customer != null)
                {
                    ProductsRead products = new ProductsRead(customer.Name);
                    products.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxCustomerId.Text = string.Empty;
            }
        }

        /// <summary>
        /// הוספת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.ShowDialog();
        }

        /// <summary>
        /// עדכון לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.SelectTab(1);
            customerMenu.ShowDialog();
        }

        /// <summary>
        /// מחיקת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            //customerMenu.numericUpDownCustomeIdUpdate.Value = (int)textBoxCustomerId.Value;
            customerMenu.SelectTab(2);
            customerMenu.ShowDialog();
        }
    }
}
