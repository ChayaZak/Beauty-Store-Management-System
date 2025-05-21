namespace UI_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// כניסה כמנהל
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            LoginPopup loginPopup = new LoginPopup();
            loginPopup.UserType = "Admin"; 
            loginPopup.StartPosition = FormStartPosition.CenterParent;
            loginPopup.ShowDialog(this);
        }


        /// <summary>
        /// כניסה כקופאי
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            LoginPopup loginPopup = new LoginPopup();
            loginPopup.UserType = "Cashier"; 
            loginPopup.StartPosition = FormStartPosition.CenterParent;
            loginPopup.ShowDialog(this);
        }
    }
}
