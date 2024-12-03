using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class array_sum
    {
        public static void Main()
        {
            int [,] arr = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
