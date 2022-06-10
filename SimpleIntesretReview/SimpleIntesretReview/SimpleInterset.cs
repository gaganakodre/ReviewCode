using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIntesretReview
{
    internal class SimpleInterset
    {
        public void Calculate()
        {
            double SI = 0;
            Console.WriteLine("enter the percentage value:");
            double p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Time period:");
            double T = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Rate value:");
            double R = Convert.ToInt32(Console.ReadLine());
            SI = p * T * R / 100;
            Console.WriteLine("The simple interset:" + SI);



        }
    }
}
