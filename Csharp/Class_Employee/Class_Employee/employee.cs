using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_script
{
    class Employee
    {
        private string Employee_name;
        private int Employee_age;
        private double Employee_salary;
        public static int Employee_counter;

        public Employee(string name, int age, double salary)
        {
            Employee_name = name;
            Employee_age = age;
            Employee_salary = salary;
        }

        public Employee(string name)
        {
            Employee_name = name;
        }

        public Employee() { }

        //-------------------------------------------------
        public virtual void getPromotion(double rise)
        {
            Employee_salary *= (1 + rise / 100);
        }

        //-----------------------------------------------
        //Properties
        public string EmployeeName
        {
            get { return Employee_name; }
            set { Employee_name = value; }
        }

        public int EmployeeAge
        {
            get { return Employee_age; }
            set { Employee_age = value; }
        }

        public double EmployeeSalary
        {
            get { return Employee_salary; }
            set { Employee_salary = value; }
        }


        public static int getCounter()
        {
            return Employee_counter;
        }

        public void Hire(double salary)
        {
            EmployeeSalary = salary;
            Employee_counter++;
        }



    }
}
