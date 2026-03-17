using System;

namespace C__Class_Assignment_1
{
     class Program
    {
        static void Main()
        {
            //Assignment1

            Patient p = new Patient();

            p.PatientId = 101;
            p.PatientName = "Ravi Kumar";
            p.Age = 45;
            p.Disease = "Diabetes";

            Console.WriteLine("Patient Id :" + p.PatientId);
            Console.WriteLine("Patient Name :" + p.PatientName);
            Console.WriteLine("Age :" + p.Age);
            Console.WriteLine("Disease :" + p.Disease);

            Console.WriteLine();

            //Assignment2

            Doctor d1 = new Doctor();
            d1.DoctorId = 101;
            d1.DoctorName = "Dr. Ramesh";
            d1.Specialization = "Cardiologist";
            d1.ConsultationFee = 500;

            Doctor d2 = new Doctor();
            d2.DoctorId = 102;
            d2.DoctorName = "Dr. Sita";
            d2.Specialization = "Dermatologist";
            d2.ConsultationFee = 300;

            Console.WriteLine("Doctor 1 Details:");
            Console.WriteLine();
            Console.WriteLine("Id: " + d1.DoctorId);
            Console.WriteLine("Name: " + d1.DoctorName);
            Console.WriteLine("Specialization: " + d1.Specialization);
            Console.WriteLine("Fee: " + d1.ConsultationFee);

            Console.WriteLine();

            Console.WriteLine("Doctor 2 Details:");
            Console.WriteLine();

            Console.WriteLine("Id: " + d2.DoctorId);
            Console.WriteLine("Name: " + d2.DoctorName);
            Console.WriteLine("Specialization: " + d2.Specialization);
            Console.WriteLine("Fee: " + d2.ConsultationFee);

            Console.WriteLine();

            //Assignment3

            Hospital.HospitalName = "Capital Hospital";
            Hospital.HospitalAddress = "Hyderabad";

            Hospital p1 = new Hospital();
            Hospital p2 = new Hospital();
            Hospital p3 = new Hospital();

            p1.PatientName = "Ravi";
            p2.PatientName = "Sita";
            p3.PatientName = "John";

            Console.WriteLine("Hospital Name : " + Hospital.HospitalName);
            Console.WriteLine("Hospital Address : " + Hospital.HospitalAddress);

            Console.WriteLine();

            Console.WriteLine("Patient 1:" + p1.PatientName);
            Console.WriteLine("Patient 2:" + p2.PatientName);
            Console.WriteLine("Patient 3:" + p3.PatientName);

            Console.WriteLine();

            //Assignment4

            Appointment a = new Appointment();


            a.AppointmentId = 101;
            a.PatientName = "Ravi Kumar";


            Console.WriteLine("Appointment Id: " + a.AppointmentId);
            Console.WriteLine("Patient Name: " + a.PatientName);
            Console.WriteLine("Doctor Name: " + a.DoctorName);
            Console.WriteLine("Appointment Date: " + a.AppointmentDate);

            Console.WriteLine();

            //Assignment5

            MedicalTest t1 = new MedicalTest(1, "Blood Test", 500);
            MedicalTest t2 = new MedicalTest(2, "X-Ray", 1000);

            Console.WriteLine("Test 1:");
            Console.WriteLine(t1.TestId + " " + t1.TestName + " " + t1.TestCost);

            Console.WriteLine();

            Console.WriteLine("Test 2:");
            Console.WriteLine(t2.TestId + " " + t2.TestName + " " + t2.TestCost);

            Console.WriteLine();

            //Assignment6

            Billing b = new Billing();

            b.PatientName = "Ramesh";
            b.ConsultationFee = 500;
            b.TestCharges = 1000;

            b.CalculateTotalBill();

            Console.WriteLine();

            //Assignment7

            Nurse n = new Nurse();

            {

            n.NurseId = 301;
            n.NurseName = "Anjali";
            n.Department = "ICU";

            };

            Console.WriteLine("Nurse ID " + n.NurseId);
            Console.WriteLine("Nurse Name " + n.NurseName);
            Console.WriteLine("Department " + n.Department);

            Console.WriteLine();

            //Assignment8

            PatientRecord.HospitalName = "Apollo Hospital";

            PatientRecord pp1 = new PatientRecord(101, "Ravi", 40, "Fever");
            PatientRecord pp2 = new PatientRecord(102, "Sita", 35, "Diabetes");
            PatientRecord pp3 = new PatientRecord(103, "John", 50, "BP");

            pp1.DisplayPatientRecord();
            pp2.DisplayPatientRecord();
            pp3.DisplayPatientRecord();


        }
    }
}
