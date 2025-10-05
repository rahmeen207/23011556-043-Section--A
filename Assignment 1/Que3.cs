using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Que3
    {
        public void Run()
        {
            Console.WriteLine("Enter the marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 85)
            {
                Console.WriteLine("A");
            }
            else if (marks < 84 && marks >= 70)
            {
                Console.WriteLine("B");
            }
            else if (marks < 69 && marks >= 55)
            {
                Console.WriteLine("C");
            }
            else if (marks < 54 && marks >= 40)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
