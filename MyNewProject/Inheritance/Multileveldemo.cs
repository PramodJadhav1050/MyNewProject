using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{

    class car
    {
        public string model;
        public string color;
        public int price;

        public void PrintcarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:"+color);
            Console.WriteLine("Price:" +price);
        }
    }
    class ferrari:car
    {
        public int speed;

        public void PrintSpeed()
        {
            Console.WriteLine("Speed:" +speed);
        }
    }
     class maruti : ferrari
    {
      public  float mileage;
        
       public void PrintMileage()
        {
            Console.WriteLine("Mileage:" +mileage);
        }
    }
    internal class Multileveldemo
    {
        static void Main(string[] args)
        {
            maruti myCar = new maruti();
            myCar.model = "Alto";
            myCar.color = "White";
            myCar.price = 45000;
            myCar.speed = 100;
            myCar.mileage = 23.5f;
            myCar.PrintcarInformation();
            myCar.PrintSpeed();
            myCar.PrintMileage();

        }
    }
}
