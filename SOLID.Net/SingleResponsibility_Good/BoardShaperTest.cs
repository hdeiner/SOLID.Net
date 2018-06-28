using System.Collections.Generic;
using Xunit;

namespace SOLID.Net.SingleResponsibility_Good
{
    public class BoardShaperTest
    {
        [Fact]
        public void testItReturnsRowIndexes() {
            BoardShaper shaper = new BoardShaper(2);
            List<List<int>> rowIndexes = new List<List<int>>();
            List<int> rowOne = new List<int>();
            List<int> rowTwo = new List<int>();
            rowOne.Add(0);
            rowOne.Add(1);
            rowTwo.Add(2);
            rowTwo.Add(3);
            rowIndexes.Add(rowOne);
            rowIndexes.Add(rowTwo);

            Assert.Equal(rowIndexes, shaper.rowIndexes());
        }

    }
}