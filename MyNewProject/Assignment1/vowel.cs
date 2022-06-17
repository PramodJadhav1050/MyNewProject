using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment1
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o'|| ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
