using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
   public class generic_ex
    {
        public class generic<t>
        {
            t data;
            public generic() { }
            public generic(t data)
            {
                this.data = data;
            }
            public void display(t local)
            {
                Console.WriteLine("class property:" + data);
                Console.WriteLine("local data = " + local);
            }
        }
        public static void Main()
        {
            generic<int> data1 = new generic<int>(100);
            data1.display(60);
            generic<string> data2 = new generic<string>("pmc");
            data2.display("bca");
            Console.ReadKey();
        }
        
    }
}
