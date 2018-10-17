using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersGame
{
    public class GameInstance
    {
        private readonly IPlayingToken _playingToken;
        private readonly IBoard _board;
        private readonly IDice _dice;

        public GameInstance(IDice dice, IPlayingToken playingToken, IBoard board)
        {
            _playingToken = playingToken;
            _board = board;
            _dice = dice;
        }

        public int GetCurrentSquarePlayingTokenIsOn()
        {
            return _playingToken.CurrentPosition;
        }

        public MoveResult Move()
        {
            var squaresToMove = _dice.Roll();
            var attemptedMove = _board.AttemptMove(_playingToken.CurrentPosition,
                _playingToken.CurrentPosition + squaresToMove);
            if (attemptedMove.MoveStatus == MoveResult.Status.Rejected)
            {
                return attemptedMove;
            }
            var newPosition = _playingToken.Move(squaresToMove);

            var boardResult = _board.GetEffectOfSquare(newPosition);
            if (boardResult.MoveStatus == MoveResult.Status.Victory)
            {
                return boardResult;
            }
            return new MoveResult
            {
                Message = $"You moved {squaresToMove} squares to {newPosition}",
                MoveStatus = MoveResult.Status.Moved,
                NewSquare = newPosition
            };
        }
    }
}
