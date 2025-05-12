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
            numericUpDownCustomerId = new NumericUpDown();
            btnLoginCustomer = new Button();
            btnCreateCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 77);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "מזהה לקוח";
            // 
            // numericUpDownCustomerId
            // 
            numericUpDownCustomerId.Location = new Point(356, 75);
            numericUpDownCustomerId.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownCustomerId.Name = "numericUpDownCustomerId";
            numericUpDownCustomerId.Size = new Size(120, 23);
            numericUpDownCustomerId.TabIndex = 1;
            // 
            // btnLoginCustomer
            // 
            btnLoginCustomer.Location = new Point(356, 125);
            btnLoginCustomer.Name = "btnLoginCustomer";
            btnLoginCustomer.Size = new Size(75, 23);
            btnLoginCustomer.TabIndex = 2;
            btnLoginCustomer.Text = "התחבר";
            btnLoginCustomer.UseVisualStyleBackColor = true;
            btnLoginCustomer.Click += btnLoginCustomer_Click;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.Location = new Point(493, 125);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(75, 23);
            btnCreateCustomer.TabIndex = 2;
            btnCreateCustomer.Text = "לקוח חדש";
            btnCreateCustomer.UseVisualStyleBackColor = true;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(394, 201);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(125, 23);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "לעדכון לקוח";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(394, 247);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(125, 23);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "למחיקת לקוח";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnCreateCustomer);
            Controls.Add(btnLoginCustomer);
            Controls.Add(numericUpDownCustomerId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownCustomerId;
        private Button btnLoginCustomer;
        private Button btnCreateCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
    }
}
