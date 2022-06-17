using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class Thiskeyword
    {
        int x;
        public Thiskeyword():this(67)
        {
            Console.WriteLine("default");
        }
        public Thiskeyword(int x)
        {
            Console.WriteLine("x=" +x);
        }
        public void get(int x)
        {
            this.x = x;
            this.show();
        }
          public void show()
        {
            Console.WriteLine(x);
        }


        static void Main(string[] args)
        {
            Thiskeyword t = new Thiskeyword();
            t.get(12);
                
        }
    }
}
