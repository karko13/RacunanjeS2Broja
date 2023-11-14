using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi 1. broj");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisi 2. broj");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = Math.Abs(x); 
            int b = Math.Abs(y);
            int temp = 0;
            while(b != 0)
            {
                temp = b;
                b = a%b;
                a = temp;

            }
            Console.WriteLine("najveci broj je " + x + " and " + y + " a djeljivo je sa " + a);
            Console.ReadKey();
        }
    }
}
