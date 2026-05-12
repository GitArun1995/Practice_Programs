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
        public delegate void ActionDelegate();
        static void Main(string[] args)
        {
            Run(Print);
            Run(Display);
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
       static void Run(ActionDelegate actionDelegate)
        {
            Console.WriteLine("Passing Delegate as a parameter");
            actionDelegate();
        }
        static void Print() => Console.WriteLine("This is print method");
        static void Display() => Console.WriteLine("This is display method");
    }
}
