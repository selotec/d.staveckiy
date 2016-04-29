using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> inputedValues = new Dictionary<int, int>();
            int currentNumber;

            do
            {
                Console.WriteLine("Type number:");
                currentNumber = Convert.ToInt32(Console.ReadLine());
                if (currentNumber != -1)
                {
                    if (inputedValues.ContainsKey(currentNumber))
                    {
                        inputedValues[currentNumber]++;
                    }
                    else
                    {
                        inputedValues.Add(currentNumber, 1);
                    }
                }
            } while (currentNumber != -1);
            Console.WriteLine("Found duplicates:");
            foreach (KeyValuePair<int, int> kv in inputedValues)
            {
                if (kv.Value > 1)
                {
                    Console.WriteLine(string.Format("{0}", kv.Key));
                }
            }
        }
    }
}
