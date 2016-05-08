using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class Bill
    {
        private int _id;
        private string _owner;
        private double _currentSum;
        public int Id
        {
            get { return _id; }
        }
        public string Owner
        {
            get { return _owner; }
        }
        public double CurrentSum
        {
            get { return _currentSum; }
        }

        public Bill(int id, string owner, double sum)
        {
            _id = id;
            _owner = owner;
            if (sum > 0)
            {
                _currentSum = sum;
            }
            else
            {
                _currentSum = 0;
            }
        }
        public virtual bool AddToSum(double income)
        {
            if (CurrentSum + income > 0)
            {
                _currentSum += income;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool SubFromSum(double outcome)
        {
            if (_currentSum - outcome < 0)
            {
                return false;
            }
            else
            {
                _currentSum -= outcome;
                return true;
            }
        }
    }
}
