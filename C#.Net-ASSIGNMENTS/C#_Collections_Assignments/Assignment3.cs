using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignments
{
    internal class Assignment3
    {
        static void Main()
        {
            HashSet<string> emails = new HashSet<string>();

            emails.Add("ravi@gmail.com");
            emails.Add("kiran@gmail.com");
            emails.Add("amit@gmail.com");
            emails.Add("raj@gmail.com");
            emails.Add("anil@gmail.com");
            emails.Add("ravi@gmail.com"); 
            emails.Add("amit@gmail.com"); 
            emails.Add("sita@gmail.com");
            emails.Add("geeta@gmail.com");
            emails.Add("ram@gmail.com");

            Console.WriteLine("Unique Emails:");
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            if (emails.Contains("amit@gmail.com"))
            {
                Console.WriteLine("\nEmail is registered");
            }

            emails.Remove("raj@gmail.com");

            Console.WriteLine("\nAfter Removal:");
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            HashSet<string> event1 = new HashSet<string>()
        {
            "ravi@gmail.com",
            "kiran@gmail.com",
            "amit@gmail.com"
        };

            HashSet<string> event2 = new HashSet<string>()
        {
            "amit@gmail.com",
            "raj@gmail.com",
            "kiran@gmail.com"
        };

            event1.IntersectWith(event2);

            Console.WriteLine("\nCommon Participants:");
            foreach (var e in event1)
            {
                Console.WriteLine(e);
            }

        }
    }
}
