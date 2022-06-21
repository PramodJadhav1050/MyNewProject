using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    internal class Countevenodd
    {
        static void Main()
        {
            int[] arr = new int[10];
            int i, num, evennum, oddnum;
            Console.WriteLine("Enter size of the array: ");
            num =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter " + num + " elements in the array: ");

            for (i = 0; i < num; i++)
            {
                arr[i] =int.Parse(Console.ReadLine());
            }

            evennum = 0;
            oddnum = 0;

            for (i = 0; i < num; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++;
                }
            }

            Console.WriteLine("Total even  numbers: " + evennum);
            Console.WriteLine("Total odd numbers: " + oddnum);

        }
    }
}
