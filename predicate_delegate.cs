using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class predicate_delegate
    {
        public static void Main()
        {
            Predicate<int> isEven = (num) => num % 2 == 0;
            Console.WriteLine(isEven(5));
            Console.ReadKey();
        }
    }
}
