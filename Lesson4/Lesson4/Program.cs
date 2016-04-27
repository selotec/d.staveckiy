using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        public class Phone
        {
            public readonly string city_code;
            public readonly string phone_number;
            public Phone(string number, string code)
            {
                city_code = code;
                phone_number = number;
            }
            public void PrintNumber()
            {
                string outline = "";
                if (city_code != "")
                {
                    outline += string.Format("({0})", city_code);
                }
                outline += string.Format("{0}", phone_number);
                Console.WriteLine("Formated number:");
                Console.WriteLine(outline);
            }
        }
        static void Main(string[] args)
        {
            string code = "";
            string number = "";
            Console.WriteLine("Type code:");
            code = Console.ReadLine();
            Console.WriteLine("Type number:");
            number = Console.ReadLine();
            Phone o = new Phone(number, code);
            o.PrintNumber();
        }
    }
}
