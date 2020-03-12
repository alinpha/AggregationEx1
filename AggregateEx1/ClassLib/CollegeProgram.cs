using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class CollegeProgram
    {
        private string name;

        public string Name 
        {
            get { return name; }
            set
            {
                if (!Validate.ValidNotEmpty(value))
                {
                    throw new ArgumentException("Name is required.");
                }

                if (!Validate.ValidLessThanLength(value, 21))
                {
                    throw new ArgumentException("Name must be no longer than 20 characters.");
                }

                name = value;
            }
        }

        public List<Student> Students { get; } = new List<Student>();

        public CollegeProgram(string name) 
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public Student Retrieve(int studentID)
        {
            IEnumerable<Student> ienum = Students.Where(std => std.Id == studentID);
            if (ienum.Count() > 0)
            {
                return ienum.FirstOrDefault();
            }
            else
            {
                throw new DataException("Student does not exist.");
            }
        }

        public List<Student> Retrieve(string studentName)
        {
            IEnumerable<Student> ienum = Students.Where(std => std.Name == studentName);
            if (ienum.Count() > 0)
            {
                return ienum.ToList();
            }
            else
            {
                throw new DataException("Student does not exist.");
            }
            
        }


    }
}
