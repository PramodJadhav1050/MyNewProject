using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
   class SubBEngine
    {
        string cleanupDate;

        public string CleanupDate
        {
            get { return cleanupDate; }
            set { cleanupDate = value; }
        }
    }
    class BEngine
    {
        string type;
        SubBEngine sub;

        public string Type
        {
            get { return type; }
            set { type = value; }

        }
        public SubBEngine Sub
        {
            get { return sub; }
            set { sub = value; }
        }
    }
     class CarEn
    {
        int model;
        string name;
        int price;
        BEngine e;

        public int Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public BEngine E
        {
            get { return e; }
            set { e = value; }
        }

        static void Main(string[] args)
        {
            CarEn c= new CarEn();
            c.model = 456;
            c.name = "BMW";
            c.price = 8500000;
            c.E = new BEngine();
            c.E.Type = "Petrol";
            c.E.Sub = new SubBEngine();
            c.E.Sub.CleanupDate = "14/06/2022";

            Console.WriteLine(c.model+" "+c.name+" "+c.price+" "+c.E.Type+" "+c.E.Sub.CleanupDate+" ");
        }
    }
}
