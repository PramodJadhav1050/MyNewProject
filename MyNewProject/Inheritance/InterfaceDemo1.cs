using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    public interface Iprintable
    {
        void run();
    }
    public interface Imoveable
    {
        public static int x = 67;
        void show();

        static void move()
        {
            Console.WriteLine("Move");
        }
        internal void foo()
        {
            Console.WriteLine("foo");
        }
    }
     class InterfaceDemo1:Imoveable,Iprintable
    {
        public void show()
        {
            Console.WriteLine("Show method"+" "+Imoveable.x);
        }
        public void run()
        {
            Console.WriteLine("run.........");
        }
        static void Main(string[] args)
        {
            Imoveable m=new InterfaceDemo1();
            m.show();
            Imoveable.move();
            m.foo();
            Iprintable p = new InterfaceDemo1();
            p.run();
        }

    }
    
}
