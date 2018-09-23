namespace TheSum
{
    partial class Form1
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
            this.btnOddNumbers = new System.Windows.Forms.Button();
            this.btnEvenNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOddNumbers
            // 
            this.btnOddNumbers.Location = new System.Drawing.Point(12, 12);
            this.btnOddNumbers.Name = "btnOddNumbers";
            this.btnOddNumbers.Size = new System.Drawing.Size(143, 23);
            this.btnOddNumbers.TabIndex = 0;
            this.btnOddNumbers.Text = "Odd numbers";
            this.btnOddNumbers.UseVisualStyleBackColor = true;
            this.btnOddNumbers.Click += new System.EventHandler(this.btnOddNumbers_Click);
            // 
            // btnEvenNumbers
            // 
            this.btnEvenNumbers.Location = new System.Drawing.Point(12, 41);
            this.btnEvenNumbers.Name = "btnEvenNumbers";
            this.btnEvenNumbers.Size = new System.Drawing.Size(143, 23);
            this.btnEvenNumbers.TabIndex = 1;
            this.btnEvenNumbers.Text = "Even numbers";
            this.btnEvenNumbers.UseVisualStyleBackColor = true;
            this.btnEvenNumbers.Click += new System.EventHandler(this.btnEvenNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 80);
            this.Controls.Add(this.btnEvenNumbers);
            this.Controls.Add(this.btnOddNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOddNumbers;
        private System.Windows.Forms.Button btnEvenNumbers;
    }
}

