using System;
using static System.Console;

namespace employee_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee anEmployee = new Employee();
            WriteLine(anEmployee.FullName());
            WriteLine(anEmployee.FullNameSortable());
        }
    }
}
