namespace UILogin
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
            lblNameStore = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblNameStore
            // 
            lblNameStore.AutoSize = true;
            lblNameStore.Font = new Font("Assistant ExtraBold", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 177);
            lblNameStore.ForeColor = Color.Coral;
            lblNameStore.Location = new Point(96, 84);
            lblNameStore.Name = "lblNameStore";
            lblNameStore.Size = new Size(606, 126);
            lblNameStore.TabIndex = 0;
            lblNameStore.Text = "Beauty Store";
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.Font = new Font("Assistant", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(420, 222);
            button1.Name = "button1";
            button1.Size = new Size(125, 43);
            button1.TabIndex = 1;
            button1.Text = "כניסת מנהל";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("Assistant", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Beige;
            button2.Location = new Point(265, 222);
            button2.Name = "button2";
            button2.Size = new Size(125, 43);
            button2.TabIndex = 1;
            button2.Text = "כניסת  קופאי";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblNameStore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameStore;
        private Button button1;
        private Button button2;
    }
}
