using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1
{
    internal class Appointment
    {
        public int AppointmentId;
        public string PatientName = "";
        public string DoctorName = "";
        public DateTime AppointmentDate;

        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Now;
        }

    }
}
