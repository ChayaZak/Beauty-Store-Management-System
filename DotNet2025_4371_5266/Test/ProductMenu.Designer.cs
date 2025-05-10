using BlApi;

namespace Test
{
    partial class ProductMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageCreate = new TabPage();
            btnCreate = new Button();
            numericUpDownAmount = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            comboBox1 = new ComboBox();
            lblAmount = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            textBoxName = new TextBox();
            lblName = new Label();
            tabPageRead = new TabPage();
            tabPageUpdate = new TabPage();
            tabPageDelete = new TabPage();
            tabControl1.SuspendLayout();
            tabPageCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCreate);
            tabControl1.Controls.Add(tabPageRead);
            tabControl1.Controls.Add(tabPageUpdate);
            tabControl1.Controls.Add(tabPageDelete);
            tabControl1.Location = new Point(187, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(441, 596);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCreate
            // 
            tabPageCreate.Controls.Add(btnCreate);
            tabPageCreate.Controls.Add(numericUpDownAmount);
            tabPageCreate.Controls.Add(numericUpDownPrice);
            tabPageCreate.Controls.Add(comboBox1);
            tabPageCreate.Controls.Add(lblAmount);
            tabPageCreate.Controls.Add(lblPrice);
            tabPageCreate.Controls.Add(lblCategory);
            tabPageCreate.Controls.Add(textBoxName);
            tabPageCreate.Controls.Add(lblName);
            tabPageCreate.Location = new Point(4, 24);
            tabPageCreate.Name = "tabPageCreate";
            tabPageCreate.Padding = new Padding(3);
            tabPageCreate.Size = new Size(433, 568);
            tabPageCreate.TabIndex = 0;
            tabPageCreate.Text = "הוספת מוצר";
            tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(197, 317);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "הוספה";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(198, 207);
            numericUpDownAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(120, 23);
            numericUpDownAmount.TabIndex = 4;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(197, 150);
            numericUpDownPrice.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "טיפוח_עור_הפנים", "טיפוח_אישי ", "טיפוח_העור ", "משקאות", "מוצרי_כוורת" });
            comboBox1.Location = new Point(197, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "טיפוח_עור_הפנים";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(350, 215);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(70, 15);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "כמות במלאי";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(350, 152);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "מחיר";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(350, 104);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(49, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "קטגוריה";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(218, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(337, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 15);
            lblName.TabIndex = 0;
            lblName.Text = "שם מוצר";
            // 
            // tabPageRead
            // 
            tabPageRead.Location = new Point(4, 24);
            tabPageRead.Name = "tabPageRead";
            tabPageRead.Padding = new Padding(3);
            tabPageRead.Size = new Size(433, 568);
            tabPageRead.TabIndex = 1;
            tabPageRead.Text = "קבלת מוצר";
            tabPageRead.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Location = new Point(4, 24);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(433, 568);
            tabPageUpdate.TabIndex = 2;
            tabPageUpdate.Text = "עדכון מוצר";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // tabPageDelete
            // 
            tabPageDelete.Location = new Point(4, 24);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Padding = new Padding(3);
            tabPageDelete.Size = new Size(433, 568);
            tabPageDelete.TabIndex = 3;
            tabPageDelete.Text = "מחיקת מוצר";
            tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // ProductMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 787);
            Controls.Add(tabControl1);
            Name = "ProductMenu";
            Text = "ProductMenu";
            tabControl1.ResumeLayout(false);
            tabPageCreate.ResumeLayout(false);
            tabPageCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion
        //private static IBl Ibl = new BlApi.Factory.Get();
        private TabControl tabControl1;
        private TabPage tabPageCreate;
        private TabPage tabPageRead;
        private TabPage tabPageUpdate;
        private TabPage tabPageDelete;
        private TextBox textBoxName;
        private Label lblName;
        private ComboBox comboBox1;
        private Label lblCategory;
        private NumericUpDown numericUpDownPrice;
        private Label lblPrice;
        private NumericUpDown numericUpDownAmount;
        private Label lblAmount;
        private Button btnCreate;
    }
}