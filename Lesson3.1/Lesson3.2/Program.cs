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
            char userCharacter;
            int occurencesCount = 0;
            Dictionary<char, int> userDict = new Dictionary<char, int>();

            Console.WriteLine("Type string:");
            userString = Console.ReadLine();
            Console.WriteLine("Type key character:");
            userCharacter = Convert.ToChar(Console.ReadLine());
            while (!userString.Contains(userCharacter))
            {
                Console.WriteLine("Your string must contain your character! Type correct character:");
                userCharacter = Convert.ToChar(Console.ReadLine());
            }
            foreach (char currentChar in userString)
            {
                if (currentChar.Equals(userCharacter))
                {
                    occurencesCount++;
                }
            }
            userDict.Add(userCharacter, occurencesCount);
            foreach (KeyValuePair<char, int> kv in userDict)
            {
                Console.WriteLine(string.Format("Dict key: {0}, value: {1}", kv.Key, kv.Value));
            }            
       }
    }
}
