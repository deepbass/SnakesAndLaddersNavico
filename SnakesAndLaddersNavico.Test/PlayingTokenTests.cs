using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLaddersGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersNavico.Test
{
    [TestClass]
    public class PlayingTokenTests
    {
        [TestMethod]
        public void GivenTokenOnSquareOne_WhenMovedThree_TokenOnSquareFour()
        {
            var unitUnderTest = new PlayingToken(1);
            var resultFromMethod = unitUnderTest.Move(3);
            Assert.AreEqual(4, resultFromMethod);
            Assert.AreEqual(4, unitUnderTest.CurrentPosition);
        }

        [TestMethod]
        public void GivenTokenOnSquareOne_WhenMovedThreeThenMovedFour_TokenOnSquareEight()
        {
            var unitUnderTest = new PlayingToken(1);
            unitUnderTest.Move(3);
            var resultFromMethod = unitUnderTest.Move(4);

            Assert.AreEqual(8, resultFromMethod);
            Assert.AreEqual(8, unitUnderTest.CurrentPosition);
        }
    }
}
