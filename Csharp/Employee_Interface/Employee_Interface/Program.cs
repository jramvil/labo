//The concepts of OOP in C#
using System;
using System.Collections.Generic;
namespace employee_script
{
    class Program
    {
        public static double average = 0;
        public static string name;
        public static double salary;
        static int getAge()
        {
            Random random = new Random();
            int age;
            age = random.Next(18, 67);
            return age;
        }




        public static void Main(string[] args)
        {
            Employee[] company = new Employee[4];


            double total = 0;


            for (int i = 0; i < company.Length; i++)
            {
                Console.WriteLine("Enter the name of an employee: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the salary: ");
                salary = double.Parse(Console.ReadLine());
                total += salary;
                company[i] = new Employee(name);
                company[i].Hire(salary);
            }


            average = total / 4;


            int greater = 0;

            for (int i = 1; i < company.Length; i++)
            {
                if (company[i].EmployeeSalary >= company[i - 1].EmployeeSalary)
                {
                    if (i > greater)
                    {
                        greater = i;
                    }
                }
            }



            for (int i = 0; i < company.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", company[i].EmployeeName, company[i].EmployeeAge, company[i].EmployeeSalary);
            }
            Console.WriteLine("{0} {1}", "The average salary is: ", average);

            /*
            Console.WriteLine("{0} {1} {2}", "The higher salary is: ", company[greater].Employee_name, company[greater].Employee_salary);
            Console.ReadKey();
            */
            company[0].getPromotion(10);
            Console.WriteLine("{0} {1}", "new salary: ", company[0].EmployeeSalary);
            Console.WriteLine("We have " + Employee.getCounter() + " employees");


            //-----------------------------------------------------------------------------------------------------------------

            Manager manager = new Manager("sells");

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("¡¡¡MANAGER PROMOTION!!!");

            Console.WriteLine(manager.EmployeeName + " " + manager.EmployeeSalary);
            manager.getPromotion(20);

            Console.WriteLine(manager.EmployeeSalary);



        }
    }
}

