using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab2
{
    internal class _2_positive_sum
    {
        public static void Main(string[] args)
        { 
            
            while(true)
            {
               
                Console.WriteLine("enter the number");
                   int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("negative number");
                    break;
                }
                int sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum += i;
                }
                Console.WriteLine("sum is: " + sum);

            }
           
            Console.ReadKey();  
        }
    }
}
