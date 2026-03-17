using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Education_System
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(int id, string name, int marks)
        {
            StudentId = id;
            Name = name;
            Marks = marks;
        }
        public virtual string CalculateGrade()
        {
            if (Marks > 50)
                return "Pass";
            else
                return "Fail";
        }

    }
}
