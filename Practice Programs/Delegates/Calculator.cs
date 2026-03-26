using System;

namespace Delegates
{
    public class Calculator
    {
        private int _result;
        public int Add<T>(T a, T b)
        {
            if(a is int && b is int)
            {
                return _result = (int)(object)a + (int)(object)b;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return 0;
            }
        }
        public int Mul<T>(T a, T b)
        {
            if (a is int && b is int)
            {
                return _result = (int)(object)a * (int)(object)b;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return 0;
            }
        }
        public int Sub<T>(T a, T b)
        {
            if (a is int && b is int)
            {
                return _result = (int)(object)a - (int)(object)b;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return 0;
            }
        }
        public int Div<T>(T a, T b)
        {
            if (a is int && b is int)
            {
                if ((int)(object)b ==0)
                {
                    Console.WriteLine("Invalid input!");
                    return 0;
                }
                return _result = (int)(object)a / (int)(object)b;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return 0;
            }
        }
    }
}
