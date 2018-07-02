using Xunit;

namespace SOLID.Net.SingleResponsibility_Good
{
    public class BoardPresenterTest
    {
        [Fact]
        public void testBoardPresenterPrintsBoardToConsole() {
            Board board = new Board(3);
            BoardPresenter presenter = new BoardPresenter(board);
            Assert.Equal("0|1|2\n3|4|5\n6|7|8\n", presenter.displayBoard());
        }

    }
}