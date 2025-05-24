using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Login
{
    public partial class LoginPopup : Form
    {
        public string? UserType { get; set; }
        public LoginPopup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// כניסת למערכת
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("יש למלא את כל השדות");
            }

            else
            {
                if (UserType == "Admin")
                {
                    UIManager.Form1 manager = new UIManager.Form1(textBoxName.Text);
                    manager.ShowDialog();
                }
                if (UserType == "Cashier")
                {
                    UICashier.Form1 cashier = new UICashier.Form1(textBoxName.Text);
                    cashier.ShowDialog();
                }
            }

        }
    }
}
