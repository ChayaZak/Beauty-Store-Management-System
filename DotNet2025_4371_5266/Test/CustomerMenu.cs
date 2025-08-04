using System;
using System.Linq;
using System.Windows.Forms;

namespace UIManager
{
    public partial class CustomerMenu : Form
    {
        private static BlApi.IBl _bl = BlApi.Factory.Get();
        public CustomerMenu()
        {
            InitializeComponent();
            ReadAllCustomers();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerId.Text == string.Empty || textBoxName.Text == string.Empty
                || textBoxPhone.Text == string.Empty)
            {
                MessageBox.Show("יש למלא את כל השדות");

            }
            else
            {
                try
                {
                    int id = _bl.Customer.Create(new BO.Customer(int.Parse(textBoxCustomerId.Text), textBoxName.Text, textBoxAddress.Text, int.Parse(textBoxPhone.Text)));
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
                    textBoxPhone.Text = string.Empty;
                    ReadAllCustomers();
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Customer.Update(new BO.Customer(int.Parse(textBoxCustomeIdUpdate.Text), textBoxCustomerNameUpdate.Text, textBoxCustomeAddressUpdate.Text, int.Parse(textBoxCustomerPhoneUpdate.Text)));
                MessageBox.Show($"Customer updateed successfully with ID: {textBoxCustomeIdUpdate.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxCustomeIdUpdate.Text = string.Empty;
                textBoxCustomerNameUpdate.Text = string.Empty;
                textBoxCustomeAddressUpdate.Text = string.Empty;
                textBoxCustomerPhoneUpdate.Text = string.Empty;
                ReadAllCustomers();
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
                ReadAllCustomers();
            }
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer? customer = new BO.Customer();
                customer = _bl.Customer.Read(int.Parse(textBoxCustomerIdRead.Text));
                string customerText = "Customer:\n";
                customerText += "-----------------------------\n";
                customerText +=
                 $"ID: {customer.Id}\n" +
                $"Name: {customer.Name}\n" +
                $"Address: {customer.Address}\n" +
                $"Phone: {customer.Phone}\n" +
                "-----------------------------";
                lblReadAllCustomers.Text = customerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxCustomerIdRead.Text = string.Empty;
            }
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                List<BO.Customer?> customers = _bl.Customer.ReadAll(c => c.Name.Contains(textBoxFilter.Text));

                if (customers.Count == 0)
                {
                    MessageBox.Show("לא קיים לקוח בשם זה");
                    lblReadAllCustomers.Text = string.Empty;
                }
                else
                {
                    lblReadAllCustomers.Text = getCustomersList(customers); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxFilter.Text = string.Empty;
            }
        }


        public void ReadAllCustomers()
        {
            try
            {
                List<BO.Customer?> customers = _bl.Customer.ReadAll();
                if (customers == null || !customers.Any())
                {
                    lblReadAllCustomers.Text = "No customers available.";
                    return;
                }

                lblReadAllCustomers.Text = getCustomersList(customers);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string getCustomersList(List<BO.Customer?> customers)
        {
            string customersListText = "Customers List:\n";
            customersListText += "-----------------------------\n";
            customersListText += string.Join(Environment.NewLine, customers.Select(c =>
                $"ID: {c.Id}\n" +
                $"Name: {c.Name}\n" +
                $"Address: {c.Address}\n" +
                $"Phone: {c.Phone}\n" +
                "-----------------------------"));

            return customersListText;

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            ReadAllCustomers();
        }
    }
}
