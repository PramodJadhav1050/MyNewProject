using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class printatoz
    {
        static void Main(string[] args)
        {
            char ch;
            for (ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.WriteLine(ch + " ");
            }
        }
    }
}
