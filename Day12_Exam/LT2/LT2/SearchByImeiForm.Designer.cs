namespace LT2
{
    partial class SearchByImeiForm
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
            this.searchImeiTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imeiLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMEI";
            // 
            // searchImeiTextBox
            // 
            this.searchImeiTextBox.Location = new System.Drawing.Point(73, 40);
            this.searchImeiTextBox.Name = "searchImeiTextBox";
            this.searchImeiTextBox.Size = new System.Drawing.Size(221, 20);
            this.searchImeiTextBox.TabIndex = 1;
            this.searchImeiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchImeiTextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(300, 38);
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
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IMEI";
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Location = new System.Drawing.Point(96, 27);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(0, 13);
            this.modelNameLabel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price";
            // 
            // imeiLabel
            // 
            this.imeiLabel.AutoSize = true;
            this.imeiLabel.Location = new System.Drawing.Point(96, 52);
            this.imeiLabel.Name = "imeiLabel";
            this.imeiLabel.Size = new System.Drawing.Size(0, 13);
            this.imeiLabel.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(96, 78);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 13);
            this.priceLabel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.modelNameLabel);
            this.groupBox1.Controls.Add(this.imeiLabel);
            this.groupBox1.Location = new System.Drawing.Point(73, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // SearchByImeiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 239);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchImeiTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchByImeiForm";
            this.Text = "Search By Imei";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchImeiTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label imeiLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}