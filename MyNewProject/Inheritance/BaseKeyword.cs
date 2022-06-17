using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Student
    {
        public int mark = 88;
    }
    class Teacher : Student
    {
        public int mark = 98;
        public void show()
        {
            Console.WriteLine(mark + " " + base.mark);
        }
    }
    class BaseKeyword

    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.show();
        }
    }


}