using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Student
    {
        public string Address { get; set; }

        public float GPA { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public Student() { }

        override public string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nID: {Id}\nGPA: {GPA}\n";
        }
    }
}
