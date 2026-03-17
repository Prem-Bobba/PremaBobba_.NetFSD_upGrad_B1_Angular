using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Education_System
{
    internal class CollegeStudent : Student
    {
        public CollegeStudent(int id, string name, int marks)
        : base(id, name, marks) { }

        public override string CalculateGrade()
        {
            return Marks > 50 ? "Pass" : "Fail";
        }
    }
}
