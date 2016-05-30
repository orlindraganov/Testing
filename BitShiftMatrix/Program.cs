using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoshoSeUmaza
{
    class Program
    {

        static int[] GetArray()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s)).ToArray();
            return arr;
        }

        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            int numberOfMoves = int.Parse(Console.ReadLine());
            int[] moves = new int[numberOfMoves];
            moves = GetArray();
            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = (int)Math.Pow(2, j + rows - 1 - i);
                }
            }
            int sum = 0;
            int coef = Math.Max(rows, cols);
            int[] pawnPos = new int[] { 0, rows - 1 };

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < numberOfMoves; i++)
            {
                while (pawnPos[0] != moves[i] % coef)
                {
                    sum += matrix[pawnPos[1], pawnPos[0]];
                    matrix[pawnPos[1], pawnPos[0]] = 0;
                    if (pawnPos[0] < moves[i] % coef)
                    {
                        pawnPos[0]++;
                    }
                    else
                    {
                        pawnPos[0]--;
                    }

                    //Console.WriteLine(pawnPos[1] + " " + pawnPos[0]);
                    //Console.WriteLine(matrix[pawnPos[1], pawnPos[0]]);

                }
                while (pawnPos[1] != moves[i] / coef)
                {
                    sum += matrix[pawnPos[1], pawnPos[0]];
                    matrix[pawnPos[1], pawnPos[0]] = 0;
                    if (pawnPos[1] < moves[i] / coef)
                    {
                        pawnPos[1]++;
                    }
                    else
                    {
                        pawnPos[1]--;
                    }
                    //Console.WriteLine(pawnPos[1] + " " + pawnPos[0]);
                    //Console.WriteLine(matrix[pawnPos[1], pawnPos[0]]);
                }
            }
            sum += matrix[pawnPos[1], pawnPos[0]];

            Console.WriteLine(sum);
        }
    }
}
