using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class armstrong
    {
       public static void Main()
        {
            Console.Write("enter the 4 digits :");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int res = 0;
            if(num > 0)
            {
                int div = num % 10;
                 res = (res * 10) + div;
                num /= 10;
            }
            if(res == temp)
            {
                Console.WriteLine("number is arnstring");

            }else
            {
                Console.WriteLine("not armstrong");
            }
            Console.ReadKey();

        }
    }
}
