namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSales = new Button();
            btnCustomers = new Button();
            btnProducts = new Button();
            SuspendLayout();
            // 
            // btnSales
            // 
            btnSales.Font = new Font("Segoe UI", 20F);
            btnSales.Location = new Point(292, 304);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(216, 60);
            btnSales.TabIndex = 5;
            btnSales.Text = "ניהול מבצעים";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI", 20F);
            btnCustomers.Location = new Point(292, 191);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(216, 60);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "ניהול לקוחות";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 20F);
            btnProducts.Location = new Point(292, 86);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(216, 60);
            btnProducts.TabIndex = 7;
            btnProducts.Text = "ניהול מוצרים";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSales);
            Controls.Add(btnCustomers);
            Controls.Add(btnProducts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSales;
        private Button btnCustomers;
        private Button btnProducts;
    }
}
