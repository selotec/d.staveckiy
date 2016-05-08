using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class Program
    {        
        static void Main(string[] args)
        {
            Metal Silver = new Metal("Silver", 1, 80.5, 123, "McDuck", 0);
            Silver.AddToSum(2);
            Console.WriteLine(string.Format("Current sum: {0}", Silver.CurrentSum));
        }
    }
}
