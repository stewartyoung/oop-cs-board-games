using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class Tests_Chess
    {
        [TestMethod]
        public void Test_001()
        {
            // Model
            var moves = new List<string>();
            // View
            var printer = new BoardPrinter();
            // Controller
            var game = new Chess();
            var board = new Board();

            foreach (var move in moves)
            {
                game.Apply(move, board);

                printer.Show(board);
            }
        }
    }
}
