using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class linq_eg
    {
        public static void Main()
        {
            int[] num = { 2, 5, 7, 8, 9, 13, 17, 1, 59 };  
            IEnumerable<int> result = from n in num where n > 10 select n;
            Console.WriteLine("result :");
            foreach (int n in result) Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
