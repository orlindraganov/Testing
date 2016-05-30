using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;

namespace GoshoMazhe
{
    class Program
    {

        //Dictionary requires System.Collections.Generic
        //BigInteger requires System.Numerics


        static int ConvertCatToDec(string cat)
        {
            int dec = 0;
            foreach (char digit in cat)
            {
                dec = catdecval[digit] + dec * 23;
            }
            return dec;
        }

        static Dictionary<char, int> catdecval = new Dictionary<char, int>
     {
        {'a', 0},
        {'b', 1},
        {'c', 2},
        {'d', 3},
        {'e', 4},
        {'f', 5},
        {'g', 6},
        {'h', 7},
        {'i', 8},
        {'j', 9},
        {'k', 10},
        {'l', 11},
        {'m', 12},
        {'n', 13},
        {'o', 14},
        {'p', 15},
        {'q', 16},
        {'r', 17},
        {'s', 18},
        {'t', 19},
        {'u', 20},
        {'v', 21},
        {'w', 22},
    };

        //Dictionary requires System.Collections.Generic
        //BigInteger requires System.Numerics
        //StringBuilder requires System.Text

        static string ConvertDecToCat(BigInteger dec)
        {
            StringBuilder cat = new StringBuilder();
            do
            {
                cat.Insert(0, deccatval[(int)(dec % 23)]);
                dec = dec / 23;
            }
            while (dec != 0);
            return cat.ToString();
        }

        static Dictionary<int, char> deccatval = new Dictionary<int, char>{
        {0, 'a'},
        {1, 'b'},
        {2, 'c'},
        {3, 'd'},
        {4, 'e'},
        {5, 'f'},
        {6, 'g'},
        {7, 'h'},
        {8, 'i'},
        {9, 'j'},
        {10, 'k'},
        {11, 'l'},
        {12, 'm'},
        {13, 'n'},
        {14, 'o'},
        {15, 'p'},
        {16, 'q'},
        {17, 'r'},
        {18, 's'},
        {19, 't'},
        {20, 'u'},
        {21, 'v'},
        {22, 'w'},
    };


        static void Main(string[] args)
        {
            string[] catNums = Console.ReadLine().Split(' ').ToArray();
            int sum = 0;
            for (int i = 0; i < catNums.Length; i++)
            {
                sum += ConvertCatToDec(catNums[i]);
            }
            string catSum = ConvertDecToCat(sum);
            Console.WriteLine(catSum + " = " + sum);
        }
    }
}
