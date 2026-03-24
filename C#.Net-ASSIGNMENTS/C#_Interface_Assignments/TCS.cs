using System;
using System.Collections.Generic;
using System.Text;

namespace C__Interface_Assignments
{
    internal class TCS : GovtRules
    {

        private int empid;
        private string name;
        private string dept;
        private string desg;
        private double basicSalary;

        public TCS(int empid, string name, string dept, string desg, double basicSalary)
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
            double employerPF = basicSalary * 0.0833;
            double pension = basicSalary * 0.0367;

            return employeePF + employerPF + pension;
        }

        public string LeaveDetails()
        {
            return "Casual Leave: 1/month, Sick Leave: 12/year, Privilege Leave: 10/year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return basicSalary * 3;
            else if (serviceCompleted > 10)
                return basicSalary * 2;
            else if (serviceCompleted > 5)
                return basicSalary * 1;
            else
                return 0;
        }
    }
}
