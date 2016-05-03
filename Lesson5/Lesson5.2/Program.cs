using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class Program
    {
        public class Bill
        {
            public int Id { set; get; }
            public string Owner { set; get; }
            public double CurrentSum { set; get; }

            public Bill(int id, string owner, double sum)
            {
                Id = id;
                Owner = owner;
                if (sum > 0)
                {
                    CurrentSum = sum;
                }
                else
                {
                    CurrentSum = 0;
                }
            }
            public virtual bool AddToSum(double income)
            {
                CurrentSum += income;
                return true;
            }

            public virtual bool SubFromSum(double outcome)
            {
                if (CurrentSum - outcome < 0)
                {
                    return false;
                }
                else
                {
                    CurrentSum -= outcome;
                    return true;
                }
            }
        }

        public class Saving : Bill
        {
            public Saving(int id, string owner, double sum) : base(id, owner, sum)
            {}
        }

        public class RollUp : Bill
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

        public class Checking : Bill
        {
            public double Payment { set; get; }
            public Checking(double payment, int id, string owner, double sum) : base(id, owner, sum)
            {
                Payment = payment;
            }
            public bool WriteOff()
            {
                return base.SubFromSum(Payment);
            }
        }

        public class Metal : Bill
        {
            public string MetalType { set; get; }
            public int GrammCount { set; get; }
            public double GrammPrice { set; get; }
            public Metal(string metalType, int grammCount, double grammPrice, int id, string owner, double sum) : base(id, owner, sum)
            {
                MetalType = metalType;
                GrammCount = grammCount;
                GrammPrice = grammPrice;
            }
            public override bool AddToSum(double grammIncome)
            {
                return base.AddToSum(grammIncome * GrammPrice);
            }

            public override bool SubFromSum(double grammOutcome)
            {
                return base.SubFromSum(grammOutcome * GrammPrice);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
