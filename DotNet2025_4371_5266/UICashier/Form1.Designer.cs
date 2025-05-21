namespace UICashier
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
            label1 = new Label();
            btnLoginCustomer = new Button();
            btnCreateCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            lblHelloCashier = new Label();
            textBoxCustomerId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 138);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "מזהה לקוח";
            // 
            // btnLoginCustomer
            // 
            btnLoginCustomer.Location = new Point(303, 186);
            btnLoginCustomer.Name = "btnLoginCustomer";
            btnLoginCustomer.Size = new Size(75, 23);
            btnLoginCustomer.TabIndex = 2;
            btnLoginCustomer.Text = "התחבר";
            btnLoginCustomer.UseVisualStyleBackColor = true;
            btnLoginCustomer.Click += btnLoginCustomer_Click;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.Location = new Point(440, 186);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(75, 23);
            btnCreateCustomer.TabIndex = 2;
            btnCreateCustomer.Text = "לקוח חדש";
            btnCreateCustomer.UseVisualStyleBackColor = true;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(341, 262);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(125, 23);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "לעדכון לקוח";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(341, 308);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(125, 23);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "למחיקת לקוח";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // lblHelloCashier
            // 
            lblHelloCashier.AutoSize = true;
            lblHelloCashier.Font = new Font("Assistant", 12F, FontStyle.Bold);
            lblHelloCashier.ForeColor = Color.Coral;
            lblHelloCashier.Location = new Point(504, 40);
            lblHelloCashier.Name = "lblHelloCashier";
            lblHelloCashier.Size = new Size(0, 21);
            lblHelloCashier.TabIndex = 9;
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Location = new Point(303, 138);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(100, 23);
            textBoxCustomerId.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCustomerId);
            Controls.Add(lblHelloCashier);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnCreateCustomer);
            Controls.Add(btnLoginCustomer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLoginCustomer;
        private Button btnCreateCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private Label lblHelloCashier;
        private TextBox textBoxCustomerId;
    }
}
