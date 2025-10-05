using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Que4
    {
        public void Run()
        {
            int sum = 0;
            for(int i=0; i<=10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("sum of first 10 natural numbers is: " + sum);
            
        }
    }
}
