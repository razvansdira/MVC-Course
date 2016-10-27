using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class FizBuz
    {
        public static string ShowFizBuz(int b)
        {

            if (b % 15 == 0)
            {
                return "FizBuz";
            }
            else if (b % 5 == 0)
            {
                return "Buz";
            }
            else if (b % 3 == 0)
            {
                return "Fiz";
            }
            else
            {
                return "" + b;
            }
        }
    }
}