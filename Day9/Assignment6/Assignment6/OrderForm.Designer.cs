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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.updateItemIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateItemNameTextBox = new System.Windows.Forms.TextBox();
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
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderItemNameTextBox = new System.Windows.Forms.TextBox();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateItemPriceTextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.updateItemQuantityTextBox);
            this.groupBox4.Controls.Add(this.updateItemIdTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.updateItemNameTextBox);
            this.groupBox4.Controls.Add(this.updateButton);
            this.groupBox4.Location = new System.Drawing.Point(277, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 158);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Order";
            // 
            // updateItemPriceTextBox
            // 
            this.updateItemPriceTextBox.Location = new System.Drawing.Point(103, 52);
            this.updateItemPriceTextBox.Name = "updateItemPriceTextBox";
            this.updateItemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateItemPriceTextBox.TabIndex = 10;
            this.updateItemPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateItemPriceTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Item Price";
            // 
            // updateItemQuantityTextBox
            // 
            this.updateItemQuantityTextBox.Location = new System.Drawing.Point(103, 78);
            this.updateItemQuantityTextBox.Name = "updateItemQuantityTextBox";
            this.updateItemQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateItemQuantityTextBox.TabIndex = 8;
            this.updateItemQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateItemQuantityTextBox_KeyPress);
            // 
            // updateItemIdTextBox
            // 
            this.updateItemIdTextBox.Location = new System.Drawing.Point(103, 104);
            this.updateItemIdTextBox.Name = "updateItemIdTextBox";
            this.updateItemIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateItemIdTextBox.TabIndex = 6;
            this.updateItemIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateItemIdTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 81);
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
            this.label8.Location = new System.Drawing.Point(79, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ID";
            // 
            // updateItemNameTextBox
            // 
            this.updateItemNameTextBox.Location = new System.Drawing.Point(103, 26);
            this.updateItemNameTextBox.Name = "updateItemNameTextBox";
            this.updateItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateItemNameTextBox.TabIndex = 6;
            this.updateItemNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateItemNameTextBox_KeyPress);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(128, 130);
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
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.itemPriceTextBox);
            this.groupBox1.Controls.Add(this.orderItemQuantityTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.orderItemNameTextBox);
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
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(91, 65);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemPriceTextBox.TabIndex = 6;
            this.itemPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemPriceTextBox_KeyPress);
            // 
            // orderItemQuantityTextBox
            // 
            this.orderItemQuantityTextBox.Location = new System.Drawing.Point(91, 91);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Item Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // orderItemNameTextBox
            // 
            this.orderItemNameTextBox.Location = new System.Drawing.Point(91, 36);
            this.orderItemNameTextBox.Name = "orderItemNameTextBox";
            this.orderItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderItemNameTextBox.TabIndex = 6;
            this.orderItemNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderItemNameTextBox_KeyPress);
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(12, 287);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(524, 263);
            this.showDataGridView.TabIndex = 12;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox updateItemIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox updateItemNameTextBox;
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
        private System.Windows.Forms.TextBox orderItemNameTextBox;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.TextBox updateItemQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateItemPriceTextBox;
        private System.Windows.Forms.Label label9;
    }
}