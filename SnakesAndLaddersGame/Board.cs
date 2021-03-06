﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersGame
{
    public class Board : IBoard
    {
        private readonly IDictionary<int,MoveResult> _specialSquares;

        private readonly int lastSquare = 100;

        public Board(IDictionary<int, MoveResult> specialSquares)
        {
            _specialSquares = specialSquares;
            _specialSquares.Add(lastSquare, new MoveResult
            {
                Message = "You won",
                MoveStatus = MoveResult.Status.Victory,
                NewSquare = lastSquare
            });
        }

        public bool ValidateMove(int endingPosition)
        {
            return endingPosition <= lastSquare;
        }

        public MoveResult GetEffectOfSquare(int square)
        {
            if (_specialSquares.TryGetValue(square, out var result))
            {
                return result;
            }

            return new MoveResult
            {
                Message = "No special effects, landed successfully",
                MoveStatus = MoveResult.Status.StayedStill,
                NewSquare = square
            };
        }
    }
}
