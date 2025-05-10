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
    }
}
