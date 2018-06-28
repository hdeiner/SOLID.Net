using System;

namespace SOLID.Net.SingleResponsibility_Good
{
    public class BoardPresenter
    {
        Board board;

        public BoardPresenter(Board board) {
            this.board = board;
        }

        public void displayBoard() {
            String formattedBoard = "";
            for (int i = 0; i < this.board.size*this.board.size; i++) {
                String borderOrNewline = "";
                if ((i+1) % board.size == 0) {
                    borderOrNewline += "\n";
                }
                else {
                    borderOrNewline += "|";
                }
                formattedBoard += board.spots[i];
                formattedBoard += borderOrNewline;
            }
            Console.WriteLine(formattedBoard);
        }
    }
}