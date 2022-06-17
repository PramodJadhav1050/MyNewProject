using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    abstract class Vahical
    {
        public abstract void show();
    }
    class Ccar : Vahical
    {
        public override void show()
        {
            Console.WriteLine("swift sport");
        }
    }
    class Truck : Vahical
    {
        public override void show()
        {
            Console.WriteLine("Hyva bS6");
        }
    }
    class bike : Vahical
    {
        public override void show()
        {
            Console.WriteLine("KTM RC200");
        }
    }
     class Abractiondemo
    {
        static void Main(string[] args)
        {
            Vahical v = new Ccar();
            v.show();
            Vahical v1 = new Truck();
            v1.show();
            Vahical v2 = new bike();
            v2.show();
        }
    }

}
