using System;
using System.Text;
using Xunit;

namespace SOLID.Net.SingleResponsibility_Good
{
    public class BoardPresenterTest
    {
        [Fact]
        public void testBoardPresenterPrintsBoardToConsole() {
            Board board = new Board(3);

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
            Console.SetOut(sw);

            BoardPresenter presenter = new BoardPresenter(board);
            presenter.displayBoard();

            sw.Flush();

            Assert.Equal("0|1|2\n3|4|5\n6|7|8\n\n", Encoding.ASCII.GetString(ms.ToArray()).Replace("\r",""));
        }

    }
}