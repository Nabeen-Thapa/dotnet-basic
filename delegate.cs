using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class delegateEx
    {
        public static int square(int n)
        {
            return n * n;
        }
        public static int cube(int n)
        {
            return n * n * n;
        }
        public delegate int multidelegate(int n);

        public static void Main()
        {
            multidelegate del = new multidelegate(square);
            Console.WriteLine("square :" + del.Invoke(5));
            del += cube;
            Console.WriteLine("cube :" + del.Invoke(5));
            Console.ReadKey();
        }
    }
}
