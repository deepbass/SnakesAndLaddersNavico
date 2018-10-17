using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLaddersGame;

namespace SnakesAndLaddersNavico.Test
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void GivenBoardWithoutExtraSpecialSquares_WhenUserValidatesMoveFromOneToTwo_ThenSuccess()
        {
            var unitUnderTest = new Board(new Dictionary<int, MoveResult>());
            var result = unitUnderTest.ValidateMove(2);
            Assert.AreEqual(true,result);
        }

        [TestMethod]
        public void GivenBoardWithoutExtraSpecialSquares_WhenUserValidatesMoveFromOneToFifty_ThenSuccess()
        {
            var unitUnderTest = new Board(new Dictionary<int, MoveResult>());
            var result = unitUnderTest.ValidateMove(50);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenBoardWithoutExtraSpecialSquares_WhenUserValidatesMoveFromOneToHundred_ThenWin()
        {
            var unitUnderTest = new Board(new Dictionary<int, MoveResult>());
            var result = unitUnderTest.ValidateMove(100);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenBoardWithoutExtraSpecialSquares_WhenUserValidatesMoveFromNinetyNineToHundredAndOne_ThenWin()
        {
            var unitUnderTest = new Board(new Dictionary<int, MoveResult>());
            var result = unitUnderTest.ValidateMove(101);
            Assert.AreEqual(false, result);

        }
    }
}
