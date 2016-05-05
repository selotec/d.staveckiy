using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class Checking : Bill
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
}
