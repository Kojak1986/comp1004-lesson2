namespace comp1004_lesson2
{
    partial class Invoicetotalform
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
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.DiscountPercentLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.DiscountPercentTextBox = new System.Windows.Forms.TextBox();
            this.DiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(15, 9);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.SubTotalLabel.TabIndex = 0;
            this.SubTotalLabel.Text = "Sub Total:";
            // 
            // DiscountPercentLabel
            // 
            this.DiscountPercentLabel.AutoSize = true;
            this.DiscountPercentLabel.Location = new System.Drawing.Point(15, 38);
            this.DiscountPercentLabel.Name = "DiscountPercentLabel";
            this.DiscountPercentLabel.Size = new System.Drawing.Size(92, 13);
            this.DiscountPercentLabel.TabIndex = 1;
            this.DiscountPercentLabel.Text = "Discount Percent:";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Location = new System.Drawing.Point(15, 67);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(91, 13);
            this.DiscountAmountLabel.TabIndex = 2;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            this.DiscountAmountLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(15, 96);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total:";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(104, 6);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 4;
            // 
            // DiscountPercentTextBox
            // 
            this.DiscountPercentTextBox.Location = new System.Drawing.Point(104, 35);
            this.DiscountPercentTextBox.Name = "DiscountPercentTextBox";
            this.DiscountPercentTextBox.ReadOnly = true;
            this.DiscountPercentTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountPercentTextBox.TabIndex = 5;
            this.DiscountPercentTextBox.TextChanged += new System.EventHandler(this.discountPercentTextBox_TextChanged);
            // 
            // DiscountAmountTextBox
            // 
            this.DiscountAmountTextBox.Location = new System.Drawing.Point(104, 64);
            this.DiscountAmountTextBox.Name = "DiscountAmountTextBox";
            this.DiscountAmountTextBox.ReadOnly = true;
            this.DiscountAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountAmountTextBox.TabIndex = 6;
            this.DiscountAmountTextBox.TextChanged += new System.EventHandler(this.discountAmountTextBox_TextChanged);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(104, 93);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 7;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.totalTextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(48, 137);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(129, 137);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Invoicetotalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 173);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.DiscountAmountTextBox);
            this.Controls.Add(this.DiscountPercentTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.DiscountPercentLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Name = "Invoicetotalform";
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.Invoicetotalform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label DiscountPercentLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox DiscountPercentTextBox;
        private System.Windows.Forms.TextBox DiscountAmountTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

