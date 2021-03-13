using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Entities;

namespace ConsoleApp2.UI
{
    class EmployeeUI
    {
        Employee[] empCollection = new Employee[3];
        
        void AddEmployee()
        {
            int length = empCollection.Length;
            for (int i = 0; i < length; i++)
            {
                Employee e = new Employee();
                Console.Write("Enter id = ");
                e.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name = ");
                e.FullName = Console.ReadLine();         // Error:: Console.ReadLine()    

                Console.Write("Enter Mobile = ");
                e.Mobile = Console.ReadLine();             // Error:: Console.ReadLine() 

                Console.Write("Enter Salary = ");
                e.Salary = Convert.ToDecimal(Console.ReadLine());   // Error: Convert.ToDecimal(Console.ReadLine()); 

                Console.Write("Enter Department Name  = ");
                e.DepartmentName = Console.ReadLine();      // Error:: Console.ReadLine() 

                empCollection[i] = e;
                Console.WriteLine("Employee no " + (i + 1) + " is added");
            }

            //Employee e1 = new Employee();
            //e1.Id = 1;
            //e1.FullName = "Daniel";
            //e1.Mobile = "9876543210";
            //e1.Salary = 5600;
            //e1.DepartmentName = "IT";

            //empCollection[0] = e1;

            //Employee e2 = new Employee();
            //e2.Id = 2;
            //e2.FullName = "William";
            //e2.Mobile = "9876543210";
            //e2.Salary = 5300;
            //e2.DepartmentName = "IT";

            //empCollection[1] = e2;


        }

        void PrintEmployee()
        {
            int length = empCollection.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(empCollection[i].Id + "\t" + empCollection[i].FullName + "\t" + empCollection[i].Salary + "\t" + empCollection[i].Mobile + "\t" + empCollection[i].DepartmentName);
            }
        }

        public void Run()
        {
            AddEmployee();
            PrintEmployee();
        }
    }
}

