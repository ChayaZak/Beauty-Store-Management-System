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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category c;
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out c);
            BO.Product product = new BO.Product(0, textBoxName.Text, c, (double)numericUpDownPrice.Value, (int)numericUpDownAmount.Value);
            _bl.Product.Create(product);
            MessageBox.Show("Product created successfully");
        }
    }
}
