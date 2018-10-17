using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SnakesAndLaddersGame;

namespace SnakesAndLaddersNavico.Test
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GivenGameStarted_WhenTokenPlacedOnBoard_ThenTokenIsOnSquareOne()
        {
            var unitUnderTest = new GameInstance(new Dice(), new PlayingToken(1), new Board(new Dictionary<int, MoveResult>()));
            Assert.AreEqual(1,unitUnderTest.GetCurrentSquarePlayingTokenIsOn());
        }

        [TestMethod]
        public void GivenTokenOnSquareNinetySeven_WhenTokenMovedThreeSpaces_ThenGameIsWon()
        {
            var loadedDice = new Mock<IDice>();
            loadedDice.Setup(dice => dice.Roll()).Returns(3);

            var unitUnderTest = new GameInstance(loadedDice.Object, new PlayingToken(97), new Board(new Dictionary<int, MoveResult>()));
            var result = unitUnderTest.Move();

            Assert.AreEqual(100, result.NewSquare);
            Assert.AreEqual(MoveResult.Status.Victory, result.MoveStatus);
            Assert.AreEqual(100, unitUnderTest.GetCurrentSquarePlayingTokenIsOn());
        }

        [TestMethod]
        public void GivenTokenOnSquareNinetySeven_WhenTokenMovedFourSpaces_ThenNotWonAndOnSquareNinetySeven()
        {
            var loadedDice = new Mock<IDice>();
            loadedDice.Setup(dice => dice.Roll()).Returns(4);

            var unitUnderTest = new GameInstance(loadedDice.Object, new PlayingToken(97), new Board(new Dictionary<int, MoveResult>()));
            var result = unitUnderTest.Move();

            Assert.AreEqual(97, result.NewSquare);
            Assert.AreEqual(MoveResult.Status.Rejected, result.MoveStatus);
            Assert.AreEqual(97, unitUnderTest.GetCurrentSquarePlayingTokenIsOn());
        }
    }
}
