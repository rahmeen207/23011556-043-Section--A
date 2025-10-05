using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Que5
    {
        public void Run()
        {
            Console.WriteLine("enter a number from 1 to 10:");
            int num =Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=10;i++)
            {
                Console.WriteLine(num + "*" + i + "=" + (num * i));
            }

        }
    }
}
