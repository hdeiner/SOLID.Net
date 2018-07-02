using System;
using System.Collections.Generic;

namespace SOLID.Net.SingleResponsibility_Bad
{
    public class Board
    {
        public List<String> spots;

        public Board() {
            this.spots = new List<String>();
            for (int i = 0; i < 9; i++) {
                this.spots.Add(i.ToString());
            }
        }

        public List<String> firstRow() {
            List<String> firstRow = new List<String>();
            firstRow.Add(this.spots[0]);
            firstRow.Add(this.spots[1]);
            firstRow.Add(this.spots[2]);
            return firstRow;
        }

        public List<String> secondRow() {
            List<String> secondRow = new List<String>();
            secondRow.Add(this.spots[3]);
            secondRow.Add(this.spots[4]);
            secondRow.Add(this.spots[5]);
            return secondRow;
        }

        public List<String> thirdRow() {
            List<String> thirdRow = new List<String>();
            thirdRow.Add(this.spots[6]);
            thirdRow.Add(this.spots[7]);
            thirdRow.Add(this.spots[8]);
            return thirdRow;
        }

        public String display() {
            return this.spots[0] + " | " + this.spots[1] + " | " + this.spots[2] + "\n" + this.spots[3] + " | " + this.spots[4] + " | " + this.spots[5] + "\n" + this.spots[6] + " | " + this.spots[7] + " | " + this.spots[8];
        } 
        
    }
}