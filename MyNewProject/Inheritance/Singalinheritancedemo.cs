using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Fruit
    {
        public int qty = 0;
        public void Display()
        {
            Console.WriteLine("fruit");
        }
    }
    class Apple : Fruit
    {
        public void show()
        {
            qty = 5;
            Console.WriteLine(qty);
        }
    }
    class SingleInheritanceDemo
    {
        static void Main(string[] args)
        {
            Apple a = new Apple();
            a.Display();
            a.show();

        }
    }
    
}
