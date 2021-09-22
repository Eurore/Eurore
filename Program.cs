using System;
//using System.Collections.Generic;
using System.Linq;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];

            for (int i = 0; i < n; i++)
            {
                long[] arrayRow = new long[i + 1];
                arrayRow[0] = 1;
                arrayRow[i] = 1; //arrayRow[arrayRow.Length - 1] = 1;

                for (int j = 1; j < i; j++)
                {
                    arrayRow[j] = pascalTriangle[i - 1][j] + pascalTriangle[i - 1][j - 1];
                }

                pascalTriangle[i] = arrayRow;
                Console.WriteLine(string.Join(" ", pascalTriangle[i]));
            }
        }
    }
}

/*using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;*/
//Stack<string> numbers = new Stack<string>(Console.ReadLine().Split().Reverse());
//while ((command = Console.ReadLine()) != "end")