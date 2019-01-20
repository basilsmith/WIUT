using System;

namespace WIUT.DAL
{
    public class Applicant
    {
        private string _name;
        private string _surname;
        private string _address;
        private DateTime _doB;
        private string _passportNo;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be empty");
                _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Surname cannot be empty");
                _surname = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Address cannot be empty");
                _address = value;
            }
        }

        public DateTime DoB
        {
            get => _doB;
            set
            {
                if (value.AddYears(18) > DateTime.Now) //not yet 18
                    throw new Exception("Applicant should be at least 18 years old");
                _doB = value;
            }
        }

        public string MaritalStatus { get; set; }

        public string PassportNo
        {
            get => _passportNo;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Passport No cannot be empty");
                _passportNo = value;
            }
        }

        public Course Course { get; set; }

        public Applicant()
        {
        }

        public Applicant(string name, string surname, string address, DateTime doB, string maritalStatus, string passportNo, Course course)
        {
            Name = name;
            Surname = surname;
            Address = address;
            DoB = doB;
            MaritalStatus = maritalStatus;
            PassportNo = passportNo;
            Course = course;
        }
    }
}