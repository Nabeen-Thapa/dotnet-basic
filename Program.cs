using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number:");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the secons number:");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("sum is : "+(a+b));
            Console.ReadKey();
        }
    }
   
}
