using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_pratices
{
    internal class event_stosk_price
    {
        public class person
        {
            public void callme(string name, decimal oldprice, decimal newprice)
            {
                Console.WriteLine("the stock price of {0} changed from {1} to {2} ", name, oldprice, newprice);
            }
        }
        public delegate void priceChanged(string n, decimal op, decimal np);
        public class StockTicker
        {
            public event priceChanged pc;
            public string name { get; set; }
            private decimal price;
            public decimal Price
            {
                get { return price; }
                set
                {
                    var oldprice = price;
                    price = value;
                    if (pc != null)
                    {
                        pc(name, oldprice, price);
                    }
                }
            }
        }
       static void Main()
        {
            var pn = new person();
            var nabil = new StockTicker { name = "nabil bank", Price = 1234 };
            nabil.pc += new priceChanged(pn.callme);
            nabil.Price =1600 ;
            nabil.Price = 1700;
            nabil.Price = 1400;
            Console.ReadKey();
        }
    }
}
