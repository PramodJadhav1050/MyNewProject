using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Mobile
    {
        public string storage = "128gb";
    }
    class Redmi : Mobile
    {
        public string battery = "6000mAph";

    }
    class Samsung : Mobile
    {
        public string RAM = "6 gb";

    }
    class Vivo : Mobile
    {
        public string camera = "48mp";

    }
    class hierachydemo
    {
        static void Main(string[] args)
        {
            Redmi r = new Redmi();
            Console.WriteLine("redmi   " + r.battery + " " + r.storage);
            Samsung s = new Samsung();
            Console.WriteLine("samsung " + s.RAM + " " + s.storage);
            Vivo v = new Vivo();
            Console.WriteLine("vivo  " + v.camera + " " + v.storage);
        }
    }
}

