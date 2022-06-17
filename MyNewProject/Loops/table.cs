using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num=int.Parse(Console.ReadLine());

            for ( int i = 1; i <= 10; i++)
            {

                Console.WriteLine(num+"*"+i+"=" +num*i);
            }
        }
    }
}
