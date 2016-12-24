using System;

namespace ProblemSolving
{

    internal class SpiralMatrix : problem
    {

        public bool Solution()
        {
            int[,] array2D =
            {
                {1, 2, 3, 4, 5}, {6, 7, 8, 9, 10}, {11, 12, 13, 14, 15}, {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

            var rowCount = array2D.GetLength(0);
            var colCount = array2D.GetLength(1);

            var array = new int[rowCount * colCount];
            var rcount = rowCount - 1;
            var ccount = colCount - 1;

            var level = (int)Math.Ceiling((double)rowCount / 2);

            var index = 0;
            for (var lev = 0; lev <= level - 1; lev++)
            {
                for (var j = lev; j <= ccount - lev; j++)
                    array[index++] = array2D[lev, j];

                for (var k = lev + 1; k <= rcount - lev; k++)
                    array[index++] = array2D[k, ccount - lev];

                for (var l = ccount - 1 - lev; l >= lev; l--)
                    array[index++] = array2D[rcount - lev, l];

                for (var m = rcount - 1 - lev; m >= lev + 1; m--)
                    array[index++] = array2D[m, lev];
            }
            for (var d = 0; d < rowCount * colCount; d++)
                Console.Write(array[d] + "\n");


            return true;

        }
    }
}

