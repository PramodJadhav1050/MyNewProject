using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Bike
    {
        public int tyre = 0;
        public void Display()
        {
            Console.WriteLine("bike");
        }

    }
    class splender : Bike
    {
        public void Show()
        {
            tyre = 2;
            Console.WriteLine(tyre);
        }
    }
    class SingleDemo
    {
        static void Main(string[] args)
        {
            splender s = new splender();
            s.Display();
            s.Show();
        }
    }

}
