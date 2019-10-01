namespace Assignment6
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.updateItemIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchOrderTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteOrderTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.orderItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.addItemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateItemComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateItemComboBox);
            this.groupBox4.Controls.Add(this.updateItemQuantityTextBox);
            this.groupBox4.Controls.Add(this.updateItemIdTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.updateButton);
            this.groupBox4.Location = new System.Drawing.Point(277, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 158);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Order";
            // 
            // updateItemQuantityTextBox
            // 
            this.updateItemQuantityTextBox.Location = new System.Drawing.Point(103, 53);
            this.updateItemQuantityTextBox.Name = "updateItemQuantityTextBox";
            this.updateItemQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateItemQuantityTextBox.TabIndex = 8;
            this.updateItemQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateItemQuantityTextBox_KeyPress);
            // 
            // updateItemIdTextBox
            // 
            this.updateItemIdTextBox.Location = new System.Drawing.Point(103, 79);
            this.updateItemIdTextBox.Name = "updateItemIdTextBox";
            this.updateItemIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateItemIdTextBox.TabIndex = 6;
            this.updateItemIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateItemIdTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ID";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(128, 117);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.searchOrderTextBox);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 102);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search order:";
            // 
            // searchOrderTextBox
            // 
            this.searchOrderTextBox.Location = new System.Drawing.Point(89, 30);
            this.searchOrderTextBox.Name = "searchOrderTextBox";
            this.searchOrderTextBox.Size = new System.Drawing.Size(148, 20);
            this.searchOrderTextBox.TabIndex = 6;
            this.searchOrderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchOrderTextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(162, 56);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.deleteOrderTextBox);
            this.groupBox2.Location = new System.Drawing.Point(277, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 102);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input ID to delete order:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(162, 56);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteOrderTextBox
            // 
            this.deleteOrderTextBox.Location = new System.Drawing.Point(137, 30);
            this.deleteOrderTextBox.Name = "deleteOrderTextBox";
            this.deleteOrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.deleteOrderTextBox.TabIndex = 6;
            this.deleteOrderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deleteOrderTextBox_KeyPress);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 556);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(524, 23);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addItemComboBox);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.orderItemQuantityTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 158);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Order";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(116, 117);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // orderItemQuantityTextBox
            // 
            this.orderItemQuantityTextBox.Location = new System.Drawing.Point(91, 74);
            this.orderItemQuantityTextBox.Name = "orderItemQuantityTextBox";
            this.orderItemQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderItemQuantityTextBox.TabIndex = 6;
            this.orderItemQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderItemQuantityTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(12, 287);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(524, 263);
            this.showDataGridView.TabIndex = 12;
            // 
            // addItemComboBox
            // 
            this.addItemComboBox.DataSource = this.itemBindingSource;
            this.addItemComboBox.DisplayMember = "Name";
            this.addItemComboBox.FormattingEnabled = true;
            this.addItemComboBox.Location = new System.Drawing.Point(91, 36);
            this.addItemComboBox.Name = "addItemComboBox";
            this.addItemComboBox.Size = new System.Drawing.Size(121, 21);
            this.addItemComboBox.TabIndex = 7;
            this.addItemComboBox.ValueMember = "ID";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Assignment6.MODEL.Item);
            // 
            // updateItemComboBox
            // 
            this.updateItemComboBox.DataSource = this.itemBindingSource;
            this.updateItemComboBox.DisplayMember = "Name";
            this.updateItemComboBox.FormattingEnabled = true;
            this.updateItemComboBox.Location = new System.Drawing.Point(103, 26);
            this.updateItemComboBox.Name = "updateItemComboBox";
            this.updateItemComboBox.Size = new System.Drawing.Size(121, 21);
            this.updateItemComboBox.TabIndex = 8;
            this.updateItemComboBox.ValueMember = "ID";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showDataGridView);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox updateItemIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchOrderTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteOrderTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox orderItemQuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.TextBox updateItemQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox addItemComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.ComboBox updateItemComboBox;
    }
}