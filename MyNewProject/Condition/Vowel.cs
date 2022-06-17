using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Condition
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch=Convert.ToChar(Console.ReadLine());
            if(ch=='A')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='E')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='I')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='O')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='U')
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
