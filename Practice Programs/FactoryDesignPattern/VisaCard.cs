using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class VisaCard : ICardtype
    {
        public int GetAnnualChareges()
        {
            return 750;
        }

        public int GetCardLimit()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Visa Credit Card";
        }
    }
}
