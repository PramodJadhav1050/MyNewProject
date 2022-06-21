using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    internal class Buzz
    {
        static void Main(string[] args)
        {
            int countbuzz = 0;
            int countfizz = 0;
            int countbuzzfizz = 0;
            for(int i=1;i<=50;i++)
            {
                if(i%3==0&& i%5==0)
                {
                    Console.WriteLine("BuzzFizz");
                    countbuzzfizz++;
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine( "Buzz");
                    countbuzz++;
                }
            }
        }
    }
}
