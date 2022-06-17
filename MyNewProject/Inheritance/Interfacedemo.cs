using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    public interface IAddition
    {
        static int a = 4;
    }
    abstract class Addition
    {
        public static int b = 7;
    }
    class Addn : Addition, IAddition
    {

        public void addn()
        {
            Console.WriteLine("addition     " + (IAddition.a + Addition.b));
        }



    }
    class Interfacedemo
    {
        static void Main(string[] args)
        {
            Addn a = new Addn();
            a.addn();

        }
    }
}
