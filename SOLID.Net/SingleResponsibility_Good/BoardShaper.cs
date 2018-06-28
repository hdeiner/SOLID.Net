using System.Collections.Generic;

namespace SOLID.Net.SingleResponsibility_Good
{
    public class BoardShaper
    {
        int size;

        public BoardShaper(int size) {
            this.size = size;
        }

        public List<List<int>> rowIndexes() {
            List<List<int>> rowIndexes = new List<List<int>>();

            for (int i = 0; i < this.size; i++) {
                List<int> row = new List<int>();
                for (int j = 0; j < this.size; j++) {
                    row.Add((i*size)+(j));
                }
                rowIndexes.Add(row);
            }

            return rowIndexes;
        }
    }
}