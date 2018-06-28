using System;
using System.Collections.Generic;

namespace SOLID.Net.SingleResponsibility_Good
{
    public class Board
    {
        public int size;
        public List<String> spots;

        public Board(int size) {
            this.size = size;
            this.spots = new List<String>();
            for (int i = 0; i < size; i++) {
                this.spots.Add((3*i).ToString());
                this.spots.Add((3*i+1).ToString());
                this.spots.Add((3*i+2).ToString());
            }
        }

        public List<String> valuesAt(List<int> indexes) {
            List<String> values = new List<String>();

            foreach (int index in indexes) {
                values.Add(this.spots[index]);
            }

            return values;
        }

    }
}