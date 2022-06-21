using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class PrimeSum
    {
        static void Main(string[] args)
		{ 
			int  j, p, sum = 0;
			int[] arr = new int[5];

			Console.Write("Enter array elements:");
			for ( int i = 0; i < arr.Length; i++)
			{
				arr[i] =int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < arr.Length; i++)
			{
	     		j = 2;
				p = 1;
				while (j < arr[i])
				{
					if (arr[i] % j == 0)
					{
						p = 0;
						break;
					}
					j++;
				}

				if (p == 1)
				{
					sum = sum + arr[i];
				}
			}
				Console.Write("Sum of prime numbers:" + sum);
			
		}
	}
    
}
