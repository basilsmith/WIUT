namespace TimeRounding
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudRoundingInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudInHours = new System.Windows.Forms.NumericUpDown();
            this.nudInMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudOutHours = new System.Windows.Forms.NumericUpDown();
            this.nudOutMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundingInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rounding";
            // 
            // nudRoundingInterval
            // 
            this.nudRoundingInterval.Location = new System.Drawing.Point(77, 7);
            this.nudRoundingInterval.Name = "nudRoundingInterval";
            this.nudRoundingInterval.Size = new System.Drawing.Size(120, 20);
            this.nudRoundingInterval.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IN";
            // 
            // nudInHours
            // 
            this.nudInHours.Location = new System.Drawing.Point(77, 33);
            this.nudInHours.Name = "nudInHours";
            this.nudInHours.Size = new System.Drawing.Size(51, 20);
            this.nudInHours.TabIndex = 1;
            // 
            // nudInMinutes
            // 
            this.nudInMinutes.Location = new System.Drawing.Point(146, 33);
            this.nudInMinutes.Name = "nudInMinutes";
            this.nudInMinutes.Size = new System.Drawing.Size(51, 20);
            this.nudInMinutes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "OUT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = ":";
            // 
            // nudOutHours
            // 
            this.nudOutHours.Location = new System.Drawing.Point(77, 59);
            this.nudOutHours.Name = "nudOutHours";
            this.nudOutHours.Size = new System.Drawing.Size(51, 20);
            this.nudOutHours.TabIndex = 3;
            // 
            // nudOutMinutes
            // 
            this.nudOutMinutes.Location = new System.Drawing.Point(146, 59);
            this.nudOutMinutes.Name = "nudOutMinutes";
            this.nudOutMinutes.Size = new System.Drawing.Size(51, 20);
            this.nudOutMinutes.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(122, 85);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 126);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudOutMinutes);
            this.Controls.Add(this.nudInMinutes);
            this.Controls.Add(this.nudOutHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudInHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRoundingInterval);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundingInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRoundingInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudInHours;
        private System.Windows.Forms.NumericUpDown nudInMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudOutHours;
        private System.Windows.Forms.NumericUpDown nudOutMinutes;
        private System.Windows.Forms.Button btnCalculate;
    }
}

