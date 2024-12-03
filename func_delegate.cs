using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class func_delegate
    {
        public static void Main()
        {
            Func<int, int, int, int> add= (a,b,c) =>(a+b+c);
            Console.WriteLine(add(3,4,5));
            Console.ReadKey();
        }
    }
}
