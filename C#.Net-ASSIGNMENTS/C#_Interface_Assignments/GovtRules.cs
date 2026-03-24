using System;
using System.Collections.Generic;
using System.Text;

namespace C__Interface_Assignments
{
    internal interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double GratuityAmount(float serviceCompleted, double basicSalary);
    }
}
