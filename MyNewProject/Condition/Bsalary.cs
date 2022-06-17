using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Condition
{
    internal class Bsalary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter employee salary");
            float da, hra, gsal;
            float bsal = float.Parse(Console.ReadLine());
            if (bsal <= 10000)
            {
                da = bsal * 0.8f;
                hra = bsal * 0.2f;
            }
            else if (bsal <= 20000)
            {
                hra = bsal * 0.25f;
                da = bsal * 0.9f;
            }
            else
            {
                hra = bsal * 0.3f;
                da = bsal * 0.95f;
            }
            gsal = bsal + hra + da;
            Console.WriteLine("gross salary of emp      " + gsal);
        }
    }
    
}
