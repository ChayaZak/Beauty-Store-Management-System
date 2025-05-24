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
                }
            }
        }

        /// <summary>
        /// עדכון לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            }
        }

        /// <summary>
        /// מחיקת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// קבלת לקוח
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer? customer = new BO.Customer();
                customer = _bl.Customer.Read(int.Parse(textBoxCustomerIdRead.Text));
                MessageBox.Show(customer.ToString());
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
    }
}
