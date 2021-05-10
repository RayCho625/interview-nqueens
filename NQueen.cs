using System;
using System.Collections.Generic;
using System.Text;

namespace NQueenQuestion
{
    public class NQueen
    {
        public List<List<string>> solveNQueens(int n)
        {
            List<List<string>> result = new List<List<string>>();
            int[] queenList = new int[n]; //mean Q's position at row index, ex: queenList[0] = 0 => Q is in row 0 position 0, queenList[2] = 3 => Q is in row 2 position 3, also mean Q's positon is in queenList[2][3] 
            placeQueen(queenList, 0, n, result);//init : first row of Q's position
            return result;
        }
        private void placeQueen(int[] queenList, int row, int n, List<List<string>> result)
        {
            //while finish all row scan, then fill up "Q" into it's position, others fill up "." and add to result list
            if (row == n)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int col = 0; col < n; col++)
                    {
                        if (queenList[i] == col)
                        {
                            sb.Append("Q");
                        }
                        else
                        {
                            sb.Append(".");
                        }
                    }
                    list.Add(sb.ToString());
                }
                result.Add(list);
            }
            for (int col = 0; col < n; col++)
            {
                if (isValid(queenList, row, col))//check Q's position
                { 
                    queenList[row] = col;
                    placeQueen(queenList, row + 1, n, result);
                }
            }
        }

        private bool isValid(int[] queenList, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                int pos = queenList[i];
                if (pos == col) //in same column
                {
                    return false;
                }
                if (pos + row - i == col) // at right corner
                {
                    return false;
                }
                if (pos - row + i == col) // at left corner
                {
                    return false;
                }
            }
            return true;
        }
    }
}
