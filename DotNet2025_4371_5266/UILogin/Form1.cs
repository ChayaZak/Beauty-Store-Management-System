namespace UILogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoginPopup loginPopup = new LoginPopup();
            //loginPopup.Show();
            LoginPopup loginPopup = new LoginPopup();
            loginPopup.UserType = "Admin"; 
            loginPopup.StartPosition = FormStartPosition.CenterParent;
            loginPopup.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPopup loginPopup = new LoginPopup();
            loginPopup.UserType = "Cashier";
            loginPopup.StartPosition = FormStartPosition.CenterParent;
            loginPopup.ShowDialog(this);
        }
    }
}
