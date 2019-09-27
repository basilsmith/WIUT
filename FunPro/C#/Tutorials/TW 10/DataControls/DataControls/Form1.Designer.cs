namespace DataControls
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.Label Label6;
            System.Windows.Forms.Label Label7;
            System.Windows.Forms.Label FirstNameLabel;
            System.Windows.Forms.Label LastNameLabel;
            System.Windows.Forms.Label DobLabel;
            System.Windows.Forms.Label PhoneLabel;
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label CountryIdLabel;
            this.dbDataSet = new DataControls.dbDataSet();
            this.tbTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTeacherTableAdapter = new DataControls.dbDataSetTableAdapters.tbTeacherTableAdapter();
            this.tableAdapterManager = new DataControls.dbDataSetTableAdapters.TableAdapterManager();
            this.tbTeacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbTeacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxNewCountry = new System.Windows.Forms.ComboBox();
            this.nudNewGrade = new System.Windows.Forms.NumericUpDown();
            this.tbxNewFirstName = new System.Windows.Forms.TextBox();
            this.tbxNewLastName = new System.Windows.Forms.TextBox();
            this.dtpNewDoB = new System.Windows.Forms.DateTimePicker();
            this.tbxNewPhone = new System.Windows.Forms.TextBox();
            this.chbNewIsActive = new System.Windows.Forms.CheckBox();
            this.CountryIdComboBox = new System.Windows.Forms.ComboBox();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbTeachers = new System.Windows.Forms.ListBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.DobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.tbCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCountryTableAdapter = new DataControls.dbDataSetTableAdapters.tbCountryTableAdapter();
            this.tbCountryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            Label7 = new System.Windows.Forms.Label();
            FirstNameLabel = new System.Windows.Forms.Label();
            LastNameLabel = new System.Windows.Forms.Label();
            DobLabel = new System.Windows.Forms.Label();
            PhoneLabel = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            CountryIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingNavigator)).BeginInit();
            this.tbTeacherBindingNavigator.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbTeacherBindingSource
            // 
            this.tbTeacherBindingSource.DataMember = "tbTeacher";
            this.tbTeacherBindingSource.DataSource = this.dbDataSet;
            // 
            // tbTeacherTableAdapter
            // 
            this.tbTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbCountryTableAdapter = this.tbCountryTableAdapter;
            this.tableAdapterManager.tbTeacherTableAdapter = this.tbTeacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataControls.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbTeacherBindingNavigator
            // 
            this.tbTeacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbTeacherBindingNavigator.BindingSource = this.tbTeacherBindingSource;
            this.tbTeacherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbTeacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbTeacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbTeacherBindingNavigatorSaveItem});
            this.tbTeacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbTeacherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbTeacherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbTeacherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbTeacherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbTeacherBindingNavigator.Name = "tbTeacherBindingNavigator";
            this.tbTeacherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbTeacherBindingNavigator.Size = new System.Drawing.Size(436, 25);
            this.tbTeacherBindingNavigator.TabIndex = 0;
            this.tbTeacherBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tbTeacherBindingNavigatorSaveItem
            // 
            this.tbTeacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbTeacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbTeacherBindingNavigatorSaveItem.Image")));
            this.tbTeacherBindingNavigatorSaveItem.Name = "tbTeacherBindingNavigatorSaveItem";
            this.tbTeacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tbTeacherBindingNavigatorSaveItem.Text = "Save Data";
            this.tbTeacherBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbTeacherBindingNavigatorSaveItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(344, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAdd);
            this.GroupBox1.Controls.Add(this.cbxNewCountry);
            this.GroupBox1.Controls.Add(this.nudNewGrade);
            this.GroupBox1.Controls.Add(Label2);
            this.GroupBox1.Controls.Add(this.tbxNewFirstName);
            this.GroupBox1.Controls.Add(Label3);
            this.GroupBox1.Controls.Add(this.tbxNewLastName);
            this.GroupBox1.Controls.Add(Label4);
            this.GroupBox1.Controls.Add(this.dtpNewDoB);
            this.GroupBox1.Controls.Add(Label5);
            this.GroupBox1.Controls.Add(this.tbxNewPhone);
            this.GroupBox1.Controls.Add(Label6);
            this.GroupBox1.Controls.Add(this.chbNewIsActive);
            this.GroupBox1.Controls.Add(Label7);
            this.GroupBox1.Location = new System.Drawing.Point(12, 246);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(281, 241);
            this.GroupBox1.TabIndex = 57;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxNewCountry
            // 
            this.cbxNewCountry.DataSource = this.tbCountryBindingSource1;
            this.cbxNewCountry.DisplayMember = "Name";
            this.cbxNewCountry.FormattingEnabled = true;
            this.cbxNewCountry.Location = new System.Drawing.Point(70, 173);
            this.cbxNewCountry.Name = "cbxNewCountry";
            this.cbxNewCountry.Size = new System.Drawing.Size(200, 21);
            this.cbxNewCountry.TabIndex = 35;
            this.cbxNewCountry.ValueMember = "Id";
            // 
            // nudNewGrade
            // 
            this.nudNewGrade.Location = new System.Drawing.Point(70, 117);
            this.nudNewGrade.Name = "nudNewGrade";
            this.nudNewGrade.Size = new System.Drawing.Size(200, 20);
            this.nudNewGrade.TabIndex = 34;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new System.Drawing.Point(6, 16);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(55, 13);
            Label2.TabIndex = 23;
            Label2.Text = "First name";
            // 
            // tbxNewFirstName
            // 
            this.tbxNewFirstName.Location = new System.Drawing.Point(70, 13);
            this.tbxNewFirstName.Name = "tbxNewFirstName";
            this.tbxNewFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbxNewFirstName.TabIndex = 24;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new System.Drawing.Point(6, 42);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(56, 13);
            Label3.TabIndex = 25;
            Label3.Text = "Last name";
            // 
            // tbxNewLastName
            // 
            this.tbxNewLastName.Location = new System.Drawing.Point(70, 39);
            this.tbxNewLastName.Name = "tbxNewLastName";
            this.tbxNewLastName.Size = new System.Drawing.Size(200, 20);
            this.tbxNewLastName.TabIndex = 26;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new System.Drawing.Point(6, 69);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(28, 13);
            Label4.TabIndex = 27;
            Label4.Text = "DoB";
            // 
            // dtpNewDoB
            // 
            this.dtpNewDoB.CustomFormat = "dd/MM/yyyy";
            this.dtpNewDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDoB.Location = new System.Drawing.Point(70, 65);
            this.dtpNewDoB.Name = "dtpNewDoB";
            this.dtpNewDoB.Size = new System.Drawing.Size(200, 20);
            this.dtpNewDoB.TabIndex = 28;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new System.Drawing.Point(6, 94);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(38, 13);
            Label5.TabIndex = 29;
            Label5.Text = "Phone";
            // 
            // tbxNewPhone
            // 
            this.tbxNewPhone.Location = new System.Drawing.Point(70, 91);
            this.tbxNewPhone.Name = "tbxNewPhone";
            this.tbxNewPhone.Size = new System.Drawing.Size(200, 20);
            this.tbxNewPhone.TabIndex = 30;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new System.Drawing.Point(6, 119);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(36, 13);
            Label6.TabIndex = 31;
            Label6.Text = "Grade";
            // 
            // chbNewIsActive
            // 
            this.chbNewIsActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbNewIsActive.Location = new System.Drawing.Point(5, 143);
            this.chbNewIsActive.Name = "chbNewIsActive";
            this.chbNewIsActive.Size = new System.Drawing.Size(79, 24);
            this.chbNewIsActive.TabIndex = 32;
            this.chbNewIsActive.Text = "Active";
            this.chbNewIsActive.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new System.Drawing.Point(6, 176);
            Label7.Name = "Label7";
            Label7.Size = new System.Drawing.Size(43, 13);
            Label7.TabIndex = 33;
            Label7.Text = "Country";
            // 
            // CountryIdComboBox
            // 
            this.CountryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbTeacherBindingSource, "countryId", true));
            this.CountryIdComboBox.DataSource = this.tbCountryBindingSource;
            this.CountryIdComboBox.DisplayMember = "Name";
            this.CountryIdComboBox.FormattingEnabled = true;
            this.CountryIdComboBox.Location = new System.Drawing.Point(220, 188);
            this.CountryIdComboBox.Name = "CountryIdComboBox";
            this.CountryIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.CountryIdComboBox.TabIndex = 56;
            this.CountryIdComboBox.ValueMember = "Id";
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(12, 28);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(120, 20);
            this.tbxFilter.TabIndex = 55;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(256, 217);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(37, 23);
            this.btnLast.TabIndex = 54;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(225, 217);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 23);
            this.btnNext.TabIndex = 53;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(194, 217);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 23);
            this.btnPrevious.TabIndex = 52;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(151, 217);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(37, 23);
            this.btnFirst.TabIndex = 51;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbTeacherBindingSource, "gradeLevel", true));
            this.NumericUpDown1.Location = new System.Drawing.Point(220, 132);
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.NumericUpDown1.TabIndex = 50;
            // 
            // lbTeachers
            // 
            this.lbTeachers.DataSource = this.tbTeacherBindingSource;
            this.lbTeachers.DisplayMember = "lastName";
            this.lbTeachers.FormattingEnabled = true;
            this.lbTeachers.Location = new System.Drawing.Point(12, 54);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.Size = new System.Drawing.Size(120, 186);
            this.lbTeachers.TabIndex = 49;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new System.Drawing.Point(148, 31);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new System.Drawing.Size(55, 13);
            FirstNameLabel.TabIndex = 38;
            FirstNameLabel.Text = "First name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "firstName", true));
            this.FirstNameTextBox.Location = new System.Drawing.Point(220, 28);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameTextBox.TabIndex = 39;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new System.Drawing.Point(148, 57);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new System.Drawing.Size(56, 13);
            LastNameLabel.TabIndex = 40;
            LastNameLabel.Text = "Last name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "lastName", true));
            this.LastNameTextBox.Location = new System.Drawing.Point(220, 54);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameTextBox.TabIndex = 41;
            // 
            // DobLabel
            // 
            DobLabel.AutoSize = true;
            DobLabel.Location = new System.Drawing.Point(148, 84);
            DobLabel.Name = "DobLabel";
            DobLabel.Size = new System.Drawing.Size(28, 13);
            DobLabel.TabIndex = 42;
            DobLabel.Text = "DoB";
            // 
            // DobDateTimePicker
            // 
            this.DobDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbTeacherBindingSource, "dob", true));
            this.DobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DobDateTimePicker.Location = new System.Drawing.Point(220, 80);
            this.DobDateTimePicker.Name = "DobDateTimePicker";
            this.DobDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DobDateTimePicker.TabIndex = 43;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new System.Drawing.Point(148, 109);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new System.Drawing.Size(38, 13);
            PhoneLabel.TabIndex = 44;
            PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTeacherBindingSource, "phone", true));
            this.PhoneTextBox.Location = new System.Drawing.Point(220, 106);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.PhoneTextBox.TabIndex = 45;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(148, 134);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(36, 13);
            Label1.TabIndex = 46;
            Label1.Text = "Grade";
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbTeacherBindingSource, "isActive", true));
            this.IsActiveCheckBox.Location = new System.Drawing.Point(147, 158);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Size = new System.Drawing.Size(88, 24);
            this.IsActiveCheckBox.TabIndex = 47;
            this.IsActiveCheckBox.Text = "Active";
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // CountryIdLabel
            // 
            CountryIdLabel.AutoSize = true;
            CountryIdLabel.Location = new System.Drawing.Point(148, 191);
            CountryIdLabel.Name = "CountryIdLabel";
            CountryIdLabel.Size = new System.Drawing.Size(43, 13);
            CountryIdLabel.TabIndex = 48;
            CountryIdLabel.Text = "Country";
            // 
            // tbCountryBindingSource
            // 
            this.tbCountryBindingSource.DataMember = "tbCountry";
            this.tbCountryBindingSource.DataSource = this.dbDataSet;
            // 
            // tbCountryTableAdapter
            // 
            this.tbCountryTableAdapter.ClearBeforeFill = true;
            // 
            // tbCountryBindingSource1
            // 
            this.tbCountryBindingSource1.DataMember = "tbCountry";
            this.tbCountryBindingSource1.DataSource = this.dbDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 499);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.CountryIdComboBox);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.lbTeachers);
            this.Controls.Add(FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(DobLabel);
            this.Controls.Add(this.DobDateTimePicker);
            this.Controls.Add(PhoneLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(Label1);
            this.Controls.Add(this.IsActiveCheckBox);
            this.Controls.Add(CountryIdLabel);
            this.Controls.Add(this.tbTeacherBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingNavigator)).EndInit();
            this.tbTeacherBindingNavigator.ResumeLayout(false);
            this.tbTeacherBindingNavigator.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource tbTeacherBindingSource;
        private dbDataSetTableAdapters.tbTeacherTableAdapter tbTeacherTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbTeacherBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbTeacherBindingNavigatorSaveItem;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.ComboBox cbxNewCountry;
        internal System.Windows.Forms.NumericUpDown nudNewGrade;
        internal System.Windows.Forms.TextBox tbxNewFirstName;
        internal System.Windows.Forms.TextBox tbxNewLastName;
        internal System.Windows.Forms.DateTimePicker dtpNewDoB;
        internal System.Windows.Forms.TextBox tbxNewPhone;
        internal System.Windows.Forms.CheckBox chbNewIsActive;
        internal System.Windows.Forms.ComboBox CountryIdComboBox;
        internal System.Windows.Forms.TextBox tbxFilter;
        internal System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnPrevious;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.NumericUpDown NumericUpDown1;
        internal System.Windows.Forms.ListBox lbTeachers;
        internal System.Windows.Forms.TextBox FirstNameTextBox;
        internal System.Windows.Forms.TextBox LastNameTextBox;
        internal System.Windows.Forms.DateTimePicker DobDateTimePicker;
        internal System.Windows.Forms.TextBox PhoneTextBox;
        internal System.Windows.Forms.CheckBox IsActiveCheckBox;
        private dbDataSetTableAdapters.tbCountryTableAdapter tbCountryTableAdapter;
        private System.Windows.Forms.BindingSource tbCountryBindingSource;
        private System.Windows.Forms.BindingSource tbCountryBindingSource1;
    }
}

