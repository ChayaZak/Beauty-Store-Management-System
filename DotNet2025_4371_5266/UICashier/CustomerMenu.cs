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


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerId.Text == string.Empty || textBoxName.Text == string.Empty
                || textBoxCustomerPhone.Text == string.Empty)
            {
                MessageBox.Show("יש למלא את כל השדות");

            }
            else
            {
                try
                {
                    int id = _bl.Customer.Create(new BO.Customer(int.Parse(textBoxCustomerId.Text), textBoxName.Text, textBoxAddress.Text, int.Parse(textBoxCustomerPhone.Text)));
                    MessageBox.Show($"Customer created successfully with ID: {id}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    textBoxCustomerId.Text = string.Empty;
                    textBoxName.Text = string.Empty;
                    textBoxAddress.Text = string.Empty;
                    textBoxCustomerPhone.Text = string.Empty;
                }
            } 
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Customer.Update(new BO.Customer(int.Parse(textBoxCustomerIdUpdate.Text), textBoxCustomerNameUpdate.Text, textBoxCustomeAddressUpdate.Text, int.Parse(textBoxCustomerPhoneUpdate.Text)));
                MessageBox.Show($"Customer updated successfully with ID: {int.Parse(textBoxCustomerIdUpdate.Text)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxCustomerIdUpdate.Text = string.Empty;
                textBoxCustomerNameUpdate.Text = string.Empty;
                textBoxCustomeAddressUpdate.Text = string.Empty;
                textBoxCustomerPhoneUpdate.Text = string.Empty;
            } 
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Customer.Delete(int.Parse(textBoxDelete.Text));
                MessageBox.Show($"Customer deleted successfully with ID: {int.Parse(textBoxDelete.Text)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                textBoxDelete.Text = string.Empty;
            }

        }

       
    }
}
