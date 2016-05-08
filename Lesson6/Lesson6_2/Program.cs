using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            VIPClient McDuck = new VIPClient();
            CasualClient Donald = new CasualClient();
            Bank DuckBank = new Bank();
            Donald.AddBill(11, "Donald", 50);
            McDuck.AddBill(22, "McDuck", 100000);
            Donald.PrintBills();
            McDuck.PrintBills();
            DuckBank.Transfer(Donald.FindBill(11), McDuck.FindBill(22));
            Donald.CloseBill(22);
            Donald.PrintBills();
            McDuck.PrintBills();
        }
    }
}
