using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class generic_list
    {
        public static void Main()
        {
            List<string> data = new List<string>();
            data.Add("ram");
            data.Add("hari");
            Console.WriteLine("before remove");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            data.Remove("ram");
            Console.WriteLine("after remove");
            foreach(var newitem in data)
            {
                Console.WriteLine(newitem);
            }
            Console.ReadKey();
        }
    }
}
