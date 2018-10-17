namespace SnakesAndLaddersGame
{
    public interface IBoard
    {
        MoveResult GetEffectOfSquare(int square);

        MoveResult AttemptMove(int startingPosition, int endingPosition);
    }
}