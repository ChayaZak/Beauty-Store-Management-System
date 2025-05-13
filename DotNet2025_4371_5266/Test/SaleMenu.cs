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

namespace UIManager
{
    public partial class SaleMenu : Form
    {
        private static IBl _bl = BlApi.Factory.Get();

        public SaleMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// הוספת מבצע
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = _bl.sale.Create(new BO.Sale((int)numericUpDownCode.Value, (int)numericUpDownProductId.Value, (int)numericUpDownMinQuantity.Value, (int)numericUpDownPrice.Value, checkBoxIsClab.Checked, dateTimePickerFirst.Value, dateTimePickerEnd.Value));
            MessageBox.Show($"Sale created successfully with ID: {id}");
            numericUpDownCode.Value = 0;
            numericUpDownProductId.Value = 0;
            numericUpDownMinQuantity.Value = 0;
            numericUpDownPrice.Value = 0;
            checkBoxIsClab.Checked = false;
            dateTimePickerFirst.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        /// <summary>
        /// עדכון מבצע
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bl.sale.Update(new BO.Sale((int)numericUpDownSaleCode.Value, (int)numericUpDownProductIdUpdate.Value, (int)numericUpDownMinQuantityUpdate.Value, (int)numericUpDownPriceUpdate.Value, checkBoxIsClab.Checked, dateTimePickerFirst.Value, dateTimePickerEndUpdate.Value));
            MessageBox.Show($"Sale updated successfuly with ID: {numericUpDownSaleCode.Value}");
            numericUpDownSaleCode.Value = 0;
            numericUpDownProductIdUpdate.Value = 0;
            numericUpDownMinQuantityUpdate.Value = 0;
            numericUpDownPriceUpdate.Value = 0;
            checkBoxIsClab.Checked = false;
            dateTimePickerFirst.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        /// <summary>
        /// קבלת מבצע
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            Sale? sale = new Sale();
            sale = _bl.sale.Read((int)numericUpDownId.Value);
            MessageBox.Show(sale.ToString());
            numericUpDownId.Value = 0;
        }

        /// <summary>
        /// מחיקת מבצע
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bl.sale.Delete((int)numericUpDownDelete.Value);
            MessageBox.Show($"Sale {numericUpDownDelete.Value} deleted successfuly");
            numericUpDownDelete.Value = 0;
        }
    }
}
