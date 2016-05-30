using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAbsoluteDifference
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
        
        static bool CheckAbsIncDiff(int[] arr)
        {
            bool result = true;
            int diff = Math.Abs(arr[1] - arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - arr[i-1]) >= diff && Math.Abs(arr[i] - arr[i - 1]) - diff <= 1)
                {
                    diff = Math.Abs(arr[i] - arr[i - 1]);
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;

        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            bool[] result = new bool[t];
            for (int i = 0; i < t; i++)
            {
                int[] arr = GetArray();
                result[i] = CheckAbsIncDiff(arr);
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine( result[i] ? "True" : "False");
            }

        }
    }
}
