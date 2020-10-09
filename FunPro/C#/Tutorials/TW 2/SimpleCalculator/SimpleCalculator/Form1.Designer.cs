namespace SimpleCalculator
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
            this.btnSum = new System.Windows.Forms.Button();
            this.tbxNumber1 = new System.Windows.Forms.TextBox();
            this.tbxNumber2 = new System.Windows.Forms.TextBox();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(12, 38);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(64, 23);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // tbxNumber1
            // 
            this.tbxNumber1.Location = new System.Drawing.Point(12, 12);
            this.tbxNumber1.Name = "tbxNumber1";
            this.tbxNumber1.Size = new System.Drawing.Size(91, 20);
            this.tbxNumber1.TabIndex = 0;
            // 
            // tbxNumber2
            // 
            this.tbxNumber2.Location = new System.Drawing.Point(128, 12);
            this.tbxNumber2.Name = "tbxNumber2";
            this.tbxNumber2.Size = new System.Drawing.Size(87, 20);
            this.tbxNumber2.TabIndex = 1;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(152, 67);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(64, 23);
            this.btnExp.TabIndex = 7;
            this.btnExp.Text = "^";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(152, 38);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(64, 23);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(82, 38);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(64, 23);
            this.btnSubtract.TabIndex = 3;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnReminder
            // 
            this.btnReminder.Location = new System.Drawing.Point(82, 67);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(64, 23);
            this.btnReminder.TabIndex = 6;
            this.btnReminder.Text = "%";
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(12, 67);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(64, 23);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 105);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 129);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbxNumber2);
            this.Controls.Add(this.tbxNumber1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox tbxNumber1;
        private System.Windows.Forms.TextBox tbxNumber2;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label lblResult;
    }
}

