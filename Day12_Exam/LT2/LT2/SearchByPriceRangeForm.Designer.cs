namespace LT2
{
    partial class SearchByPriceRangeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.price1TextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.price2TextBox = new System.Windows.Forms.TextBox();
            this.showMobileGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showMobileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price Between";
            // 
            // price1TextBox
            // 
            this.price1TextBox.Location = new System.Drawing.Point(119, 47);
            this.price1TextBox.Name = "price1TextBox";
            this.price1TextBox.Size = new System.Drawing.Size(100, 20);
            this.price1TextBox.TabIndex = 1;
            this.price1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price1TextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(362, 45);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "and";
            // 
            // price2TextBox
            // 
            this.price2TextBox.Location = new System.Drawing.Point(256, 47);
            this.price2TextBox.Name = "price2TextBox";
            this.price2TextBox.Size = new System.Drawing.Size(100, 20);
            this.price2TextBox.TabIndex = 1;
            this.price2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price2TextBox_KeyPress);
            // 
            // showMobileGridView
            // 
            this.showMobileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showMobileGridView.Location = new System.Drawing.Point(40, 93);
            this.showMobileGridView.Name = "showMobileGridView";
            this.showMobileGridView.Size = new System.Drawing.Size(397, 240);
            this.showMobileGridView.TabIndex = 3;
            this.showMobileGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.showMobileGridView_RowPostPaint);
            // 
            // SearchByPriceRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 373);
            this.Controls.Add(this.showMobileGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.price2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchByPriceRangeForm";
            this.Text = "Search By Price Range";
            this.Load += new System.EventHandler(this.SearchByPriceRangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showMobileGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price1TextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price2TextBox;
        private System.Windows.Forms.DataGridView showMobileGridView;
    }
}