using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class generic_queue
    {
        public static void Main()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("first");
            q.Enqueue("second");
            q.Enqueue("third");
            q.Enqueue("fourth");
            q.Enqueue("fifth");

            Console.WriteLine();
            Console.WriteLine("after enque");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            q.Dequeue();
            Console.WriteLine("after dequeue");
            foreach(var newitem in q)
            {
                Console.WriteLine(newitem);
            }
            Console.WriteLine();
            Console.WriteLine("after peek");
            Console.WriteLine(q.Peek());  
            foreach (var newitem in q)
            {
                Console.WriteLine(newitem);
            }
            Console.ReadKey();
        }
    }
}
