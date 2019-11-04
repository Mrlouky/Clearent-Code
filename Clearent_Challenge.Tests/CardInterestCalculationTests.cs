using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clearent_Challenge;
using Xunit;

namespace Clearent_Challenge.Tests
{
    public class CardInterestCalculationTests
    {
        private Double Person1;
        private Double Person2;
        [Fact]

        // Testes the single Card Interest method
        public void CardCal_ShouldReturnCardInterest()
        {
            double expected = 1;

            double actual = CardInterestCalculation.CardCal("Discover");

            Assert.Equal(expected, actual);
        }


        [Fact] 
        
        //if return total interest = 16 then all the cards single interest values are correct
        public void Case1_ShouldReturnTotalCardInterest_All3Cards()
        {
          
            double expected = 16;

            double actual = ClearentTestCases.Case1();

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Visa","Discover",null)] //Wallet 1
        [InlineData("MC", null, null)] //Wallet 2
        [InlineData("Visa", "Discover", "MC")] //Total Interest for Person
        public void Case2_ShouldReturnWalletInterest(string Card1, string Card2, string Card3)
        {

            double expected = CardInterestCalculation.CardCal(Card1) + CardInterestCalculation.CardCal(Card2) + CardInterestCalculation.CardCal(Card3);

            double actual = ClearentTestCases.CaseWithCards(Card1,Card2,Card3);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("MC", "Visa", null)] //Person 1
        [InlineData("Visa", "MC", null)] //Person 2
      
        public void Case3_ShouldReturnWalletInterest(string Card1, string Card2, string Card3)
        {

            double expected = CardInterestCalculation.CardCal(Card1) + CardInterestCalculation.CardCal(Card2) + CardInterestCalculation.CardCal(Card3);

            double actual = ClearentTestCases.CaseWithCards(Card1, Card2, Card3);

            Assert.Equal(expected, actual);
        }
    }
}
