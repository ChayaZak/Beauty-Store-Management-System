using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
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
            Category c;
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out c);
            BO.Product product = new BO.Product(0, textBoxName.Text, c, (double)numericUpDownPrice.Value, (int)numericUpDownAmount.Value);
            _bl.Product.Create(product);
            MessageBox.Show("Product created successfully");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// קבלת מוצר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            Product? p = _bl.Product.Read((int)numericUpDownId.Value);
            if (p != null)
            {
                MessageBox.Show(p.ToString());
            }
            else
            {
                MessageBox.Show("Product not found");
            }
            numericUpDownId.Value = 0;
        }

        /// <summary>
        /// עדכון מוצר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category c;
            Enum.TryParse(comboBoxCategoryUpdate.SelectedItem.ToString(), out c);
            BO.Product product = new BO.Product((int)numericUpDownIdUpdate.Value, textBoxNameUpdate.Text, c, (double)numericUpDownPriceUpdate.Value, (int)numericUpDownAmountUpdate.Value);
            _bl.Product.Update(product);
            MessageBox.Show("Product updated successfully");
            comboBoxCategoryUpdate.Items.Clear();
        }

        /// <summary>
        /// מחיקת מוצר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bl.Product.Delete((int)numericUpDownDelete.Value);
            MessageBox.Show("Product deleted successfully");
            numericUpDownDelete.Value = 0;
        }
    }
}
