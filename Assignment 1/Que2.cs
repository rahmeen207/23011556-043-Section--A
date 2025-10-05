using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Que2
    {
        public void Run()
        {
            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a operator(+, - ,* ,/):");
            char op = Convert.ToChar(Console.ReadLine());
            switch (op) {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                   Console.WriteLine("invalid operator:");
                    break;
            }


        } 

    }
}
