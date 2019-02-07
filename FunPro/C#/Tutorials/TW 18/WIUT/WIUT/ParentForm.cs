using System;
using System.Windows.Forms;
using WIUT.DAL;

namespace WIUT
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void allApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<ApplicantListForm>().Show();
        }

        private void allCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<CourseListForm>().Show();
        }

        private void newCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CourseEditForm().CreateNewCourse();
        }
    }
}
