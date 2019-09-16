namespace MyWindowsFormsApp
{
    partial class ExerciseForm
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
            this.showExercise1Button = new System.Windows.Forms.Button();
            this.showExercise2Button = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.sizeButton = new System.Windows.Forms.Button();
            this.addElementsButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showExercise1Button
            // 
            this.showExercise1Button.Location = new System.Drawing.Point(316, 76);
            this.showExercise1Button.Name = "showExercise1Button";
            this.showExercise1Button.Size = new System.Drawing.Size(145, 23);
            this.showExercise1Button.TabIndex = 2;
            this.showExercise1Button.Text = "Show Exercise1";
            this.showExercise1Button.UseVisualStyleBackColor = true;
            this.showExercise1Button.Click += new System.EventHandler(this.showExercise1Button_Click);
            // 
            // showExercise2Button
            // 
            this.showExercise2Button.Location = new System.Drawing.Point(316, 105);
            this.showExercise2Button.Name = "showExercise2Button";
            this.showExercise2Button.Size = new System.Drawing.Size(145, 23);
            this.showExercise2Button.TabIndex = 3;
            this.showExercise2Button.Text = "Show Exercise2";
            this.showExercise2Button.UseVisualStyleBackColor = true;
            this.showExercise2Button.Click += new System.EventHandler(this.showExercise2Button_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(430, 134);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(145, 20);
            this.inputTextBox.TabIndex = 4;
            // 
            // sizeButton
            // 
            this.sizeButton.Location = new System.Drawing.Point(349, 134);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(75, 23);
            this.sizeButton.TabIndex = 5;
            this.sizeButton.Text = "Add Size";
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
            // 
            // addElementsButton
            // 
            this.addElementsButton.Location = new System.Drawing.Point(488, 160);
            this.addElementsButton.Name = "addElementsButton";
            this.addElementsButton.Size = new System.Drawing.Size(87, 23);
            this.addElementsButton.TabIndex = 6;
            this.addElementsButton.Text = "Add Elements";
            this.addElementsButton.UseVisualStyleBackColor = true;
            this.addElementsButton.Click += new System.EventHandler(this.addElementsButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(500, 189);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(75, 23);
            this.resultButton.TabIndex = 7;
            this.resultButton.Text = "Result";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.addElementsButton);
            this.Controls.Add(this.sizeButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.showExercise2Button);
            this.Controls.Add(this.showExercise1Button);
            this.Name = "ExerciseForm";
            this.Text = "Exercise1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showExercise1Button;
        private System.Windows.Forms.Button showExercise2Button;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button sizeButton;
        private System.Windows.Forms.Button addElementsButton;
        private System.Windows.Forms.Button resultButton;
    }
}