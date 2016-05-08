using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Checking : Bill
    {
        private double _payment;
        public double Payment
        {
            get { return _payment; }
        }
        public Checking(double payment, int id, string owner, double sum) : base(id, owner, sum)
        {
            _payment = payment;
        }
        public bool WriteOff()
        {
            return base.SubFromSum(_payment);
        }
    }
}
