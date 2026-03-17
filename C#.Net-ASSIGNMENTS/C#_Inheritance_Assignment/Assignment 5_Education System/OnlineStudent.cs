using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Education_System
{
    internal class OnlineStudent : Student
    {
        public OnlineStudent(int id, string name, int marks)
        : base(id, name, marks) { }

        public override string CalculateGrade()
        {
            return Marks > 60 ? "Pass" : "Fail";
        }
    }
}
