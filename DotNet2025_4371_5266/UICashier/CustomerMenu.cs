using System;
using System.Linq;

namespace UICashier
{
    public partial class CustomerMenu : Form
    {
        private static BlApi.IBl _bl = BlApi.Factory.Get();
        public CustomerMenu()
        {
            InitializeComponent();
        }

        public void SelectTab(int tabIndex)
        {
            if (tabIndex >= 0 && tabIndex < tabControl1.TabCount)
            {
                tabControl1.SelectedIndex = tabIndex;
            }
        }

        /// <summary>
        /// הוספת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = _bl.Customer.Create(new BO.Customer(int.Parse(textBoxCustomerId.Text), textBoxName.Text, textBoxAddress.Text, int.Parse(textBoxCustomerPhone.Text)));
            MessageBox.Show($"Customer created successfully with ID: {id}");
            textBoxCustomerId.Text=string.Empty;
            textBoxName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxCustomerPhone.Text = string.Empty;
        }

        /// <summary>
        /// עדכון לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bl.Customer.Update(new BO.Customer(int.Parse(textBoxCustomerIdUpdate.Text), textBoxCustomerNameUpdate.Text, textBoxCustomeAddressUpdate.Text, int.Parse(textBoxCustomerPhoneUpdate.Text)));
            MessageBox.Show($"Customer updated successfully with ID: {int.Parse(textBoxCustomerIdUpdate.Text)}");
            textBoxCustomerIdUpdate.Text = string.Empty;
            textBoxCustomerNameUpdate.Text = string.Empty;
            textBoxCustomeAddressUpdate.Text = string.Empty;
            textBoxCustomerPhoneUpdate.Text = string.Empty;
        }

        /// <summary>
        /// מחיקת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bl.Customer.Delete(int.Parse(textBoxDelete.Text));
            MessageBox.Show($"Customer deleted successfully with ID: {int.Parse(textBoxDelete.Text)}");
            textBoxDelete.Text = string.Empty;
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {

        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
