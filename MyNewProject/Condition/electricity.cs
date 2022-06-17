using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Condition
{
    internal class electricity
    {
        static void Main(string[] args)
        {
            int custid, conu;
            double chg, subchg = 0, gramt, netamt;
            string connm;

            Console.Write("enter Customer ID:");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the name of the customer:");
            connm = Console.ReadLine();
            Console.WriteLine("enter the unit consumed by the customer:");
            conu = Convert.ToInt32(Console.ReadLine());
            if (conu < 50)

                chg = 0.50;
            else if (conu >= 50 && conu < 150)

                chg = 0.75;
            else if (conu >= 150 && conu < 250)

                chg = 1.20;
            else
                chg = 1.50;
            gramt = conu * chg;
            if (gramt > 250)
                subchg = gramt * 20/100;
            netamt = gramt + subchg;
            if (netamt < 100)

                netamt = 100;
            Console.WriteLine("Customer IDNO:"    + custid);
            Console.WriteLine("Customer Name:"    + connm);
            Console.WriteLine("unit Consumed:"    + conu);
            Console.WriteLine("Amount Charges @Rs. {0}  per unit:" + chg, gramt);
            Console.WriteLine("Subcharge Amount:"  + subchg);
            Console.WriteLine("Net Amount Paid By the Customer:" + netamt);
        }
    }
} 

    

