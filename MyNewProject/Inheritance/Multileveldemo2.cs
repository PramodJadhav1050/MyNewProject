using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Education
    {
        public string name = "education ";

    }

    class Bsc : Education
    {
        public string choice = "Stream";

    }

    class Branch : Bsc
    {

        public string branch = "Computer Science";



        public void show()
        {

            Console.WriteLine(name + " " + choice + " " + branch);


        }
    }
    class MultilevelDemo2
    {
        static void Main(string[] args)
        {
            Branch b = new Branch();
            b.show();
        }

    }
}

