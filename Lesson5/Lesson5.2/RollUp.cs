using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class RollUp : Bill
    {
        public double InterestRate { set; get; }
        public double FirstIncome { set; get; }
        public RollUp(double interestRate, int id, string owner, double sum) : base(id, owner, sum)
        {
            FirstIncome = CurrentSum;
            InterestRate = interestRate;
        }

        public override bool AddToSum(double income)
        {
            if (income >= FirstIncome)
            {
                base.AddToSum(income);
                return true;
            }
            return false;
        }
        public override bool SubFromSum(double outcome)
        {
            if (outcome >= FirstIncome)
            {
                return base.SubFromSum(outcome);
            }
            return false;
        }
        public void InterestCapitalisation(int monthCount)
        {
            CurrentSum *= Math.Pow(1 + InterestRate, monthCount);
        }
    }
}
