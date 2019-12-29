﻿using System;
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
        // implement constructor
        public Employee()
        {
            employeeNumber = 42;
            firstName = "Arthur";
            lastName = "Dent";
            jobDescription = "hitchhiker";
            department = "mostly harmless";
            dateOfHire = new DateTime();
            monthlySalary = 0;
        }
        // return full name (First Last)
        public string FullName()
        {
            return String.Format("{0} {1}", firstName, lastName);
        }
        // return full name (Last, First)
        public string FullNameSortable()
        {
            return String.Format("{1}, {0}", firstName, lastName);
        }
        // override base.ToString() method
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
