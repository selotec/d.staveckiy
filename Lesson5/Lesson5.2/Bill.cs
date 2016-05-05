using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class Bill
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
}
