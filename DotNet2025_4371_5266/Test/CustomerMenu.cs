using System;
using System.Linq;

namespace UIManager
{
    public partial class CustomerMenu : Form
    {
        private static BlApi.IBl _bl = BlApi.Factory.Get();
        public CustomerMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// הוספת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = _bl.Customer.Create(new BO.Customer((int)numericUpDownCustomerId.Value, textBoxName.Text, textBoxAddress.Text, (int)numericUpDownPhone.Value));
            MessageBox.Show($"Customer created successfully with ID: {id}");
            numericUpDownCustomerId.Value = 0;
            textBoxName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            numericUpDownPhone.Value = 0;
        }

        /// <summary>
        /// עדכון לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bl.Customer.Update(new BO.Customer((int)numericUpDownCustomeIdUpdate.Value, textBoxCustomerNameUpdate.Text, textBoxCustomeAddressUpdate.Text, (int)numericUpDownCustomerPhoneUpdate.Value));
            MessageBox.Show($"Customer updateed successfully with ID: {numericUpDownCustomeIdUpdate.Value}");
            numericUpDownCustomerId.Value = 0;
            textBoxName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            numericUpDownPhone.Value = 0;
        }

        /// <summary>
        /// מחיקת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bl.Customer.Delete((int)numericUpDownDelete.Value);
            MessageBox.Show($"Customer deleted successfully with ID: {(int)numericUpDownDelete.Value}");
            numericUpDownDelete.Value = 0;
        }

        /// <summary>
        /// קבלת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            BO.Customer? customer = new BO.Customer();
            customer = _bl.Customer.Read((int)numericUpDownId.Value);
            MessageBox.Show(customer.ToString());
            numericUpDownId.Value = 0;
        }
    }
}
