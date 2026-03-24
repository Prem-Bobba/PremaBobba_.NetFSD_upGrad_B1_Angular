using System;
using System.Collections.Generic;
using System.Text;

namespace C__Interface_Assignments
{
    internal class Accenture : GovtRules
    {
        private int empid;
        private string name;
        private string dept;
        private string desg;
        private double basicSalary;

        public Accenture(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public int EmpId => empid;
        public string Name => name;
        public string Dept => dept;
        public string Desg => desg;
        public double Salary => basicSalary;

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.12;

            return employeePF + employerPF;
        }

        public string LeaveDetails()
        {
            return "Casual Leave: 2/month, Sick Leave: 5/year, Privilege Leave: 5/year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0; 
        }

    }
}
