using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class magicwhile
    {
        static void Main(string[] args)
        {
            int magicnumber = 54;

            while(magicnumber > 0)
            {
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                if (num < magicnumber)
                {
                    Console.WriteLine("number is less than magicnumber plz try again");
                    continue;
                }
                else if (num > magicnumber)
                {
                    Console.WriteLine("number is greater plz try again");
                }
                else
                {
                    Console.WriteLine("congratulations number is match");
                    break;
                }
            }
        }
    }
}
