using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class Car
    {
        int Modelno;
        string name;
        string colour;
        int price;

        static void Main(string[] args)
        {
             Car car = new Car();
            car.Modelno = 1343;
            car.name = "maruti";
            car.colour = "white";
            car.price = 500000;

            Console.WriteLine(car.Modelno+" "+car.name+" "+car.colour+" "+car.price);

            car.Modelno =1232;
            car.name = "swift";
            car.colour = "red";
            car.price = 700000;

            Console.WriteLine(car.Modelno + " " + car.name + " " + car.colour + " " + car.price);

            car.Modelno = 1567;
            car.name = "Fortuner";
            car.colour = "black";
            car.price = 2800000;

            Console.WriteLine(car.Modelno + " " + car.name + " " + car.colour + " " + car.price);
        }
    }
}
