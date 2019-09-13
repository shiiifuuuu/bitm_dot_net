namespace MyWindowsFormsApp
{
    partial class ConditionUI
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
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Items.AddRange(new object[] {
            "pen",
            "pencil",
            "none"});
            this.itemComboBox.Location = new System.Drawing.Point(141, 88);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(193, 21);
            this.itemComboBox.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(375, 88);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // ConditionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.itemComboBox);
            this.Name = "ConditionUI";
            this.Text = "ConditionUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Button showButton;
    }
}