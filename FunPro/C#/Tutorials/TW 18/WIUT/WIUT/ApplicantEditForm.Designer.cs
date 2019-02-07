namespace WIUT
{
    partial class ApplicantEditForm
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
            this.tbxMaritalStatus = new System.Windows.Forms.TextBox();
            this.tbxPassportNo = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxMaritalStatus
            // 
            this.tbxMaritalStatus.Location = new System.Drawing.Point(84, 116);
            this.tbxMaritalStatus.Name = "tbxMaritalStatus";
            this.tbxMaritalStatus.Size = new System.Drawing.Size(100, 20);
            this.tbxMaritalStatus.TabIndex = 20;
            // 
            // tbxPassportNo
            // 
            this.tbxPassportNo.Location = new System.Drawing.Point(84, 90);
            this.tbxPassportNo.Name = "tbxPassportNo";
            this.tbxPassportNo.Size = new System.Drawing.Size(100, 20);
            this.tbxPassportNo.TabIndex = 19;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(84, 64);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxAddress.TabIndex = 18;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(84, 38);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 17;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(12, 171);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(40, 13);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "Course";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 148);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "DoB";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 123);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 13);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Marital status";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(84, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 12;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 97);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 13);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Passport No";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoB.Location = new System.Drawing.Point(84, 142);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(100, 20);
            this.dtpDoB.TabIndex = 21;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Address";
            // 
            // cbxCourse
            // 
            this.cbxCourse.DisplayMember = "Name";
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(84, 168);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(100, 21);
            this.cbxCourse.TabIndex = 22;
            this.cbxCourse.ValueMember = "Id";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Surname";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(109, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Name";
            // 
            // ApplicantEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(209, 249);
            this.Controls.Add(this.tbxMaritalStatus);
            this.Controls.Add(this.tbxPassportNo);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cbxCourse);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Label1);
            this.Name = "ApplicantEditForm";
            this.Text = "Applicant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbxMaritalStatus;
        internal System.Windows.Forms.TextBox tbxPassportNo;
        internal System.Windows.Forms.TextBox tbxAddress;
        internal System.Windows.Forms.TextBox tbxSurname;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tbxName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker dtpDoB;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbxCourse;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label Label1;
    }
}