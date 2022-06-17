using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class Shopping
    {
        public string item;
        public int price;
        public int quantity;
        int total;
        public void AcceptDetails(string puritem, int Price, int quan)
        {
            item = puritem;
            price = Price;
            quantity = quan;
        }
        public void GetBill()
        {
            total = price * quantity;
            if (quantity > 0)
            {
                Console.WriteLine("total price   " + total);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        public void Show()
        {
            Console.WriteLine("Purchase item Name=   " + item);
            Console.WriteLine("Price Item=  " + price);
            Console.WriteLine("Quantity=    " + quantity);
            Console.WriteLine("Total Bill=  " + total);
        }
        static void Main(string[] args)
        {
            Shopping c = new Shopping();
            c.AcceptDetails("bike",95000,2);
            c.GetBill();
            c.Show();

        }
    }
}
    

