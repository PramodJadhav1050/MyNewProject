﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class evensqodd
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
                else if (i % 2 == 1)
                {
                    Console.WriteLine(i * i);

                }
                i++;
            }
        }
    }
    
}
