using System;
using System.IO;
using Xunit;

namespace SOLID.Net.SingleResponsibility_Good
{
    public class BoardPresenterTest
    {
        [Fact]
        public void testBoardPresenterPrintsBoardToConsole() {
            Board board = new Board(3);

            StreamWriter sw = new StreamWriter(new FileStream("tmp.txt", FileMode.Create));
            Console.SetOut(sw);

            BoardPresenter presenter = new BoardPresenter(board);
            presenter.displayBoard();

            sw.Flush();
            sw.Close();

            Assert.Equal("0|1|2\n3|4|5\n6|7|8\n\n", File.ReadAllText("tmp.txt"));
        }

    }
}