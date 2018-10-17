using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersGame
{
    public class PlayingToken : IPlayingToken
    {
        // Private setter to prevent against modification outside of the move method.
        public int CurrentPosition { get; private set; } 
        public PlayingToken(int startingPosition)
        {
            CurrentPosition = startingPosition;
        }

        public int Move(int numberOfSpacesToMove)
        {
            CurrentPosition += numberOfSpacesToMove;
            return CurrentPosition;
        }
    }
}
