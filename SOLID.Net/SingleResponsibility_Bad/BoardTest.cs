using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SOLID.Net.SingleResponsibility_Bad
{
    public class BoardTest
    {
        [Fact]
        public void testBoardHasNineSpots() {
            Board board = new Board();
            Assert.Equal(9, board.spots.Count);
        }

        [Fact]
        public void testBoardReturnsFirstRow() {
            Board board = new Board();
            List<String> rowOne = new List<String>();
            rowOne.Add("0");
            rowOne.Add("1");
            rowOne.Add("2");

            Assert.Equal(rowOne, board.firstRow());
        }

        [Fact]
        public void testBoardReturnsSecondRow() {
            Board board = new Board();
            List<String> rowTwo = new List<String>();
            rowTwo.Add("3");
            rowTwo.Add("4");
            rowTwo.Add("5");

            Assert.Equal(rowTwo, board.secondRow());
        }

        [Fact]
        public void testBoardReturnsThirdRow() {
            Board board = new Board();
            List<String> rowThree = new List<String>();
            rowThree.Add("6");
            rowThree.Add("7");
            rowThree.Add("8");

            Assert.Equal(rowThree, board.thirdRow());
        }

        [Fact]
        public void testPrintsBoardToConsole() {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
            Console.SetOut(sw);

            Board board = new Board();
            board.display();

            sw.Flush();
            
            Assert.Equal("0 | 1 | 2\n3 | 4 | 5\n6 | 7 | 8\r\n", Encoding.ASCII.GetString(ms.ToArray()));
        }

    }
}