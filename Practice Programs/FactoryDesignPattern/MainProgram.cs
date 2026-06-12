using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            ICardtype card = CardFactory.Getcard("Visa");
            if (card != null)
            {
                Console.WriteLine(card.GetCardType());
                Console.WriteLine(card.GetCardLimit());
                Console.WriteLine(card.GetAnnualChareges());
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }
           
            Console.ReadLine();
        }
    }
}
