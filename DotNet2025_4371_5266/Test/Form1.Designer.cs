namespace UIManager
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
            lblHelloManager = new Label();
            SuspendLayout();
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.LightCoral;
            btnSales.Font = new Font("Segoe UI", 20F);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(292, 304);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(216, 60);
            btnSales.TabIndex = 5;
            btnSales.Text = "ניהול מבצעים";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.LightCoral;
            btnCustomers.Font = new Font("Segoe UI", 20F);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(292, 191);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(216, 60);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "ניהול לקוחות";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.LightCoral;
            btnProducts.Font = new Font("Segoe UI", 20F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(292, 86);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(216, 60);
            btnProducts.TabIndex = 7;
            btnProducts.Text = "ניהול מוצרים";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // lblHelloManager
            // 
            lblHelloManager.AutoSize = true;
            lblHelloManager.Font = new Font("Assistant", 12F, FontStyle.Bold);
            lblHelloManager.ForeColor = Color.Coral;
            lblHelloManager.Location = new Point(412, 42);
            lblHelloManager.Name = "lblHelloManager";
            lblHelloManager.Size = new Size(0, 21);
            lblHelloManager.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloManager);
            Controls.Add(btnSales);
            Controls.Add(btnCustomers);
            Controls.Add(btnProducts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSales;
        private Button btnCustomers;
        private Button btnProducts;
        private Label lblHelloManager;
    }
}
