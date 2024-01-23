using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_script
{
    public abstract class Person
    {
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Person(string name)
        {
            _name = name;
        }

        protected string _name;
        protected int _age;


        public abstract void Fire();
    }
}
