namespace CruelGames
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
            this.btnStart = new System.Windows.Forms.Button();
            this.rbnLess21 = new System.Windows.Forms.RadioButton();
            this.rbn21to35 = new System.Windows.Forms.RadioButton();
            this.rbnMore35 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbnLess21
            // 
            this.rbnLess21.AutoSize = true;
            this.rbnLess21.Location = new System.Drawing.Point(12, 12);
            this.rbnLess21.Name = "rbnLess21";
            this.rbnLess21.Size = new System.Drawing.Size(46, 17);
            this.rbnLess21.TabIndex = 1;
            this.rbnLess21.TabStop = true;
            this.rbnLess21.Text = "< 21";
            this.rbnLess21.UseVisualStyleBackColor = true;
            // 
            // rbn21to35
            // 
            this.rbn21to35.AutoSize = true;
            this.rbn21to35.Location = new System.Drawing.Point(12, 35);
            this.rbn21to35.Name = "rbn21to35";
            this.rbn21to35.Size = new System.Drawing.Size(58, 17);
            this.rbn21to35.TabIndex = 1;
            this.rbn21to35.TabStop = true;
            this.rbn21to35.Text = "21 - 35";
            this.rbn21to35.UseVisualStyleBackColor = true;
            // 
            // rbnMore35
            // 
            this.rbnMore35.AutoSize = true;
            this.rbnMore35.Location = new System.Drawing.Point(12, 58);
            this.rbnMore35.Name = "rbnMore35";
            this.rbnMore35.Size = new System.Drawing.Size(46, 17);
            this.rbnMore35.TabIndex = 1;
            this.rbnMore35.TabStop = true;
            this.rbnMore35.Text = "> 35";
            this.rbnMore35.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 143);
            this.Controls.Add(this.rbnMore35);
            this.Controls.Add(this.rbn21to35);
            this.Controls.Add(this.rbnLess21);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbnLess21;
        private System.Windows.Forms.RadioButton rbn21to35;
        private System.Windows.Forms.RadioButton rbnMore35;
    }
}

