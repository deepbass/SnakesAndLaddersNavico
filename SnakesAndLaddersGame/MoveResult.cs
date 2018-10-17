namespace SnakesAndLaddersGame
{
    public class MoveResult
    {
        public enum Status { Victory, Moved, StayedStill,
            Rejected
        }
        public int NewSquare { get; set; }

        public string Message { get; set; }

        public Status MoveStatus { get; set; }

    }
}