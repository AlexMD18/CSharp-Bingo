/*
* Alex Drogo
* CIS 3309
* Due: 2/05/2020
* Bingo - Internal Card Class
* This class keeps track of the state of the game. It will keep track of the numbers selected by the user and alert them when they
* get a bingo. The way we will keep track of this is by adding 1 to the count for the row, column or diagnal spaces until one of
* them equals 5. If one equals 5 we will know the user has gotten a bingo and the user will be alerted.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class InternalCardType2DimArray
    {
        private int[] rowCounts = new int[5];
        private int[] colCounts = new int[5];
        private int frwdDiag = 0;
        private int bkwdDiag = 0;


         //Constructor
        public InternalCardType2DimArray()
        {
            //Initialize the column 2, row 2 to 1 for the freespace
            rowCounts[2] = 1;
            colCounts[2] = 1;
            frwdDiag = 1;
            bkwdDiag = 1;
        }

        //This method checks for bingo for both forward and backwards diagnals. 
        public void recordSelectedSpace(int row, int col)
        {
            //if the row is equal to the column (0,0)(1,1) aka(\), then add one to the backwards diagnal integer. 
            if (row == col)
            {
                bkwdDiag++;
            }

            //if the row plus the column is equal to 4 (0,4)(1,3) aka(/), then add one to the foward diagnal integer. 
            if ((row + col) == 4)
            {
                frwdDiag++;
            }
        }

        //This method checks for bingo. If any of the integers or arrays above are equal to 5, this calls for the program to alert the user they have
        //bingo. Since this is used in an if statement in the form class, we can just increment the row and column counts by one every time the user
        //clicks on a box.
        public int isBingo(int row, int col)
        {
            rowCounts[row]++;

            colCounts[col]++;

            if (frwdDiag == 5 || bkwdDiag == 5 || rowCounts[row] == 5 || colCounts[col] == 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
