using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    internal class Arrayoutput
    {
        static void Main(string[] args)
        {
            int a1[], a2;
            a1 ={ 1,2,3}
            a2 = new string[a1.Length];
            for(int i=0;i<a1.Length;i++)
            {
                a2[]= a1[i];
            }
            for(int i=0;i<a2.Length();i++)
                Console.WriteLine(a2[i]);
        }
    }
}
