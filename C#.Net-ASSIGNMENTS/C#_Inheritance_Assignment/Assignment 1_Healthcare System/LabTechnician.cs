using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_Healthcare_System
{
    internal class LabTechnician : Staff
    {
        public double EquipmentAllowance { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + EquipmentAllowance;
        }
    }
}
