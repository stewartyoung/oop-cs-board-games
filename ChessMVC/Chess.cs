﻿using System;

namespace ChessMVC
{
    public class Chess
    {
        public void Apply(string move, Board board)
        {
            var start = move.Substring(0, 2);
            // destination
            var dest = move.Substring(2, 2);

            board[dest[0], dest[1]] = board[start[0], start[1]];
            board[start[0], start[1]] = null;
        }
    }
}
