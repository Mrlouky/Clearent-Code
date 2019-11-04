using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clearent_Challenge
{
    public static class CardInterestCalculation
    {
        public static double CardCal(string Card)
        {
            double InterestRate;

            double Interest = 0;

            double Balance = CardInfo.Balance; 

            switch(Card)
            {
                case "Visa":

                    InterestRate = CardInfo.Visa;
            
                    Interest = InterestRate * Balance;
                    break;

                case "MC":

                    InterestRate = CardInfo.MC;

                    Interest = InterestRate * Balance;
                    break;

                case "Discover":

                    InterestRate = CardInfo.Discover;

                    Interest = InterestRate * Balance;
                    break;

                default:
                    Interest = 0;
                    break;
            }
            return Interest;
        }
    }
}
