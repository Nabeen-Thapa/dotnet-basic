using System;
namespace Exam_pratices
{
    internal class lamda_expression
    {
        public delegate int lamdaEg(int n);
        public static void Main()
        {
            lamdaEg lamda = (n) => n+n;
            
            int res = lamda.Invoke(5);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
