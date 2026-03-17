using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Education_System
{
    internal class SchoolStudent : Student
    {
        public SchoolStudent(int id, string name, int marks)
        : base(id, name, marks) { }

        public override string CalculateGrade()
        {
            return Marks > 40 ? "Pass" : "Fail";
        }
    }
}
