using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Client bestClient = new Client();
            bestClient.AddBill(10, 123, "McDuck", 500000);
            bestClient.AddBill("Platinum", 2000, 300, 321, "McDuck", 100000);
            Console.WriteLine(bestClient.Total);
        }
    }
}
