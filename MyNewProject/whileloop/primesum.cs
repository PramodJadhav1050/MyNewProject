using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class primesum
    {
        static void Main(string[] args)
        {
            int count, sum = 0;

            for(int i=1;i<=10;i++)
            {
                count = 0;
                for(int j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        count++;
                        break;
                    }
                }
                if(count==0 && i !=1)
                {
                    sum=sum+i;
                }
            }
            Console.WriteLine("the sum of prime numbers from 1 to 10 is:" +sum);
        }
    }
}
