﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class evnno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers=");
            for ( int i = 121; i <=229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
