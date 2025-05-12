namespace UICashier
{
    partial class ProductsRead
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
            dataGridView1 = new DataGridView();
            lblProductId = new Label();
            lblAmount = new Label();
            numericUpDownProductId = new NumericUpDown();
            numericUpDownProductAmount = new NumericUpDown();
            btnAddToOrder = new Button();
            btnDoOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductAmount).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(131, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 574);
            dataGridView1.TabIndex = 0;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(688, 55);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(63, 15);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "מזהה מוצר";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(470, 55);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 15);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "כמות מוצר";
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Location = new Point(562, 55);
            numericUpDownProductId.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(120, 23);
            numericUpDownProductId.TabIndex = 2;
            // 
            // numericUpDownProductAmount
            // 
            numericUpDownProductAmount.Location = new Point(324, 53);
            numericUpDownProductAmount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownProductAmount.Name = "numericUpDownProductAmount";
            numericUpDownProductAmount.Size = new Size(120, 23);
            numericUpDownProductAmount.TabIndex = 2;
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(184, 53);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(109, 23);
            btnAddToOrder.TabIndex = 3;
            btnAddToOrder.Text = "הוסף להזמנה";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // btnDoOrder
            // 
            btnDoOrder.Location = new Point(73, 51);
            btnDoOrder.Name = "btnDoOrder";
            btnDoOrder.Size = new Size(75, 23);
            btnDoOrder.TabIndex = 4;
            btnDoOrder.Text = "סיום הזמנה";
            btnDoOrder.UseVisualStyleBackColor = true;
            btnDoOrder.Click += btnDoOrder_Click;
            // 
            // ProductsRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 884);
            Controls.Add(btnDoOrder);
            Controls.Add(btnAddToOrder);
            Controls.Add(numericUpDownProductAmount);
            Controls.Add(numericUpDownProductId);
            Controls.Add(lblAmount);
            Controls.Add(lblProductId);
            Controls.Add(dataGridView1);
            Name = "ProductsRead";
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblProductId;
        private Label lblAmount;
        private NumericUpDown numericUpDownProductId;
        private NumericUpDown numericUpDownProductAmount;
        private Button btnAddToOrder;
        private Button btnDoOrder;
    }
}