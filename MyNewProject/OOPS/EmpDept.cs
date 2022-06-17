using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    class Department
    {
        int did;
        string dname;
        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public string Dname
        {
            get { return dname; }
            set { dname = value; }
        }
    }
     class EmpDept
    {
        int eid;
        string name;
        Department dept;
        public int Eid
        {
            get { return eid; }
            set { eid=value; }
        }
        public string Name
        {
            get { return name; }
            set { name=value; }
        }
        public Department Dept
        {
            get { return dept; }
            set { dept=value; }
        }
        static void Main(string[] args)
        {
            EmpDept emp = new EmpDept();
            emp.Eid = 101;
            emp.Name = "pramod";
            emp.Dept = new Department();
            emp.Dept.Did = 1;
            emp.Dept.Dname = "HR";
            Console.WriteLine(emp.Eid+" "+emp.name+ " "+emp.Dept.Did+" "+emp.Dept.Dname);

        }
    }
}
