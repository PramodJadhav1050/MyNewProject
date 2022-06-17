using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class Student
    {
            public int id;
            public string name;
            public int m1, m2, m3;
            public int per;

            public void Accept(int sid, string sname, int sub1, int sub2, int sub3)
            {
                id = sid;
                name = sname;
                m1 = sub1;
                m2 = sub2;
                m3 = sub3;
            }

            public void Calculate()
            {
                per = (m1 + m2 + m3) / 3;
            }
            public void Display()
            {
                Console.WriteLine(id + "  " + name + "  " + m1 + " " + m2 + " " + m3 + " = " + per);
            }
            static void Main(string[] args)
            {
                Student s = new Student();
                s.Accept(11, "Pramod", 87, 79, 74);

                s.Calculate();
                s.Display();
            }
        
    }
}                                 
