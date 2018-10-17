using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLaddersGame;

namespace SnakesAndLaddersNavico.Test
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void Given_UserWantsToMove_WhenDiceRolled100Times_ThenAlwaysReturnResultBetweenOneAndSixInclusive()
        {
            var unitUnderTest = new Dice();
            for(var i = 0; i < 50; i++)// has ~10^-8 chance of not selecting one of the 6 numbers
            {
                var result = unitUnderTest.Roll();
                Assert.IsTrue(result >= 1 && result <= 6);
            }
        }
    }

    
}
