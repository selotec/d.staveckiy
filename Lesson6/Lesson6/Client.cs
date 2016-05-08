using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Client
    {
        public List<Bill> bills = new List<Bill>();
        private double _total;

        public void AddBill(int id, string owner, double sum)
        {
            Bill savingBill = new Bill(id, owner, sum);
            bills.Add(savingBill);
        }

        public void AddBill(double payment, int id, string owner, double sum)
        {
            Checking checkingBill = new Checking(payment, id, owner, sum);
            bills.Add(checkingBill);
        }

        public void AddBill(string metalType, int grammCount, double grammPrice, int id, string owner, double sum)
        {
            Metal metalBill = new Metal(metalType, grammCount, grammPrice, id, owner, sum);
            bills.Add(metalBill);
        }
        public double Total
        {
            get
            {
                double total = 0;
                for(int i=0; i < bills.Count; i++)
                {
                    total += bills[i].CurrentSum;
                }
                return total;
            }
        }
    }
}
