using System.Collections.Generic;

namespace WIUT.DAL
{
    public class CourseList
    {
        public List<Course> GetAllCourses()
        {
            return new CourseManager().GetAll();
        }
    }
}
