using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsPracticePrograms
{
    public class Number
    {
        public int _Number;
        public NumberDelegate _NumberDelegate;
        public Number(int num, NumberDelegate numDelegate)
        {
            _Number = num;
            _NumberDelegate = numDelegate;
        }
        public void Calculation()
        {
            int Result = 0;
            for(int i = 0; i < _Number; i++)
            {
                Result += i;
            }
            _NumberDelegate(Result);
        }
    }
}
