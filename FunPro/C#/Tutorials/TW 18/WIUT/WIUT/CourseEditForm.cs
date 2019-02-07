using System;
using System.Windows.Forms;
using WIUT.DAL;

namespace WIUT
{
    public partial class CourseEditForm : Form
    {
        public CourseEditForm()
        {
            InitializeComponent();
        }

        public Course Course { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewCourse()
        {
            Mode = FormMode.CreateNew;
            Course = new Course();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateCourse(Course course)
        {
            Mode = FormMode.Update;
            Course = course;
            InitializeControls();
            ShowCourseInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowCourseInControls()
        {
            tbxName.Text = Course.Name;
        }

        private void GrabUserInput()
        {
            Course.Name = tbxName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new CourseManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Course);
                else
                    manager.Update(Course);

                MyForms.GetForm<CourseListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
