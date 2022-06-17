using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment1
{
    internal class alphadigitspecial
    {
        static void Main(string[] args)
        {

            char ch;
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "is an Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit");
            }
            else
            {
                Console.WriteLine(ch + "is a Symbol");
            }
        }
    }
}
