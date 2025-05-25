using BlApi;

namespace UIManager
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
            btnRest = new Button();
            lblReadAllProducts = new Label();
            btnFilter = new Button();
            btnId = new Button();
            textBoxFilter = new TextBox();
            numericUpDownId = new NumericUpDown();
            lblFilter = new Label();
            lblId = new Label();
            tabPageUpdate = new TabPage();
            numericUpDownIdUpdate = new NumericUpDown();
            numericUpDownAmountUpdate = new NumericUpDown();
            numericUpDownPriceUpdate = new NumericUpDown();
            comboBoxCategoryUpdate = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxNameUpdate = new TextBox();
            label8 = new Label();
            btnUpdate = new Button();
            label1 = new Label();
            tabPageDelete = new TabPage();
            btnDelete = new Button();
            numericUpDownDelete = new NumericUpDown();
            lblDelete = new Label();
            tabControl1.SuspendLayout();
            tabPageCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            tabPageRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceUpdate).BeginInit();
            tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelete).BeginInit();
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
            tabPageRead.AutoScroll = true;
            tabPageRead.Controls.Add(btnRest);
            tabPageRead.Controls.Add(lblReadAllProducts);
            tabPageRead.Controls.Add(btnFilter);
            tabPageRead.Controls.Add(btnId);
            tabPageRead.Controls.Add(textBoxFilter);
            tabPageRead.Controls.Add(numericUpDownId);
            tabPageRead.Controls.Add(lblFilter);
            tabPageRead.Controls.Add(lblId);
            tabPageRead.Location = new Point(4, 24);
            tabPageRead.Name = "tabPageRead";
            tabPageRead.Padding = new Padding(3);
            tabPageRead.Size = new Size(433, 568);
            tabPageRead.TabIndex = 1;
            tabPageRead.Text = "קבלת מוצר";
            tabPageRead.UseVisualStyleBackColor = true;
            // 
            // btnRest
            // 
            btnRest.Location = new Point(215, 348);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(75, 23);
            btnRest.TabIndex = 6;
            btnRest.Text = "ניקוי";
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Click += btnRest_Click_1;
            // 
            // lblReadAllProducts
            // 
            lblReadAllProducts.AutoSize = true;
            lblReadAllProducts.Location = new Point(58, 47);
            lblReadAllProducts.Name = "lblReadAllProducts";
            lblReadAllProducts.RightToLeft = RightToLeft.No;
            lblReadAllProducts.Size = new Size(38, 15);
            lblReadAllProducts.TabIndex = 5;
            lblReadAllProducts.Text = "label2";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(286, 259);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "אישור";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnId
            // 
            btnId.Location = new Point(286, 100);
            btnId.Name = "btnId";
            btnId.Size = new Size(75, 23);
            btnId.TabIndex = 3;
            btnId.Text = "אישור";
            btnId.UseVisualStyleBackColor = true;
            btnId.Click += btnRead_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(224, 214);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(100, 23);
            textBoxFilter.TabIndex = 2;
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(204, 38);
            numericUpDownId.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(120, 23);
            numericUpDownId.TabIndex = 1;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(358, 217);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(52, 15);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "שם מוצר";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(358, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(63, 15);
            lblId.TabIndex = 0;
            lblId.Text = "מזהה מוצר";
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(numericUpDownIdUpdate);
            tabPageUpdate.Controls.Add(numericUpDownAmountUpdate);
            tabPageUpdate.Controls.Add(numericUpDownPriceUpdate);
            tabPageUpdate.Controls.Add(comboBoxCategoryUpdate);
            tabPageUpdate.Controls.Add(label5);
            tabPageUpdate.Controls.Add(label6);
            tabPageUpdate.Controls.Add(label7);
            tabPageUpdate.Controls.Add(textBoxNameUpdate);
            tabPageUpdate.Controls.Add(label8);
            tabPageUpdate.Controls.Add(btnUpdate);
            tabPageUpdate.Controls.Add(label1);
            tabPageUpdate.Location = new Point(4, 24);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(433, 568);
            tabPageUpdate.TabIndex = 2;
            tabPageUpdate.Text = "עדכון מוצר";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIdUpdate
            // 
            numericUpDownIdUpdate.Location = new Point(175, 64);
            numericUpDownIdUpdate.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownIdUpdate.Name = "numericUpDownIdUpdate";
            numericUpDownIdUpdate.Size = new Size(120, 23);
            numericUpDownIdUpdate.TabIndex = 14;
            // 
            // numericUpDownAmountUpdate
            // 
            numericUpDownAmountUpdate.Location = new Point(155, 271);
            numericUpDownAmountUpdate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAmountUpdate.Name = "numericUpDownAmountUpdate";
            numericUpDownAmountUpdate.Size = new Size(120, 23);
            numericUpDownAmountUpdate.TabIndex = 12;
            // 
            // numericUpDownPriceUpdate
            // 
            numericUpDownPriceUpdate.DecimalPlaces = 2;
            numericUpDownPriceUpdate.Location = new Point(154, 214);
            numericUpDownPriceUpdate.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numericUpDownPriceUpdate.Name = "numericUpDownPriceUpdate";
            numericUpDownPriceUpdate.Size = new Size(120, 23);
            numericUpDownPriceUpdate.TabIndex = 13;
            // 
            // comboBoxCategoryUpdate
            // 
            comboBoxCategoryUpdate.FormattingEnabled = true;
            comboBoxCategoryUpdate.Items.AddRange(new object[] { "טיפוח_עור_הפנים", "טיפוח_אישי ", "טיפוח_העור ", "משקאות", "מוצרי_כוורת" });
            comboBoxCategoryUpdate.Location = new Point(154, 168);
            comboBoxCategoryUpdate.Name = "comboBoxCategoryUpdate";
            comboBoxCategoryUpdate.Size = new Size(121, 23);
            comboBoxCategoryUpdate.TabIndex = 11;
            comboBoxCategoryUpdate.Text = "טיפוח_עור_הפנים";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 279);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "כמות במלאי";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 216);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 9;
            label6.Text = "מחיר";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 168);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 10;
            label7.Text = "קטגוריה";
            // 
            // textBoxNameUpdate
            // 
            textBoxNameUpdate.Location = new Point(175, 114);
            textBoxNameUpdate.Name = "textBoxNameUpdate";
            textBoxNameUpdate.Size = new Size(100, 23);
            textBoxNameUpdate.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(294, 117);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 6;
            label8.Text = "שם מוצר";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(200, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "עדכון";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 64);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "מזהה מוצר";
            // 
            // tabPageDelete
            // 
            tabPageDelete.Controls.Add(btnDelete);
            tabPageDelete.Controls.Add(numericUpDownDelete);
            tabPageDelete.Controls.Add(lblDelete);
            tabPageDelete.Location = new Point(4, 24);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Padding = new Padding(3);
            tabPageDelete.Size = new Size(433, 568);
            tabPageDelete.TabIndex = 3;
            tabPageDelete.Text = "מחיקת מוצר";
            tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(222, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "מחיקה";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // numericUpDownDelete
            // 
            numericUpDownDelete.Location = new Point(177, 81);
            numericUpDownDelete.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownDelete.Name = "numericUpDownDelete";
            numericUpDownDelete.Size = new Size(120, 23);
            numericUpDownDelete.TabIndex = 1;
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Location = new Point(317, 81);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(63, 15);
            lblDelete.TabIndex = 0;
            lblDelete.Text = "מזהה מוצר";
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
            tabPageRead.ResumeLayout(false);
            tabPageRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceUpdate).EndInit();
            tabPageDelete.ResumeLayout(false);
            tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelete).EndInit();
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
        private NumericUpDown numericUpDownId;
        private Label lblId;
        private TextBox textBoxFilter;
        private Label lblFilter;
        private Button btnId;
        private Button btnFilter;
        private Button btnUpdate;
        private Label label1;
        private NumericUpDown numericUpDownAmountUpdate;
        private NumericUpDown numericUpDownPriceUpdate;
        private ComboBox comboBoxCategoryUpdate;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxNameUpdate;
        private Label label8;
        private NumericUpDown numericUpDownIdUpdate;
        private Label lblDelete;
        private Button btnDelete;
        private NumericUpDown numericUpDownDelete;
        private Label lblReadAllProducts;
        private Button btnRest;
    }
}