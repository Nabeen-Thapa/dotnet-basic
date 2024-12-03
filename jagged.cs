using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class jagged
    {
        public static void Main()
        {
            int[][] num = new int [3][] ;
            num [0] = new int[3] { 3, 4, 5 };
            num[1] = new int[2] { 3, 4 };
            num[2] = new int[4] { 4, 6, 7, 9 };
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    Console.Write(num[i][j] + " ");
                }
                Console.WriteLine("");

            }
            Console.ReadKey();

        }
    }
}
