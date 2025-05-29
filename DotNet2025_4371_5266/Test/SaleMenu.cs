using BlApi;
using BO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UIManager
{
    public partial class SaleMenu : Form
    {
        private static IBl _bl = BlApi.Factory.Get();

        public SaleMenu()
        {
            InitializeComponent();
            ReadAllProducts();
        }

        /// <summary>
        /// הוספת מבצע
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (numericUpDownProductId.Value == 0 || numericUpDownMinQuantity.Value == 0 ||
            numericUpDownPrice.Value == 0)
                MessageBox.Show("יש למלא את כל השדות");
            else
            {

                try
                {
                    int id = _bl.sale.Create(new BO.Sale((int)numericUpDownCode.Value, (int)numericUpDownProductId.Value, (int)numericUpDownMinQuantity.Value, (int)numericUpDownPrice.Value, checkBoxIsClab.Checked, dateTimePickerFirst.Value, dateTimePickerEnd.Value));
                    MessageBox.Show($"Sale created successfully with ID: {id}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    numericUpDownCode.Value = 0;
                    numericUpDownProductId.Value = 0;
                    numericUpDownMinQuantity.Value = 0;
                    numericUpDownPrice.Value = 0;
                    checkBoxIsClab.Checked = false;
                    dateTimePickerFirst.Value = DateTime.Now;
                    dateTimePickerEnd.Value = DateTime.Now;
                    ReadAllProducts();

                }
            }


        }

        /// <summary>
        /// עדכון מבצע
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.sale.Update(new BO.Sale((int)numericUpDownSaleCode.Value, (int)numericUpDownProductIdUpdate.Value, (int)numericUpDownMinQuantityUpdate.Value, (int)numericUpDownPriceUpdate.Value, checkBoxIsClab.Checked, dateTimePickerFirst.Value, dateTimePickerEndUpdate.Value));
                MessageBox.Show($"Sale updated successfuly with ID: {numericUpDownSaleCode.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                numericUpDownSaleCode.Value = 0;
                numericUpDownProductIdUpdate.Value = 0;
                numericUpDownMinQuantityUpdate.Value = 0;
                numericUpDownPriceUpdate.Value = 0;
                checkBoxIsClab.Checked = false;
                dateTimePickerFirst.Value = DateTime.Now;
                dateTimePickerEnd.Value = DateTime.Now;
                ReadAllProducts();

            }
        }

        /// <summary>
        /// קבלת מבצע
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                Sale? sale = new Sale();
                sale = _bl.sale.Read((int)numericUpDownId.Value);
                string saleText = "Sale:\n";
                saleText += "-----------------------------\n";
                saleText +=
                    $"Code: {sale.Code}\n" +
                    $"Id Product: {sale.ProductId}\n" +
                    $"Minimum Quantity: {sale.MinQuantity}\n" +
                    $"Price: {sale.Price}\n" +
                    $"In Clab: {sale.InClab}\n" +
                    $"Begin Sale: {sale.BeginSale}\n" +
                    $"End Sale: {sale.EndSale}\n" +
                    "-----------------------------";
                lblReadAllSales.Text = saleText;
                //MessageBox.Show(sale?.ToString());
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
        /// מחיקת מבצע
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                _bl.sale.Delete((int)numericUpDownDelete.Value);
                MessageBox.Show($"Sale {numericUpDownDelete.Value} deleted successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                numericUpDownDelete.Value = 0;
                ReadAllProducts();

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                List<Sale?> sales = _bl.sale.ReadAll(s => s.ProductId == int.Parse(textBoxFilter.Text));

                if (sales.Count == 0)
                {
                    MessageBox.Show("לא קיים מבצע על מוצר זה");
                    lblReadAllSales.Text = string.Empty; // מנקה את הרשימה
                }
                else
                {
                    lblReadAllSales.Text = getSalesList(sales); // מציג את המוצרים
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
        /// הדפסת כל המבצעים
        /// </summary>
        public void ReadAllProducts()
        {
            try
            {
                List<BO.Sale?> sales = _bl.sale.ReadAll();
                if (sales == null || !sales.Any())
                {
                    lblReadAllSales.Text = "No sales available";
                    return;
                }

                lblReadAllSales.Text = getSalesList(sales);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// פונקצית עזר להדפסת רשימת המבצעים בצורה יפה
        /// </summary>
        /// <param name="products">רשימת מבצעים</param>
        /// <returns>מחרוזת יפה של רשימת המבצעים</returns>
        private string getSalesList(List<BO.Sale?> sales)
        {
            string salesListText = "Sales List:\n";
            salesListText += "-----------------------------\n";
            salesListText += string.Join(Environment.NewLine, sales.Select(s =>
                $"Code: {s.Code}\n" +
                $"Id Product: {s.ProductId}\n" +
                 $"Minimum Quantity: {s.MinQuantity}\n" +
                $"Price: {s.Price}\n" +
                $"In Clab: {s.InClab}\n" +
                 $"Begin Sale: {s.BeginSale}\n" +
                  $"End Sale: {s.EndSale}\n" +
                "-----------------------------"));

            return salesListText;

        }

        /// <summary>
        /// ניקוי המסננים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRest_Click(object sender, EventArgs e)
        {
            ReadAllProducts();
        }
    }
}
