using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class magicnum
    {
        static void Main(string[] args)
        {
            int magicnumber = 67;

                for(; ; )
            {
                Console.WriteLine("Enter the number");
                int num=int.Parse(Console.ReadLine());
                if(num<magicnumber)
                {
                    Console.WriteLine("number is less than magicnumber plz try again");
                    continue;
                }
                else if(num>magicnumber)
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
