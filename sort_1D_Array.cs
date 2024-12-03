using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class sort
    {
        public static void Main()
        {
            int[] arr = { 6, 4, 8, 9, 1, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                int min=i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i + "\t");
            }
            Console.ReadKey();
        }
    }
}
