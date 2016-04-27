using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._2
{
    class Program
    {
        public class Phone
        {
            private readonly string _code;
            private readonly string _number;

            public string Code
            {
                get { return _code; }
            }
            public string Number
            {
                get { return _number; }
            }
            public Phone(string number, string code)
            {
                _code = code;
                _number = number;
            }
            public void PrintNumber()
            {
                string outline = "";
                if (_code != "")
                {
                    outline += string.Format("({0})", _code);
                }
                outline += string.Format("{0}", _number);
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
