namespace SnakesAndLaddersGame
{
    public interface IPlayingToken
    {
        int Move(int numberOfSpacesToMove);
        int CurrentPosition { get; }
    }
}