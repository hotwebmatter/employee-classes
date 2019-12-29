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
        private DateTime dateOfHire = new DateTime();
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
            dateOfHire = DateTime.Today;
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
            string result = String.Format("********** Employee Data Table **********\n");
            result += String.Format("* {0, 18} {1, 18} *\n", "Employee ID:", employeeNumber);
            result += String.Format("* {0, 18} {1, 18} *\n", "First Name:", firstName);
            result += String.Format("* {0, 18} {1, 18} *\n", "Last Name:", lastName);
            result += String.Format("* {0, 18} {1, 18} *\n", "Job Description:", jobDescription);
            result += String.Format("* {0, 18} {1, 18} *\n", "Department:", department);
            result += String.Format("* {0, 18} {1, 18:MM/dd/yyyy} *\n", "Date of Hire:", dateOfHire);
            result += String.Format("* {0, 18} {1, 18:C} *\n", "Monthly Salary:", monthlySalary);
            result += String.Format("*****************************************\n");
            return result;
        }
    }
}
