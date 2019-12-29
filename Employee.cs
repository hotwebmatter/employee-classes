using System;
using System.Collections.Generic;
using System.Text;

namespace employee_classes
{
    class Employee
    {
        // data members
        private int employeeNumber;
        private string firstName,
                       lastName,
                       jobDescription,
                       department;
        private DateTime dateOfHire;
        private double monthlySalary;
        // auto-implemented property members
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public DateTime DateOfHire { get; set; }
        public double MonthlySalary { get; set; }
    }
}
