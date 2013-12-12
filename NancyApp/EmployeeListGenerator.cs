using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyApp
{
    public class EmployeeListGenerator
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> empList = new List<Employee>();
            Employee firstEmp = new Employee();
            firstEmp.FirstName = "Brendan";
            firstEmp.LastName = "McGarrett";
            empList.Add(firstEmp);

            Employee secondEmployee = new Employee();
            secondEmployee.FirstName = "Megan";
            secondEmployee.LastName = "Caldwell";
            empList.Add(secondEmployee);

            return empList;
        }
    }
}