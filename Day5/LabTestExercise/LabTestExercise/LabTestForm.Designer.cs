namespace LabTestExercise
{
    partial class LabTestForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.gpaPointTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.avgPointTextBox = new System.Windows.Forms.TextBox();
            this.minNameTextBox = new System.Windows.Forms.TextBox();
            this.minPointTextBox = new System.Windows.Forms.TextBox();
            this.maxNameTextBox = new System.Windows.Forms.TextBox();
            this.maxPointTextBox = new System.Windows.Forms.TextBox();
            this.totalPointTextBox = new System.Windows.Forms.TextBox();
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.mobileRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gpaPointTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.mobileTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.mobileRadioButton);
            this.groupBox2.Controls.Add(this.nameRadioButton);
            this.groupBox2.Controls.Add(this.idRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(489, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalPointTextBox);
            this.groupBox3.Controls.Add(this.avgPointTextBox);
            this.groupBox3.Controls.Add(this.minNameTextBox);
            this.groupBox3.Controls.Add(this.minPointTextBox);
            this.groupBox3.Controls.Add(this.maxNameTextBox);
            this.groupBox3.Controls.Add(this.maxPointTextBox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.resultRichTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 217);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "GPA Point";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(100, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(273, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(273, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(100, 80);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(273, 20);
            this.mobileTextBox.TabIndex = 8;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(100, 106);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(273, 20);
            this.ageTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(100, 132);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(273, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // gpaPointTextBox
            // 
            this.gpaPointTextBox.Location = new System.Drawing.Point(100, 158);
            this.gpaPointTextBox.Name = "gpaPointTextBox";
            this.gpaPointTextBox.Size = new System.Drawing.Size(273, 20);
            this.gpaPointTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "* (4 Char)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "* (Max 30 Char)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "* (11 Char)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "(0-4)";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(277, 197);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(277, 237);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(96, 23);
            this.showButton.TabIndex = 18;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(339, 192);
            this.resultRichTextBox.TabIndex = 0;
            this.resultRichTextBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "GPA Point:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(383, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Max";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Min";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(375, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(384, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Avg";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(379, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Total";
            // 
            // avgPointTextBox
            // 
            this.avgPointTextBox.Location = new System.Drawing.Point(416, 159);
            this.avgPointTextBox.Name = "avgPointTextBox";
            this.avgPointTextBox.Size = new System.Drawing.Size(197, 20);
            this.avgPointTextBox.TabIndex = 19;
            // 
            // minNameTextBox
            // 
            this.minNameTextBox.Location = new System.Drawing.Point(416, 133);
            this.minNameTextBox.Name = "minNameTextBox";
            this.minNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.minNameTextBox.TabIndex = 20;
            // 
            // minPointTextBox
            // 
            this.minPointTextBox.Location = new System.Drawing.Point(416, 107);
            this.minPointTextBox.Name = "minPointTextBox";
            this.minPointTextBox.Size = new System.Drawing.Size(197, 20);
            this.minPointTextBox.TabIndex = 21;
            // 
            // maxNameTextBox
            // 
            this.maxNameTextBox.Location = new System.Drawing.Point(416, 81);
            this.maxNameTextBox.Name = "maxNameTextBox";
            this.maxNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.maxNameTextBox.TabIndex = 22;
            // 
            // maxPointTextBox
            // 
            this.maxPointTextBox.Location = new System.Drawing.Point(416, 55);
            this.maxPointTextBox.Name = "maxPointTextBox";
            this.maxPointTextBox.Size = new System.Drawing.Size(197, 20);
            this.maxPointTextBox.TabIndex = 23;
            // 
            // totalPointTextBox
            // 
            this.totalPointTextBox.Location = new System.Drawing.Point(416, 185);
            this.totalPointTextBox.Name = "totalPointTextBox";
            this.totalPointTextBox.Size = new System.Drawing.Size(197, 20);
            this.totalPointTextBox.TabIndex = 24;
            // 
            // idRadioButton
            // 
            this.idRadioButton.AutoSize = true;
            this.idRadioButton.Location = new System.Drawing.Point(7, 20);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(36, 17);
            this.idRadioButton.TabIndex = 0;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "ID";
            this.idRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(7, 43);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 1;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // mobileRadioButton
            // 
            this.mobileRadioButton.AutoSize = true;
            this.mobileRadioButton.Location = new System.Drawing.Point(7, 66);
            this.mobileRadioButton.Name = "mobileRadioButton";
            this.mobileRadioButton.Size = new System.Drawing.Size(56, 17);
            this.mobileRadioButton.TabIndex = 2;
            this.mobileRadioButton.TabStop = true;
            this.mobileRadioButton.Text = "Mobile";
            this.mobileRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(7, 101);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // LabTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LabTestForm";
            this.Text = "Lab Test Exercise";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gpaPointTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.TextBox totalPointTextBox;
        private System.Windows.Forms.TextBox avgPointTextBox;
        private System.Windows.Forms.TextBox minNameTextBox;
        private System.Windows.Forms.TextBox minPointTextBox;
        private System.Windows.Forms.TextBox maxNameTextBox;
        private System.Windows.Forms.TextBox maxPointTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton mobileRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton idRadioButton;
    }
}

