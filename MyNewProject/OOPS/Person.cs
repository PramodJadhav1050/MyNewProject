using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{       
        class Address
        {
            public int pincode;
            public string city;
            public int Pincode
            {
                get { return pincode; }
                set { pincode = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }
        }
        class Person
        {
            int id;
            string name;
            Address adr;
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public Address Adr
            {
                get { return adr; }
                set { adr = value; }
            }
            static void Main(string[] args)
            {
                Person p = new Person();
                p.Id = 1;
                p.Name = "Pramod";
                p.Adr = new Address();

                p.Adr.Pincode = 412411;
                p.Adr.City = "pune";
                Console.WriteLine(p.Id + " " + p.Name + " " + p.Adr.Pincode + " " + p.Adr.City);
            }
        }
    
}
