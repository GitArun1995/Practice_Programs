using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public  class CardFactory
    {
        public static ICardtype Getcard(string card)
        {
            ICardtype cardType = null;
            if (card =="Visa")
            {
                 cardType = new VisaCard();
            }
            else if(card == "Master")
            {
                 cardType = new MasterCard();
            }
            return cardType;
        }
    }
}
