using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        //syntax: <modifier> delegate delegateName <return type> (parameter list);
        public delegate int CalculatorDelegate (int a, int b);
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine("+,-,*,/");
            char input = Convert.ToChar( Console.ReadLine());
            switch (input)
            {
                case '+':
                    CalculatorDelegate add = c.Add;
                    Console.WriteLine(add(1, 2));
                    break;
                case '-':
                    CalculatorDelegate sub = c.Sub;
                    Console.WriteLine(sub(5,5));
                    break;
                case '*':
                    CalculatorDelegate mul = c.Mul;
                    Console.WriteLine(mul(8, 5));
                    break;
                case '/':
                    CalculatorDelegate div = c.Div;
                    Console.WriteLine(div(8, 5));
                    break;
            }

            Console.ReadLine();
        }
       
       
    }
}
