using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class linq_pratice
    {
        public static void Main()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };
            var res = num.Skip(3);
            Console.WriteLine(string.Join (", " ,res));
            //foreach (var nu in res)
            //{
            //    Console.Write(nu + ", ");
            //}
            //Console.WriteLine();
            var res1 = num.TakeWhile(x => x <=5); 
            Console.WriteLine(string.Join(", ", res1));
            var person = new List<(string name, int age)>
            {
                ("ram", 1),
                ("hari", 2),
                ("rama", 3)

            };
            var res2 = person.GroupBy(p => p.age);
            foreach (var group in res2)
            {
                Console.Write(group.Key + " = ");
                    {
                    foreach (var name in group)
                    {
                        Console.Write(name.name);
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
