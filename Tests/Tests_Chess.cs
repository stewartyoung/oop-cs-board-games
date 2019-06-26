using ChessMVC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class Tests_Chess
    {
        [TestMethod]
        public void Test_001()
        {
            //// Model
            //var moves = new List<string>();
            //// View
            //var printer = new BoardPrinter();
            //// Controller
            //var game = new Chess();
            //var board = new Board();

            //foreach (var move in moves)
            //{
            //    game.Apply(move, board);

            //    printer.Show(board);
            //}
        }
        [TestMethod]
        public void Test_002()
        {
            // Model
            var moves = new List<string>()
            {
                // White, Black
                "G1F3","G8F6",
                "C2C4", "G7G6",
                "B1C3", "F8G7",
                "D1D4", "E8G8", // castle
                "C1C4", "D7D5",
                "D1B3", "D5C4", // capture
                "B3C4", // capture, ...
            };


            // View
            var printer = new BoardPrinter();
            // Controller
            var game = new Chess();
            var board = new Board();

            //board.Move += (move) => Debug.WriteLine("");

            //game.Result += (result) => Debug.WriteLine("");
            //game.Capture += (piece, position) => Debug.WriteLine(""); 

            foreach (var move in moves)
            {
                game.Apply(move, board);

                printer.Show(board);
            }
        }

        private class BoardPrinter
        {
            internal void Show(Board board)
            {
                throw new NotImplementedException();
            }
        }
    }
}
