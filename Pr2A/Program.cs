using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2A
{
   

    namespace pr2
    {
        interface IPayroll
        {
            double CalculateSalary();
        }

        abstract class Employee : IPayroll
        {
            public int EmployeeId;
            public string EmployeeName;
            public double BasicSalary;

            public Employee(int id, string name, double salary)
            {
                EmployeeId = id;
                EmployeeName = name;
                BasicSalary = salary;
            }

            public abstract double CalculateSalary();

            public void Display(string type)
            {
                Console.WriteLine("\n------ Employee Details ------");
                Console.WriteLine("Employee Type : " + type);
                Console.WriteLine("Employee ID   : " + EmployeeId);
                Console.WriteLine("Employee Name : " + EmployeeName);
                Console.WriteLine("Basic Salary  : " + BasicSalary);
                Console.WriteLine("HRA (10%)     : " + (BasicSalary * 0.10));
                Console.WriteLine("DA (20%)     : " + (BasicSalary * 0.20));
                Console.WriteLine("Increase Salary  : " + CalculateSalary());
            }
        }




        class FullTimeEmployee : Employee
        {
            public FullTimeEmployee(int id, string name, double salary)
                : base(id, name, salary)
            {
            }

            public override double CalculateSalary()
            {
                return BasicSalary + (BasicSalary * 0.10);
            }
        }

        class PartTimeEmployee : Employee
        {
            public PartTimeEmployee(int id, string name, double salary)
                : base(id, name, salary)
            {
            }

            public override double CalculateSalary()
            {
                return BasicSalary + (BasicSalary * 0.10);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("==================================");
                Console.WriteLine(" Employee Payroll Management");
                Console.WriteLine("==================================");

                Console.WriteLine("\nSelect Employee Type");
                Console.WriteLine("1. Full Time Employee");
                Console.WriteLine("2. Part Time Employee");

                Console.Write("\nEnter Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                

                Employee emp;

                if (choice == 1)
                {
                    Console.Write("\nEnter Employee ID : ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Employee Name : ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Basic Salary : ");
                    double salary = Convert.ToDouble(Console.ReadLine());

                    emp = new FullTimeEmployee(id, name, salary);
                    emp.Display("Full Time");
                }
                else if (choice == 2)
                {
                    Console.Write("\nEnter Employee ID : ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Employee Name : ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Basic Salary : ");
                    double salary = Convert.ToDouble(Console.ReadLine());

                    emp = new PartTimeEmployee(id, name, salary);
                    emp.Display("Part Time");
                }
                else
                {
                    Console.WriteLine("Invalid Choice.");
                }

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
