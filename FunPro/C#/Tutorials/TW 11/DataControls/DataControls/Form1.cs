using System;
using System.Data;
using System.Windows.Forms;

namespace DataControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region " Data load "

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the //dbDataSet.tbCountry// table. You can move, or remove it, as needed.
            tbCountryTableAdapter.Fill(dbDataSet.tbCountry);
            //load data to in-memory dataset in correct order
            try
            {
                tbCountryTableAdapter.Fill(dbDataSet.tbCountry);
                tbTeacherTableAdapter.Fill(dbDataSet.tbTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region " Navigation "

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveNext();
            EnableDisableButtons();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbTeacherBindingSource.MoveLast();
        }

        private void tbTeacherBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }

        private void EnableDisableButtons()
        {
            //enable and disble navigation buttons
            if (tbTeacherBindingSource.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }

            if (tbTeacherBindingSource.Position == tbTeacherBindingSource.Count - 1)
            {
                btnLast.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        #endregion

        #region " CRUD "

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get dataset row with selected country
            var selectedCountry = ((DataRowView) cbxNewCountry.SelectedItem).Row;

            //add to in-memory dataset
            dbDataSet.tbTeacher.AddtbTeacherRow(tbxNewFirstName.Text,
                tbxNewLastName.Text,
                dtpNewDoB.Value,
                tbxNewPhone.Text,
                (int) nudNewGrade.Value,
                chbNewIsActive.Checked,
                (dbDataSet.tbCountryRow) selectedCountry);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbTeacherBindingSource.Count > 0)
                tbTeacherBindingSource.RemoveCurrent();
        }

        #endregion

        #region " Save "

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void tbTeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Validate();
            tbTeacherBindingSource.EndEdit();
            if (dbDataSet.HasChanges())
            {
                if (MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    SaveData();
            }
        }

        private void SaveData()
        {
            try
            {
                Validate();
                tbTeacherBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dbDataSet);

                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region " Filter "

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tbTeacherBindingSource.Filter = $" lastName LIKE '{tbxFilter.Text}%'";

        }

        #endregion

        #region " Validation "

        private void dtpNewDoB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DobDateTimePicker.Value.AddYears(18) > DateTime.Now)
            {
                MessageBox.Show("Should be at least 18 years old");
                e.Cancel = true;
            }
        }

        #endregion
    }
}