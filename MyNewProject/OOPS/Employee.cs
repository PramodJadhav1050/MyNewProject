using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class Employee
    {
        int id;
        string name;
        int salary;

        public Employee(int eid, string ename, int Salary)
        {
            id = eid;
            name = ename;
            salary = Salary;
        }
        void display()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(11, "Pramod", 38000);
            e.display();

        }

        
    }
}
