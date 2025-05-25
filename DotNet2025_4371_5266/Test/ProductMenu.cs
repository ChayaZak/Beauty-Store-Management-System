using BlApi;
using BO;
using DO;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UIManager
{
    public partial class ProductMenu : Form
    {
        private static IBl _bl = BlApi.Factory.Get();

        public ProductMenu()
        {
            InitializeComponent();
            ReadAllProducts();
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

                    BO.Category c;
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

        /// <summary>
        /// קבלת מוצר לפי תנאי סינון
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                List<BO.Product?> products = _bl.Product.ReadAll(p => p.ProductName.Contains(textBoxFilter.Text));

                if (products.Count == 0)
                {
                    MessageBox.Show("לא קיים מוצר בשם זה");
                    lblReadAllProducts.Text = string.Empty; // מנקה את הרשימה
                }
                else
                {
                    lblReadAllProducts.Text = getProductsList(products); // מציג את המוצרים
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



        /// <summary>
        /// קבלת מוצר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product? p = _bl.Product.Read((int)numericUpDownId.Value);
                string productText = "Product:\n";
                productText += "-----------------------------\n";
                productText +=
                    $"ID: {p.Id}\n" +
                $"Name: {p.ProductName}\n" +
                 $"Category: {p.Category}\n" +
                $"Price: {p.Price}\n" +
                $"Quantity In Stock: {p.QuantityInStock}\n" +
                "-----------------------------";
                lblReadAllProducts.Text = productText;
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
                BO.Category c;
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

        /// <summary>
        /// הדפסת כל המוצרים
        /// </summary>
        public void ReadAllProducts()
        {
            try
            {
                List<BO.Product?> products = _bl.Product.ReadAll();
                if (products == null || !products.Any())
                {
                    lblReadAllProducts.Text = "No products available";
                    return;
                }

                lblReadAllProducts.Text = getProductsList(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// פונקצית עזר להדפסת רשימת המוצרים בצורה יפה
        /// </summary>
        /// <param name="products">רשימת מוצרים</param>
        /// <returns>מחרוזת יפה של רשימת המוצרים</returns>
        private string getProductsList(List<BO.Product?> products)
        {
            string productsListText = "Products List:\n";
            productsListText += "-----------------------------\n";
            productsListText += string.Join(Environment.NewLine, products.Select(p =>
                $"ID: {p.Id}\n" +
                $"Name: {p.ProductName}\n" +
                 $"Category: {p.Category}\n" +
                $"Price: {p.Price}\n" +
                $"Quantity In Stock: {p.QuantityInStock}\n" +
                "-----------------------------"));

            return productsListText;

        }

        /// <summary>
        /// ניקוי המסננים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRest_Click_1(object sender, EventArgs e)
        {
            ReadAllProducts();
        }
    }
}
