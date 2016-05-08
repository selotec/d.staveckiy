using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    public abstract class BankClient
    {
        List<Bill> billsList;
        public BankClient(int billsLimit)
        {
            billsList = new List<Bill>(billsLimit);
        }
        public void AddBill(int id, string owner, double sum)
        {
            Bill savingBill = new Bill(id, owner, sum);
            billsList.Add(savingBill);
        }

        public void AddBill(List<Bill> billsList, double payment, int id, string owner, double sum)
        {
            Checking checkingBill = new Checking(payment, id, owner, sum);
            billsList.Add(checkingBill);
        }

        public void AddBill(List<Bill> billsList, string metalType, int grammCount, double grammPrice, int id, string owner, double sum)
        {
            Metal metalBill = new Metal(metalType, grammCount, grammPrice, id, owner, sum);
            billsList.Add(metalBill);
        }

        public void PrintBills()
        {
            foreach (Bill bill in billsList)
            {
                Console.WriteLine(string.Format("Bill id: {0} sum: {1}", bill.Id, bill.CurrentSum));
            }
        }

        public void CloseBill(int id)
        {
            for(int i=0; i < billsList.Count; i++)
            {
                if (billsList[i].Id == id)
                {
                    billsList.Remove(billsList[i]);
                }
            }
        }

        public Bill FindBill(int id)
        {
            for (int i = 0; i < billsList.Count; i++)
            {
                if (billsList[i].Id == id)
                {
                    return billsList[i];
                }
            }
            return null;
        }
    }
}
