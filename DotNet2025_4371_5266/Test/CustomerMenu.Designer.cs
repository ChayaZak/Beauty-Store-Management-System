namespace UIManager
{
    partial class CustomerMenu
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
            numericUpDownCustomerId = new NumericUpDown();
            lblCustomerId = new Label();
            numericUpDownPhone = new NumericUpDown();
            lblPhone = new Label();
            textBoxAddress = new TextBox();
            lblAddress = new Label();
            textBoxName = new TextBox();
            lblName = new Label();
            tabPageUpdate = new TabPage();
            numericUpDownCustomeIdUpdate = new NumericUpDown();
            label1 = new Label();
            btnUpdate = new Button();
            numericUpDownCustomerPhoneUpdate = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            textBoxCustomerNameUpdate = new TextBox();
            textBoxCustomeAddressUpdate = new TextBox();
            label3 = new Label();
            tabPageDelete = new TabPage();
            btnDelete = new Button();
            numericUpDownDelete = new NumericUpDown();
            lblDelete = new Label();
            tabPageRead = new TabPage();
            btnFilter = new Button();
            btnId = new Button();
            textBoxFilter = new TextBox();
            numericUpDownId = new NumericUpDown();
            lblFilter = new Label();
            lblId = new Label();
            tabControl1.SuspendLayout();
            tabPageCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPhone).BeginInit();
            tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomeIdUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerPhoneUpdate).BeginInit();
            tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelete).BeginInit();
            tabPageRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCreate);
            tabControl1.Controls.Add(tabPageUpdate);
            tabControl1.Controls.Add(tabPageDelete);
            tabControl1.Controls.Add(tabPageRead);
            tabControl1.Location = new Point(180, 51);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(441, 596);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCreate
            // 
            tabPageCreate.Controls.Add(btnCreate);
            tabPageCreate.Controls.Add(numericUpDownCustomerId);
            tabPageCreate.Controls.Add(lblCustomerId);
            tabPageCreate.Controls.Add(numericUpDownPhone);
            tabPageCreate.Controls.Add(lblPhone);
            tabPageCreate.Controls.Add(textBoxAddress);
            tabPageCreate.Controls.Add(lblAddress);
            tabPageCreate.Controls.Add(textBoxName);
            tabPageCreate.Controls.Add(lblName);
            tabPageCreate.Location = new Point(4, 24);
            tabPageCreate.Name = "tabPageCreate";
            tabPageCreate.Padding = new Padding(3);
            tabPageCreate.Size = new Size(433, 568);
            tabPageCreate.TabIndex = 0;
            tabPageCreate.Text = "הוספת לקוח";
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
            // numericUpDownCustomerId
            // 
            numericUpDownCustomerId.Location = new Point(197, 65);
            numericUpDownCustomerId.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownCustomerId.Name = "numericUpDownCustomerId";
            numericUpDownCustomerId.Size = new Size(120, 23);
            numericUpDownCustomerId.TabIndex = 4;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(343, 70);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(64, 15);
            lblCustomerId.TabIndex = 2;
            lblCustomerId.Text = "מזהה לקוח";
            // 
            // numericUpDownPhone
            // 
            numericUpDownPhone.Location = new Point(209, 216);
            numericUpDownPhone.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownPhone.Name = "numericUpDownPhone";
            numericUpDownPhone.Size = new Size(120, 23);
            numericUpDownPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(356, 221);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(36, 15);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "טלפון";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(218, 159);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 23);
            textBoxAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(343, 168);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(42, 15);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "כתובת";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(218, 114);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(343, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 15);
            lblName.TabIndex = 0;
            lblName.Text = "שם לקוח";
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(numericUpDownCustomeIdUpdate);
            tabPageUpdate.Controls.Add(label1);
            tabPageUpdate.Controls.Add(btnUpdate);
            tabPageUpdate.Controls.Add(numericUpDownCustomerPhoneUpdate);
            tabPageUpdate.Controls.Add(label4);
            tabPageUpdate.Controls.Add(label2);
            tabPageUpdate.Controls.Add(textBoxCustomerNameUpdate);
            tabPageUpdate.Controls.Add(textBoxCustomeAddressUpdate);
            tabPageUpdate.Controls.Add(label3);
            tabPageUpdate.Location = new Point(4, 24);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3);
            tabPageUpdate.Size = new Size(433, 568);
            tabPageUpdate.TabIndex = 2;
            tabPageUpdate.Text = "עדכון לקוח";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCustomeIdUpdate
            // 
            numericUpDownCustomeIdUpdate.Location = new Point(155, 112);
            numericUpDownCustomeIdUpdate.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownCustomeIdUpdate.Name = "numericUpDownCustomeIdUpdate";
            numericUpDownCustomeIdUpdate.Size = new Size(120, 23);
            numericUpDownCustomeIdUpdate.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 117);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "מזהה לקוח";
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
            // numericUpDownCustomerPhoneUpdate
            // 
            numericUpDownCustomerPhoneUpdate.Location = new Point(167, 263);
            numericUpDownCustomerPhoneUpdate.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownCustomerPhoneUpdate.Name = "numericUpDownCustomerPhoneUpdate";
            numericUpDownCustomerPhoneUpdate.Size = new Size(120, 23);
            numericUpDownCustomerPhoneUpdate.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 170);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "שם לקוח";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 268);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 10;
            label2.Text = "טלפון";
            // 
            // textBoxCustomerNameUpdate
            // 
            textBoxCustomerNameUpdate.Location = new Point(176, 161);
            textBoxCustomerNameUpdate.Name = "textBoxCustomerNameUpdate";
            textBoxCustomerNameUpdate.Size = new Size(100, 23);
            textBoxCustomerNameUpdate.TabIndex = 8;
            // 
            // textBoxCustomeAddressUpdate
            // 
            textBoxCustomeAddressUpdate.Location = new Point(176, 206);
            textBoxCustomeAddressUpdate.Name = "textBoxCustomeAddressUpdate";
            textBoxCustomeAddressUpdate.Size = new Size(100, 23);
            textBoxCustomeAddressUpdate.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 215);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "כתובת";
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
            tabPageDelete.Text = "מחיקת לקוח";
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
            numericUpDownDelete.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownDelete.Name = "numericUpDownDelete";
            numericUpDownDelete.Size = new Size(120, 23);
            numericUpDownDelete.TabIndex = 1;
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Location = new Point(323, 87);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(64, 15);
            lblDelete.TabIndex = 0;
            lblDelete.Text = "מזהה לקוח";
            // 
            // tabPageRead
            // 
            tabPageRead.Controls.Add(btnFilter);
            tabPageRead.Controls.Add(btnId);
            tabPageRead.Controls.Add(textBoxFilter);
            tabPageRead.Controls.Add(numericUpDownId);
            tabPageRead.Controls.Add(lblFilter);
            tabPageRead.Controls.Add(lblId);
            tabPageRead.Location = new Point(4, 24);
            tabPageRead.Name = "tabPageRead";
            tabPageRead.Size = new Size(433, 568);
            tabPageRead.TabIndex = 4;
            tabPageRead.Text = "קבלת לקוח";
            tabPageRead.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(207, 350);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "אישור";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnId
            // 
            btnId.Location = new Point(207, 191);
            btnId.Name = "btnId";
            btnId.Size = new Size(75, 23);
            btnId.TabIndex = 9;
            btnId.Text = "אישור";
            btnId.UseVisualStyleBackColor = true;
            btnId.Click += btnRead_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(145, 305);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(100, 23);
            textBoxFilter.TabIndex = 7;
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(125, 129);
            numericUpDownId.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(120, 23);
            numericUpDownId.TabIndex = 6;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(279, 308);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(64, 15);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "תנאי לסינון";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(279, 131);
            lblId.Name = "lblId";
            lblId.Size = new Size(64, 15);
            lblId.TabIndex = 5;
            lblId.Text = "מזהה לקוח";
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 699);
            Controls.Add(tabControl1);
            Name = "CustomerMenu";
            Text = "CustomerMenu";
            tabControl1.ResumeLayout(false);
            tabPageCreate.ResumeLayout(false);
            tabPageCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPhone).EndInit();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomeIdUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerPhoneUpdate).EndInit();
            tabPageDelete.ResumeLayout(false);
            tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelete).EndInit();
            tabPageRead.ResumeLayout(false);
            tabPageRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCreate;
        private Button btnCreate;
        private NumericUpDown numericUpDownCustomerId;
        private Label lblCustomerId;
        private NumericUpDown numericUpDownPhone;
        private Label lblPhone;
        private TextBox textBoxAddress;
        private Label lblAddress;
        private TextBox textBoxName;
        private Label lblName;
        private TabPage tabPageUpdate;
        private NumericUpDown numericUpDownCustomeIdUpdate;
        private Label label1;
        private Button btnUpdate;
        private NumericUpDown numericUpDownCustomerPhoneUpdate;
        private Label label4;
        private Label label2;
        private TextBox textBoxCustomerNameUpdate;
        private TextBox textBoxCustomeAddressUpdate;
        private Label label3;
        private TabPage tabPageDelete;
        private Button btnDelete;
        private NumericUpDown numericUpDownDelete;
        private Label lblDelete;
        private TabPage tabPageRead;
        private Button btnFilter;
        private Button btnId;
        private TextBox textBoxFilter;
        private NumericUpDown numericUpDownId;
        private Label lblFilter;
        private Label lblId;
    }
}