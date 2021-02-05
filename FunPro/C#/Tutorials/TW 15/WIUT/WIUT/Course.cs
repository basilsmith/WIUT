namespace WIUT
{
    class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Course()
        {

        }

        public Course(string name)
        {
            Name = name; 
        }
    }
}
