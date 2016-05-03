using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString;
            int occurencesCount = 0;
            Dictionary<char, int> userDict = new Dictionary<char, int>();

            Console.WriteLine("Type string:");
            userString = Console.ReadLine();
            foreach (char currentChar in userString)
            {
                if (userDict.ContainsKey(currentChar))
                {
                    userDict[currentChar]++;
                }
                else
                {
                    userDict.Add(currentChar, 1);
                }
            }
            foreach (KeyValuePair<char, int> kv in userDict)
            {
                Console.WriteLine(string.Format("Dict key: {0}, value: {1}", kv.Key, kv.Value));
            }            
       }
    }
}
