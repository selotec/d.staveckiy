using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Client
    {
        public int Identificator { get; set; }
        public string PhoneNumber { get; set; }
        public double OrderSum { get; set; }

        public Client(int id, string number, double sum)
        {
            Identificator = id;
            PhoneNumber = number;
            OrderSum = sum;
        }

        public string ReturnSum()
        {
            if (OrderSum % 1 == 0)
            {
                return string.Format("{0} р.", OrderSum);
            }
            else
            {
                double kopeck = Math.Truncate(OrderSum);
                return string.Format("{0} р. {1} коп.", kopeck, Convert.ToInt32((OrderSum - kopeck) * 100));
            }
        }
    }

    public class IP : Client
    {
        public string Fio { get; set; }
        public string BirthDate { get; set; }

        public IP(string fio, string date, int id, string number, double sum) : base(id, number, sum)
        {
            Fio = fio;
            BirthDate = date;
        }

        public string ReturnOrder()
        {
            return string.Format("Client: {0}, order sum: {1}", Fio, base.ReturnSum());
        }
    }

    public class OOO : Client
    {
        public string Name { get; set; }
        public string BillNumber { get; set; }

        public OOO(string name, string bill, int id, string number, double sum) : base(id, number, sum)
        {
            Name = name;
            BillNumber = bill;
        }

        public string ReturnOrder()
        {
            return string.Format("Client: {0}, order sum: {1}", Name, base.ReturnSum());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //In progress
            IP Ivanov = new IP("Ivanov", "12-22-3044", 1, "22-333-333", 32.11);
            OOO Gis4 = new OOO("4gis", "9990K-11", 2, "22-3332-22", 22.54);
            Console.WriteLine(Ivanov.ReturnSum());
            Console.WriteLine(Gis4.ReturnSum());
        }
    }
}
