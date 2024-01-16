using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_script
{
    class Manager : Employee
    {
        public Manager(string department) : base ("Javier", 22, 100)
        {
            Department = department;
        }

        public string Department { get; set; }  

        public override void getPromotion(double rise)
        {
            this.EmployeeSalary *= (10 + rise / 100);

        }




    }
}
