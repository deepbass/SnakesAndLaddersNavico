using System;

namespace SnakesAndLaddersGame
{
    public class Dice : IDice
    {
        private readonly Random rnd = new Random();

        public int Roll()
        {
            return rnd.Next(1, 7);
        }
    }
}
