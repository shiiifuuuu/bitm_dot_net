namespace Assignment6.UI
{
    partial class CustomerForm
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
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.addUpdateButton = new System.Windows.Forms.Button();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorDistrictCombo = new System.Windows.Forms.Label();
            this.errorAddressLabel = new System.Windows.Forms.Label();
            this.errorContactLabel = new System.Windows.Forms.Label();
            this.errorNameLabel = new System.Windows.Forms.Label();
            this.errorCodeLabel = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.deleteCustomerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorSearchLabel = new System.Windows.Forms.Label();
            this.confirmationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.showDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(12, 290);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(594, 173);
            this.showDataGridView.TabIndex = 18;
            this.showDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellDoubleClick);
            this.showDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.showDataGridView_RowPostPaint);
            // 
            // addUpdateButton
            // 
            this.addUpdateButton.Location = new System.Drawing.Point(107, 244);
            this.addUpdateButton.Name = "addUpdateButton";
            this.addUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.addUpdateButton.TabIndex = 0;
            this.addUpdateButton.Text = "Add";
            this.addUpdateButton.UseVisualStyleBackColor = true;
            this.addUpdateButton.Click += new System.EventHandler(this.addUpdateButton_Click);
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(61, 101);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactTextBox.TabIndex = 6;
            this.contactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactTextBox_KeyPress);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(61, 140);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 469);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(594, 23);
            this.showButton.TabIndex = 17;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorDistrictCombo);
            this.groupBox1.Controls.Add(this.errorAddressLabel);
            this.groupBox1.Controls.Add(this.errorContactLabel);
            this.groupBox1.Controls.Add(this.errorNameLabel);
            this.groupBox1.Controls.Add(this.errorCodeLabel);
            this.groupBox1.Controls.Add(this.districtComboBox);
            this.groupBox1.Controls.Add(this.addUpdateButton);
            this.groupBox1.Controls.Add(this.contactTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 273);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Customer";
            // 
            // errorDistrictCombo
            // 
            this.errorDistrictCombo.AutoSize = true;
            this.errorDistrictCombo.ForeColor = System.Drawing.Color.Red;
            this.errorDistrictCombo.Location = new System.Drawing.Point(11, 207);
            this.errorDistrictCombo.Name = "errorDistrictCombo";
            this.errorDistrictCombo.Size = new System.Drawing.Size(0, 13);
            this.errorDistrictCombo.TabIndex = 23;
            // 
            // errorAddressLabel
            // 
            this.errorAddressLabel.AutoSize = true;
            this.errorAddressLabel.ForeColor = System.Drawing.Color.Red;
            this.errorAddressLabel.Location = new System.Drawing.Point(11, 165);
            this.errorAddressLabel.Name = "errorAddressLabel";
            this.errorAddressLabel.Size = new System.Drawing.Size(0, 13);
            this.errorAddressLabel.TabIndex = 23;
            // 
            // errorContactLabel
            // 
            this.errorContactLabel.AutoSize = true;
            this.errorContactLabel.ForeColor = System.Drawing.Color.Red;
            this.errorContactLabel.Location = new System.Drawing.Point(11, 123);
            this.errorContactLabel.Name = "errorContactLabel";
            this.errorContactLabel.Size = new System.Drawing.Size(0, 13);
            this.errorContactLabel.TabIndex = 23;
            // 
            // errorNameLabel
            // 
            this.errorNameLabel.AutoSize = true;
            this.errorNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorNameLabel.Location = new System.Drawing.Point(11, 85);
            this.errorNameLabel.Name = "errorNameLabel";
            this.errorNameLabel.Size = new System.Drawing.Size(0, 13);
            this.errorNameLabel.TabIndex = 23;
            // 
            // errorCodeLabel
            // 
            this.errorCodeLabel.AutoSize = true;
            this.errorCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.errorCodeLabel.Location = new System.Drawing.Point(11, 43);
            this.errorCodeLabel.Name = "errorCodeLabel";
            this.errorCodeLabel.Size = new System.Drawing.Size(0, 13);
            this.errorCodeLabel.TabIndex = 23;
            // 
            // districtComboBox
            // 
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Items.AddRange(new object[] {
            "Barishal ",
            "Chittagong ",
            "Dhaka ",
            "Mymensingh ",
            "Khulna ",
            "Rajshahi",
            "Rangpur ",
            "Sylhet "});
            this.districtComboBox.Location = new System.Drawing.Point(61, 179);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(121, 21);
            this.districtComboBox.TabIndex = 7;
            this.districtComboBox.Text = "--Select--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(61, 20);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(121, 20);
            this.codeTextBox.TabIndex = 6;
            this.codeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "District";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(61, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerNameTextBox_KeyPress);
            // 
            // deleteCustomerTextBox
            // 
            this.deleteCustomerTextBox.Location = new System.Drawing.Point(14, 36);
            this.deleteCustomerTextBox.Name = "deleteCustomerTextBox";
            this.deleteCustomerTextBox.ReadOnly = true;
            this.deleteCustomerTextBox.Size = new System.Drawing.Size(222, 20);
            this.deleteCustomerTextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.deleteCustomerTextBox);
            this.groupBox2.Location = new System.Drawing.Point(290, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 96);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Customer";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(161, 68);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search customer:";
            // 
            // searchCustomerTextBox
            // 
            this.searchCustomerTextBox.Location = new System.Drawing.Point(104, 19);
            this.searchCustomerTextBox.Name = "searchCustomerTextBox";
            this.searchCustomerTextBox.Size = new System.Drawing.Size(132, 20);
            this.searchCustomerTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(161, 64);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.errorSearchLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.searchCustomerTextBox);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Location = new System.Drawing.Point(290, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 97);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Customer";
            // 
            // errorSearchLabel
            // 
            this.errorSearchLabel.AutoSize = true;
            this.errorSearchLabel.ForeColor = System.Drawing.Color.Red;
            this.errorSearchLabel.Location = new System.Drawing.Point(8, 42);
            this.errorSearchLabel.Name = "errorSearchLabel";
            this.errorSearchLabel.Size = new System.Drawing.Size(0, 13);
            this.errorSearchLabel.TabIndex = 23;
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmationLabel.Location = new System.Drawing.Point(301, 241);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(0, 13);
            this.confirmationLabel.TabIndex = 23;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 502);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button addUpdateButton;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox deleteCustomerTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchCustomerTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errorAddressLabel;
        private System.Windows.Forms.Label errorContactLabel;
        private System.Windows.Forms.Label errorNameLabel;
        private System.Windows.Forms.Label errorCodeLabel;
        private System.Windows.Forms.Label errorDistrictCombo;
        private System.Windows.Forms.Label errorSearchLabel;
        private System.Windows.Forms.Label confirmationLabel;
    }
}