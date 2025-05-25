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
            lblProductId = new Label();
            lblAmount = new Label();
            numericUpDownProductId = new NumericUpDown();
            numericUpDownProductAmount = new NumericUpDown();
            btnAddToOrder = new Button();
            btnDoOrder = new Button();
            lblHelloCustomer = new Label();
            lblTotalPrice = new Label();
            lblPrice = new Label();
            label1 = new Label();
            lblProducts = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(726, 57);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(63, 15);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "מזהה מוצר";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(727, 140);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 15);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "כמות מוצר";
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Location = new Point(664, 75);
            numericUpDownProductId.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(120, 23);
            numericUpDownProductId.TabIndex = 2;
            // 
            // numericUpDownProductAmount
            // 
            numericUpDownProductAmount.Location = new Point(664, 158);
            numericUpDownProductAmount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownProductAmount.Name = "numericUpDownProductAmount";
            numericUpDownProductAmount.Size = new Size(120, 23);
            numericUpDownProductAmount.TabIndex = 2;
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(664, 232);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(109, 23);
            btnAddToOrder.TabIndex = 3;
            btnAddToOrder.Text = "הוסף להזמנה";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // btnDoOrder
            // 
            btnDoOrder.Location = new Point(677, 274);
            btnDoOrder.Name = "btnDoOrder";
            btnDoOrder.Size = new Size(75, 23);
            btnDoOrder.TabIndex = 4;
            btnDoOrder.Text = "סיום הזמנה";
            btnDoOrder.UseVisualStyleBackColor = true;
            btnDoOrder.Click += btnDoOrder_Click;
            // 
            // lblHelloCustomer
            // 
            lblHelloCustomer.AutoSize = true;
            lblHelloCustomer.Font = new Font("Assistant", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelloCustomer.ForeColor = Color.Coral;
            lblHelloCustomer.Location = new Point(122, 9);
            lblHelloCustomer.Name = "lblHelloCustomer";
            lblHelloCustomer.RightToLeft = RightToLeft.Yes;
            lblHelloCustomer.Size = new Size(0, 17);
            lblHelloCustomer.TabIndex = 10;
            lblHelloCustomer.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(12, 33);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(13, 15);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.Text = "0";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(94, 33);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(79, 15);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "מחיר לתשלום";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 140);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 13;
            label1.Text = "מוצרים";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(25, 180);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(0, 15);
            lblProducts.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(159, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 387);
            dataGridView1.TabIndex = 15;
            // 
            // ProductsRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 468);
            Controls.Add(dataGridView1);
            Controls.Add(lblProducts);
            Controls.Add(label1);
            Controls.Add(lblPrice);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblHelloCustomer);
            Controls.Add(btnDoOrder);
            Controls.Add(btnAddToOrder);
            Controls.Add(numericUpDownProductAmount);
            Controls.Add(numericUpDownProductId);
            Controls.Add(lblAmount);
            Controls.Add(lblProductId);
            Name = "ProductsRead";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductId;
        private Label lblAmount;
        private NumericUpDown numericUpDownProductId;
        private NumericUpDown numericUpDownProductAmount;
        private Button btnAddToOrder;
        private Button btnDoOrder;
        private Label lblHelloCustomer;
        private Label lblTotalPrice;
        private Label lblPrice;
        private Label label1;
        private Label lblProducts;
        private DataGridView dataGridView1;
    }
}