using System;
using System.Threading;

namespace ThreadsPracticePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //NumberDelegate numDelegate = new NumberDelegate(Display);
            //Number num = new Number(5,numDelegate);
            //Thread t = new Thread(new ThreadStart(num.Calculation));
            //t.Start();
            Program p = new Program();
            //Thread t = new Thread(p.ContinuosThread) { Name = "Sub Thread" };
            //t.Start();
            p.ContinuosThread();
            //Console.WriteLine($"{t.Name} Startedd");
            Console.ReadLine();
        }
        public static void Display(int num)
        {
            Console.WriteLine("Result =" + num);
        }
        public  void ContinuosThread()
        {
            
            while (true)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} Started");
                Thread.Sleep(10000);
            }
            
        }
    }
}
