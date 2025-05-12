using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = _bl.Customer.Create(new BO.Customer((int)numericUpDownCustomerId.Value, textBoxName.Text, textBoxAddress.Text, (int)numericUpDownPhone.Value));
            MessageBox.Show($"Customer created successfully with ID: {id}");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bl.Customer.Update(new BO.Customer((int)numericUpDownCustomeIdUpdate.Value, textBoxCustomerNameUpdate.Text, textBoxCustomeAddressUpdate.Text, (int)numericUpDownCustomerPhoneUpdate.Value));
            MessageBox.Show($"Customer updated successfully with ID: {(int)numericUpDownCustomeIdUpdate.Value}");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bl.Customer.Delete((int)numericUpDownDelete.Value);
            MessageBox.Show($"Customer deleted successfully with ID: {(int)numericUpDownDelete.Value}");
        }
    }
}
