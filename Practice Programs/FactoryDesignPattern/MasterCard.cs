using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class MasterCard : ICardtype
    {
        public int GetAnnualChareges()
        {
            return 500;
        }

        public int GetCardLimit()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Master Credit Card";
        }
    }
}
