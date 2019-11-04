using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clearent_Challenge
{
   
   public static class ClearentTestCases
    {

        
        public static Double Case1()
        {
        
            double Visa_Interest;
            double MC_Interest;
            double Discover_Interest;
            double Wallet1_Interest;

            Visa_Interest = CardInterestCalculation.CardCal("Visa");
            MC_Interest = CardInterestCalculation.CardCal("MC");
            Discover_Interest = CardInterestCalculation.CardCal("Discover");

            Wallet1_Interest = Visa_Interest + MC_Interest + Discover_Interest;


            return Wallet1_Interest;
        }


        public static Double CaseWithCards(string card1, string card2, string card3)
        {

            double Card1_Interest;
            double Card2_Interest;
            double Card3_Interest;
            double Wallet_Interest;


            Card1_Interest = CardInterestCalculation.CardCal(card1);
            Card2_Interest = CardInterestCalculation.CardCal(card2);
            Card3_Interest = CardInterestCalculation.CardCal(card3);

            Wallet_Interest = Card1_Interest + Card2_Interest + Card3_Interest;


            return Wallet_Interest;
        }


    }
}
