namespace SnakesAndLaddersGame
{
    public interface IBoard
    {
        MoveResult GetEffectOfSquare(int square);

        bool ValidateMove(int endingPosition);
    }
}