using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class delegate_calculate
    {
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }

        public delegate int calculator(int x, int y);

        public static void Main()
        {
            calculator cal = new calculator(sum);
            Console.WriteLine("addition = " + cal.Invoke(4, 5));
            Console.ReadKey();
        }
    }
}
