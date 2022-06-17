using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Basic
{
    internal class Datatypedemo
    {
        static void Main (string[] args)
        {
            byte mybyte = 23;
            sbyte mybyte2 = -78;
            Console.WriteLine(mybyte+""+mybyte2);

            short myshort = 7899;
            short myshort2 = -988;
            Console.WriteLine(myshort + "" + myshort2);

            int m1 = 78888;
            int m2 = -444242;
            Console.WriteLine(m1 + "" + m2);

            long l = -99777676756567L;
            Console.WriteLine(l);

            double d = 78.56;
            Console.WriteLine(d);

            float f = 67.34f;
            Console.WriteLine(f);

            char ch = 'r';
            Console.WriteLine(ch);

        }
    }
}
