using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyApp
{
    public class Employee
    {
        public static int Id = 0;

        public int empIDCount;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id++;
            empIDCount = Id;
        }

        public int EmployeeID
        {
            get { return empIDCount; }
        }
    }
}