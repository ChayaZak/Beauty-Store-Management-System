using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIManager
{
    public partial class ProductMenu : Form
    {
        public ProductMenu()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BO.Product product = new BO.Product(0, textBox1.Text, BO.Category.טיפוח_עור_הפנים, (double)numericUpDown1.Value, (int)numericUpDown2.Value);
            Ibl.Product.Create(product);
            MessageBox.Show("Product created successfully");
        }
    }
}
