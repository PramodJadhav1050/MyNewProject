using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{

    class Order_date
    {
        public int mm;
        public int dd;
        public int yy;

        public Order_date(int mm, int dd, int yy)
        {
            this.mm = mm;
            this.dd = dd;
            this.yy = yy;
        }
        public void show()
        {
            Console.WriteLine(mm+" "+dd+" "+yy+" ");
        }
    }
    class Order
    {
        int id;
        string name;
        string city;

        public Order(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        public void show()
        {
            Console.WriteLine(id+" "+name+" "+city+" ");
        }
    }
    class Shipment
    {
        int shipmentid;
        Order odr;
        Order_date od;


        public  Shipment(int shipmentid, Order odr, Order_date od)
        {
            this.shipmentid = shipmentid;
            this.odr = odr;
            this.od = od;
        }
        public void display()
        {
            Console.WriteLine(shipmentid);
            odr.show();
            od.show();
        }

        static void Main(string[] args)
        {

            Shipment s = new Shipment(4454, new Order ( 101, "Laptop", "Pune" ), new Order_date(12, 18, 22));
            s.display();
        }
    }
}
