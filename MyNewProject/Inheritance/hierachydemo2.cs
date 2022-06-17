using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Car
    {
        public string model;
        public string color;
        public int price;

        public void PrintcarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }
    }
    class Ferrari : Car
    {
        public int speed;

        public void PrintSpeed()
        {
            Console.WriteLine("Speed:" + speed);
        }
    }
    class Maruti : car
    {
        public float mileage;

        public void PrintMileage()
        {
            Console.WriteLine("Mileage:" + mileage);
        }
    }

    internal class hierachydemo2

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


