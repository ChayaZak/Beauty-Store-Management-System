namespace UIManager
{
    partial class SaleMenu
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
            checkBoxIsClab = new CheckBox();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerFirst = new DateTimePicker();
            btnCreate = new Button();
            numericUpDownMinQuantity = new NumericUpDown();
            numericUpDownProductId = new NumericUpDown();
            numericUpDownCode = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            label4 = new Label();
            lblAmount = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            label2 = new Label();
            lblName = new Label();
            tabPageRead = new TabPage();
            btnRest = new Button();
            lblReadAllSales = new Label();
            btnFilter = new Button();
            btnId = new Button();
            textBoxFilter = new TextBox();
            numericUpDownId = new NumericUpDown();
            lblFilter = new Label();
            lblId = new Label();
            tabPageUpdate = new TabPage();
            checkBoxIsClabUpdate = new CheckBox();
            dateTimePickerEndUpdate = new DateTimePicker();
            dateTimePickerFirstUpdate = new DateTimePicker();
            btnUpdate = new Button();
            numericUpDownMinQuantityUpdate = new NumericUpDown();
            numericUpDownProductIdUpdate = new NumericUpDown();
            numericUpDownSaleCode = new NumericUpDown();
            numericUpDownPriceUpdate = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tabPageDelete = new TabPage();
            btnDelete = new Button();
            numericUpDownDelete = new NumericUpDown();
            lblDelete = new Label();
            tabControl1.SuspendLayout();
            tabPageCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            tabPageRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinQuantityUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductIdUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleCode).BeginInit();
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
            tabControl1.Location = new Point(180, 105);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(441, 596);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCreate
            // 
            tabPageCreate.Controls.Add(checkBoxIsClab);
            tabPageCreate.Controls.Add(dateTimePickerEnd);
            tabPageCreate.Controls.Add(dateTimePickerFirst);
            tabPageCreate.Controls.Add(btnCreate);
            tabPageCreate.Controls.Add(numericUpDownMinQuantity);
            tabPageCreate.Controls.Add(numericUpDownProductId);
            tabPageCreate.Controls.Add(numericUpDownCode);
            tabPageCreate.Controls.Add(numericUpDownPrice);
            tabPageCreate.Controls.Add(label4);
            tabPageCreate.Controls.Add(lblAmount);
            tabPageCreate.Controls.Add(lblPrice);
            tabPageCreate.Controls.Add(lblCategory);
            tabPageCreate.Controls.Add(label2);
            tabPageCreate.Controls.Add(lblName);
            tabPageCreate.Location = new Point(4, 24);
            tabPageCreate.Name = "tabPageCreate";
            tabPageCreate.Padding = new Padding(3);
            tabPageCreate.Size = new Size(433, 568);
            tabPageCreate.TabIndex = 0;
            tabPageCreate.Text = "הוספת מבצע";
            tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsClab
            // 
            checkBoxIsClab.AutoSize = true;
            checkBoxIsClab.Location = new Point(269, 233);
            checkBoxIsClab.Name = "checkBoxIsClab";
            checkBoxIsClab.Size = new Size(127, 19);
            checkBoxIsClab.TabIndex = 8;
            checkBoxIsClab.Text = "לקוחות מועדון בלבד";
            checkBoxIsClab.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(42, 332);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 7;
            // 
            // dateTimePickerFirst
            // 
            dateTimePickerFirst.Location = new Point(42, 273);
            dateTimePickerFirst.Name = "dateTimePickerFirst";
            dateTimePickerFirst.Size = new Size(200, 23);
            dateTimePickerFirst.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(197, 393);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "הוספה";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // numericUpDownMinQuantity
            // 
            numericUpDownMinQuantity.Location = new Point(164, 134);
            numericUpDownMinQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownMinQuantity.Name = "numericUpDownMinQuantity";
            numericUpDownMinQuantity.Size = new Size(120, 23);
            numericUpDownMinQuantity.TabIndex = 4;
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Location = new Point(164, 91);
            numericUpDownProductId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(120, 23);
            numericUpDownProductId.TabIndex = 4;
            // 
            // numericUpDownCode
            // 
            numericUpDownCode.Location = new Point(164, 56);
            numericUpDownCode.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownCode.Name = "numericUpDownCode";
            numericUpDownCode.Size = new Size(120, 23);
            numericUpDownCode.TabIndex = 4;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(174, 185);
            numericUpDownPrice.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 273);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 2;
            label4.Text = "תאריך התחלת המבצע";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(278, 338);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(106, 15);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "תאריך סיום המבצע";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(330, 190);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "מחיר";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(330, 142);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(83, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "כמות מינימלית";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 64);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "קוד מבצע";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(330, 99);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 15);
            lblName.TabIndex = 0;
            lblName.Text = "מזהה מוצר";
            // 
            // tabPageRead
            // 
            tabPageRead.AutoScroll = true;
            tabPageRead.Controls.Add(btnRest);
            tabPageRead.Controls.Add(lblReadAllSales);
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
            tabPageRead.Text = "קבלת מבצע";
            tabPageRead.UseVisualStyleBackColor = true;
            // 
            // btnRest
            // 
            btnRest.Location = new Point(202, 376);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(75, 23);
            btnRest.TabIndex = 5;
            btnRest.Text = "ניקוי";
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Click += btnRest_Click;
            // 
            // lblReadAllSales
            // 
            lblReadAllSales.AutoSize = true;
            lblReadAllSales.Location = new Point(22, 29);
            lblReadAllSales.Name = "lblReadAllSales";
            lblReadAllSales.RightToLeft = RightToLeft.No;
            lblReadAllSales.Size = new Size(38, 15);
            lblReadAllSales.TabIndex = 4;
            lblReadAllSales.Text = "label9";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(284, 265);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "אישור";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnId
            // 
            btnId.Location = new Point(284, 106);
            btnId.Name = "btnId";
            btnId.Size = new Size(75, 23);
            btnId.TabIndex = 3;
            btnId.Text = "אישור";
            btnId.UseVisualStyleBackColor = true;
            btnId.Click += btnRead_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(222, 220);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(100, 23);
            textBoxFilter.TabIndex = 2;
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(202, 44);
            numericUpDownId.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(120, 23);
            numericUpDownId.TabIndex = 1;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(359, 226);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(52, 15);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "קוד מוצר";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(359, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(56, 15);
            lblId.TabIndex = 0;
            lblId.Text = "קוד מבצע";
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(checkBoxIsClabUpdate);
            tabPageUpdate.Controls.Add(dateTimePickerEndUpdate);
            tabPageUpdate.Controls.Add(dateTimePickerFirstUpdate);
            tabPageUpdate.Controls.Add(btnUpdate);
            tabPageUpdate.Controls.Add(numericUpDownMinQuantityUpdate);
            tabPageUpdate.Controls.Add(numericUpDownProductIdUpdate);
            tabPageUpdate.Controls.Add(numericUpDownSaleCode);
            tabPageUpdate.Controls.Add(numericUpDownPriceUpdate);
            tabPageUpdate.Controls.Add(label1);
            tabPageUpdate.Controls.Add(label3);
            tabPageUpdate.Controls.Add(label5);
            tabPageUpdate.Controls.Add(label6);
            tabPageUpdate.Controls.Add(label7);
            tabPageUpdate.Controls.Add(label8);
            tabPageUpdate.Location = new Point(4, 24);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(433, 568);
            tabPageUpdate.TabIndex = 2;
            tabPageUpdate.Text = "עדכון מבצע";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsClabUpdate
            // 
            checkBoxIsClabUpdate.AutoSize = true;
            checkBoxIsClabUpdate.Location = new Point(260, 247);
            checkBoxIsClabUpdate.Name = "checkBoxIsClabUpdate";
            checkBoxIsClabUpdate.Size = new Size(127, 19);
            checkBoxIsClabUpdate.TabIndex = 22;
            checkBoxIsClabUpdate.Text = "לקוחות מועדון בלבד";
            checkBoxIsClabUpdate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEndUpdate
            // 
            dateTimePickerEndUpdate.Location = new Point(33, 346);
            dateTimePickerEndUpdate.Name = "dateTimePickerEndUpdate";
            dateTimePickerEndUpdate.Size = new Size(200, 23);
            dateTimePickerEndUpdate.TabIndex = 21;
            // 
            // dateTimePickerFirstUpdate
            // 
            dateTimePickerFirstUpdate.Location = new Point(33, 287);
            dateTimePickerFirstUpdate.Name = "dateTimePickerFirstUpdate";
            dateTimePickerFirstUpdate.Size = new Size(200, 23);
            dateTimePickerFirstUpdate.TabIndex = 20;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(188, 407);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "עדכון";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // numericUpDownMinQuantityUpdate
            // 
            numericUpDownMinQuantityUpdate.Location = new Point(155, 148);
            numericUpDownMinQuantityUpdate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownMinQuantityUpdate.Name = "numericUpDownMinQuantityUpdate";
            numericUpDownMinQuantityUpdate.Size = new Size(120, 23);
            numericUpDownMinQuantityUpdate.TabIndex = 15;
            // 
            // numericUpDownProductIdUpdate
            // 
            numericUpDownProductIdUpdate.Location = new Point(155, 105);
            numericUpDownProductIdUpdate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownProductIdUpdate.Name = "numericUpDownProductIdUpdate";
            numericUpDownProductIdUpdate.Size = new Size(120, 23);
            numericUpDownProductIdUpdate.TabIndex = 16;
            // 
            // numericUpDownSaleCode
            // 
            numericUpDownSaleCode.Location = new Point(155, 70);
            numericUpDownSaleCode.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSaleCode.Name = "numericUpDownSaleCode";
            numericUpDownSaleCode.Size = new Size(120, 23);
            numericUpDownSaleCode.TabIndex = 17;
            // 
            // numericUpDownPriceUpdate
            // 
            numericUpDownPriceUpdate.DecimalPlaces = 2;
            numericUpDownPriceUpdate.Location = new Point(165, 199);
            numericUpDownPriceUpdate.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numericUpDownPriceUpdate.Name = "numericUpDownPriceUpdate";
            numericUpDownPriceUpdate.Size = new Size(120, 23);
            numericUpDownPriceUpdate.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 287);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 11;
            label1.Text = "תאריך התחלת המבצע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 352);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 12;
            label3.Text = "תאריך סיום המבצע";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 204);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 13;
            label5.Text = "מחיר";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 156);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 14;
            label6.Text = "כמות מינימלית";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(321, 78);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 9;
            label7.Text = "קוד מבצע";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 113);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 10;
            label8.Text = "מזהה מוצר";
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
            tabPageDelete.Text = "מחיקת מבצע";
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
            lblDelete.Location = new Point(320, 84);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(56, 15);
            lblDelete.TabIndex = 0;
            lblDelete.Text = "קוד מבצע";
            // 
            // SaleMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 806);
            Controls.Add(tabControl1);
            Name = "SaleMenu";
            Text = "SaleMenu";
            tabControl1.ResumeLayout(false);
            tabPageCreate.ResumeLayout(false);
            tabPageCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            tabPageRead.ResumeLayout(false);
            tabPageRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinQuantityUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductIdUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceUpdate).EndInit();
            tabPageDelete.ResumeLayout(false);
            tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCreate;
        private Button btnCreate;
        private NumericUpDown numericUpDownPrice;
        private Label lblAmount;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblName;
        private TabPage tabPageRead;
        private Button btnFilter;
        private Button btnId;
        private TextBox textBoxFilter;
        private NumericUpDown numericUpDownId;
        private Label lblFilter;
        private Label lblId;
        private TabPage tabPageUpdate;
        private TabPage tabPageDelete;
        private Button btnDelete;
        private NumericUpDown numericUpDownDelete;
        private Label lblDelete;
        private Label label2;
        private Label label4;
        private NumericUpDown numericUpDownMinQuantity;
        private NumericUpDown numericUpDownProductId;
        private NumericUpDown numericUpDownCode;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerFirst;
        private CheckBox checkBoxIsClab;
        private CheckBox checkBoxIsClabUpdate;
        private DateTimePicker dateTimePickerEndUpdate;
        private DateTimePicker dateTimePickerFirstUpdate;
        private Button btnUpdate;
        private NumericUpDown numericUpDownMinQuantityUpdate;
        private NumericUpDown numericUpDownProductIdUpdate;
        private NumericUpDown numericUpDownSaleCode;
        private NumericUpDown numericUpDownPriceUpdate;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblReadAllSales;
        private Button btnRest;
    }
}