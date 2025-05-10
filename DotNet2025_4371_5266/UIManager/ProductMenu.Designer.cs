using BlApi;

namespace UIManager
{
    partial class ProductMenu
    {
        //private IBl Ibl = new BlApi.Factory.Get();

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
            tabControl = new TabControl();
            tabPageCreate = new TabPage();
            btnCreate = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageRead = new TabPage();
            tabPageUpdate = new TabPage();
            tabPageDelete = new TabPage();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            tabControl.SuspendLayout();
            tabPageCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageCreate);
            tabControl.Controls.Add(tabPageRead);
            tabControl.Controls.Add(tabPageUpdate);
            tabControl.Controls.Add(tabPageDelete);
            tabControl.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            tabControl.Location = new Point(171, 122);
            tabControl.Name = "tabControl";
            tabControl.RightToLeft = RightToLeft.Yes;
            tabControl.RightToLeftLayout = true;
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(459, 591);
            tabControl.TabIndex = 1;
            // 
            // tabPageCreate
            // 
            tabPageCreate.Controls.Add(numericUpDown2);
            tabPageCreate.Controls.Add(numericUpDown1);
            tabPageCreate.Controls.Add(btnCreate);
            tabPageCreate.Controls.Add(comboBox1);
            tabPageCreate.Controls.Add(textBox1);
            tabPageCreate.Controls.Add(label4);
            tabPageCreate.Controls.Add(label3);
            tabPageCreate.Controls.Add(label2);
            tabPageCreate.Controls.Add(label1);
            tabPageCreate.Location = new Point(4, 25);
            tabPageCreate.Name = "tabPageCreate";
            tabPageCreate.Padding = new Padding(3);
            tabPageCreate.Size = new Size(451, 562);
            tabPageCreate.TabIndex = 0;
            tabPageCreate.Text = "הוספת מוצר";
            tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(185, 315);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(113, 28);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "הוספה";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "טיפוח_עור_הפנים ", "טיפוח_אישי ", "טיפוח_העור ", "משקאות", "מוצרי_כוורת" });
            comboBox1.Location = new Point(218, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "טיפוח_עור_הפנים ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 215);
            label4.Name = "label4";
            label4.Size = new Size(73, 16);
            label4.TabIndex = 0;
            label4.Text = "כמות במלאי";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 163);
            label3.Name = "label3";
            label3.Size = new Size(34, 16);
            label3.TabIndex = 0;
            label3.Text = "מחיר";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 107);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 0;
            label2.Text = "קטגוריה";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 62);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 0;
            label1.Text = "שם מוצר";
            // 
            // tabPageRead
            // 
            tabPageRead.Location = new Point(4, 25);
            tabPageRead.Name = "tabPageRead";
            tabPageRead.Padding = new Padding(3);
            tabPageRead.Size = new Size(451, 562);
            tabPageRead.TabIndex = 1;
            tabPageRead.Text = "קבלת מוצר";
            tabPageRead.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Location = new Point(4, 25);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(451, 562);
            tabPageUpdate.TabIndex = 2;
            tabPageUpdate.Text = "עדכון מוצר";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // tabPageDelete
            // 
            tabPageDelete.Location = new Point(4, 25);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Padding = new Padding(3);
            tabPageDelete.Size = new Size(451, 562);
            tabPageDelete.TabIndex = 3;
            tabPageDelete.Text = "מחיקת מוצר";
            tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(219, 161);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(104, 208);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // ProductMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 834);
            Controls.Add(tabControl);
            Name = "ProductMenu";
            Text = "ProductMenu";
            tabControl.ResumeLayout(false);
            tabPageCreate.ResumeLayout(false);
            tabPageCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageCreate;
        private Button btnCreate;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPageRead;
        private TabPage tabPageUpdate;
        private TabPage tabPageDelete;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}