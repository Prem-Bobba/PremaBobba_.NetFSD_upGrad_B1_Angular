using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_Healthcare_System
{
    internal class Doctor : Staff
    {

        public double ConsultationFee { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + ConsultationFee;
        }
    }
}
