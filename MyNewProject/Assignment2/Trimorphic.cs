using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class Trimorphic
    {
        static void Main(string[] args)
        {
            int num = 4;
            int count = 0;
            int temp = num;
            while (num > 0)
            {

                count++;
                num = num / 10;
            }
            // Console.WriteLine(count);
            num = temp;
            int cube = num * num * num ;
            int power = 1;
            for (int i = 1; i <= count; i++)
            {
                power = power * 10;
            }

            //Console.WriteLine(sq+" " +power);
            int end = cube % power;

            Console.WriteLine(cube + " " + "end=" + end);
            if (end == num)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }
        }
    }
}
