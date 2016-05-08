using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class RollUp : Bill
    {
        private double _interestRate;
        private double _firstIncome;
        public double InterestRate
        {
            get { return _interestRate; }
        }
        public double FirstIncome
        {
            get { return _firstIncome; }
        }
        public RollUp(double interestRate, int id, string owner, double sum) : base(id, owner, sum)
        {
            _firstIncome = CurrentSum;
            _interestRate = interestRate;
        }

        public override bool AddToSum(double income)
        {
            if (income > 0)
            {
                base.AddToSum(income);
                return true;
            }
            return false;
        }
        public override bool SubFromSum(double outcome)
        {
            if (CurrentSum - outcome >= FirstIncome)
            {
                return base.SubFromSum(outcome);
            }
            return false;
        }
        public bool InterestCapitalisation(int monthCount)
        {
            double current = CurrentSum;
            if (base.AddToSum(current * Math.Pow(1 + InterestRate, monthCount)))
            {
                return base.SubFromSum(current);
            }
            return false;
        }
    }
}
