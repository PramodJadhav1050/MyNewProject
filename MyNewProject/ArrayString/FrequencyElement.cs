using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class FrequencyElement
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 1, 3, 1, 5, 1, 4 };
           /* Console.WriteLine("Enter Element");
            int num=int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (num == a[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Occurance of" +num+ "given no=" +count);*/

            for(int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited== false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if (a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+ " " +count);
                }
            }
        }
    }
}
