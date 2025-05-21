using System;
using System.Linq;


namespace UILogin
{
    public partial class LoginPopup : Form
    {
        public string? UserType { get; set; }
        public LoginPopup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserType == "Admin")
            {
                UIManager.Form1 uIManager = new UIManager.Form1();
                uIManager.Show();
            }
            if (UserType == "Cashier")
            {
                UICashier.Form1 uiCashier = new UICashier.Form1();
                uiCashier.Show();
            }

        }
    }
}
