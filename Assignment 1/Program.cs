using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Que1 q1 = new Que1();
            q1.Run();
            Console.ReadLine();
            Que2 q2 = new Que2();
            q2.Run();
            Que3 que3 = new Que3();
            que3.Run();
            Que4 que4 = new Que4();
            que4.Run();
            Que5 que5 = new Que5();
            que5.Run();

        }
    }
}
