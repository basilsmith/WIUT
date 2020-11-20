namespace DistanceConverter
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
            this.tbxMeters = new System.Windows.Forms.TextBox();
            this.btnInches = new System.Windows.Forms.Button();
            this.btnFeet = new System.Windows.Forms.Button();
            this.btnMiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxMeters
            // 
            this.tbxMeters.Location = new System.Drawing.Point(11, 11);
            this.tbxMeters.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMeters.Name = "tbxMeters";
            this.tbxMeters.Size = new System.Drawing.Size(141, 20);
            this.tbxMeters.TabIndex = 5;
            // 
            // btnInches
            // 
            this.btnInches.Location = new System.Drawing.Point(11, 81);
            this.btnInches.Margin = new System.Windows.Forms.Padding(2);
            this.btnInches.Name = "btnInches";
            this.btnInches.Size = new System.Drawing.Size(140, 19);
            this.btnInches.TabIndex = 2;
            this.btnInches.Text = "Inches";
            this.btnInches.UseVisualStyleBackColor = true;
            this.btnInches.Click += new System.EventHandler(this.btnInches_Click);
            // 
            // btnFeet
            // 
            this.btnFeet.Location = new System.Drawing.Point(11, 57);
            this.btnFeet.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeet.Name = "btnFeet";
            this.btnFeet.Size = new System.Drawing.Size(140, 19);
            this.btnFeet.TabIndex = 3;
            this.btnFeet.Text = "Feet";
            this.btnFeet.UseVisualStyleBackColor = true;
            this.btnFeet.Click += new System.EventHandler(this.btnFeet_Click);
            // 
            // btnMiles
            // 
            this.btnMiles.Location = new System.Drawing.Point(11, 33);
            this.btnMiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnMiles.Name = "btnMiles";
            this.btnMiles.Size = new System.Drawing.Size(140, 19);
            this.btnMiles.TabIndex = 4;
            this.btnMiles.Text = "Miles";
            this.btnMiles.UseVisualStyleBackColor = true;
            this.btnMiles.Click += new System.EventHandler(this.btnMiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 109);
            this.Controls.Add(this.tbxMeters);
            this.Controls.Add(this.btnInches);
            this.Controls.Add(this.btnFeet);
            this.Controls.Add(this.btnMiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbxMeters;
        internal System.Windows.Forms.Button btnInches;
        internal System.Windows.Forms.Button btnFeet;
        internal System.Windows.Forms.Button btnMiles;
    }
}

