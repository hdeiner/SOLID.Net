using System;
using System.Collections.Generic;
using Xunit;

namespace SOLID.Net.SingleResponsibility_Good
{
    public class BoardTest
    {
        [Fact]
        public void testBoardHasASize() {
            Board board = new Board(3);
            Assert.Equal(3, board.size);
        }

        [Fact]
        public void testBoardSpotCountIsSquareOfSide() {
            Board board = new Board(3);
            Assert.Equal(9, board.spots.Count);
        }

        [Fact]
        public void testBoardReturnsValuesAtListOfSpots() {
            Board board = new Board(3);

            List<String> values = new List<String>();
            values.Add("0");
            values.Add("4");
            values.Add("7");

            List<int> indexes = new List<int>();
            indexes.Add(0);
            indexes.Add(4);
            indexes.Add(7);

            Assert.Equal(values, board.valuesAt(indexes));
        }

    }
}