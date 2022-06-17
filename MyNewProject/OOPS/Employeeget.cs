using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class Employeeget
    {
        private int id;
        private string name;
        private double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        static void Main(string[] args)
        {
            Employeeget emp = new Employeeget();
            emp.Id = 2525;
            emp.Name = "Pramod";
            emp.Salary = 50000;
            Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Salary);
        }
    }
    
}
