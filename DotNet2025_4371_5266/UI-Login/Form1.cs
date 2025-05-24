namespace UI_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChangeColor();
        }

        public void ChangeColor()
        {
            label1.ForeColor = Color.FromArgb(178, 78, 78);
            button1.ForeColor = Color.FromArgb(234, 221, 217);
            button1.BackColor = Color.FromArgb(217, 139, 135);
            button2.ForeColor = Color.FromArgb(234, 221, 217);
            button2.BackColor = Color.FromArgb(178, 78, 78);
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
