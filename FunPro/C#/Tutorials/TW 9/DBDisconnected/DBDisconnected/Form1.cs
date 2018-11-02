using System;
using System.Windows.Forms;

namespace DBDisconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            tb_teacherTableAdapter.Fill(dbDataSet.tb_teacher);
        }

        private void tb_teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                Validate();
                tb_teacherBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dbDataSet);
                MessageBox.Show("Saved");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
