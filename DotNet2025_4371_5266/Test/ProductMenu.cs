using BlApi;
using BO;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Linq;

namespace UIManager
{
    public partial class ProductMenu : Form
    {
        private static IBl _bl = BlApi.Factory.Get();

        public ProductMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// הוספת מוצר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty || numericUpDownPrice.Value == 0 || numericUpDownAmount.Value == 0)
                MessageBox.Show("יש למלא את כל השדות");
            else
            {
                try
                {

                    Category c;
                    Enum.TryParse(comboBox1.SelectedItem.ToString(), out c);
                    BO.Product product = new BO.Product(0, textBoxName.Text, c, (double)numericUpDownPrice.Value, (int)numericUpDownAmount.Value);
                    _bl.Product.Create(product);
                    MessageBox.Show("Product created successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    textBoxName.Text = string.Empty;
                    comboBox1.Text = "טיפוח_עור_הפנים";
                    numericUpDownPrice.Value = numericUpDownAmount.Value = 0;
                }
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                //Product? p = _bl.Product.Read(Func(textBoxFilter.Text));
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

        /// <summary>
        /// קבלת מוצר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product? p = _bl.Product.Read((int)numericUpDownId.Value);
                MessageBox.Show(p.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                numericUpDownId.Value = 0;
            }
        }

        /// <summary>
        /// עדכון מוצר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                Category c;
                Enum.TryParse(comboBoxCategoryUpdate.SelectedItem.ToString(), out c);
                BO.Product product = new BO.Product((int)numericUpDownIdUpdate.Value, textBoxNameUpdate.Text, c, (double)numericUpDownPriceUpdate.Value, (int)numericUpDownAmountUpdate.Value);
                _bl.Product.Update(product);
                MessageBox.Show("Product updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                comboBoxCategoryUpdate.Items.Clear();
            }
        }

        /// <summary>
        /// מחיקת מוצר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Product.Delete((int)numericUpDownDelete.Value);
                MessageBox.Show("Product deleted successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                numericUpDownDelete.Value = 0;
            }
        }
    }
}
