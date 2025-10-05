using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Que1
    {
        public void Run()
        {
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine(num + " is even ");
            }
            else
            {
                Console.WriteLine(num + " is odd ");
            }
        }
    }
}
