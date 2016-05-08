using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    public class Metal : Bill
    {
        private int _grammCount;
        private string _metalType;
        private double _grammPrice;
        public string MetalType
        {
            get { return _metalType; }
        }
        public int GrammCount
        {
            get { return _grammCount; }
        }
        public double GrammPrice
        {
            get { return _grammPrice; }
        }
        public Metal(string metalType, int grammCount, double grammPrice, int id, string owner, double sum) : base(id, owner, sum)
        {
            _metalType = metalType;
            _grammCount = grammCount;
            _grammPrice = grammPrice;
            AddToSum(Convert.ToDouble(GrammCount));
        }
        public override bool AddToSum(double grammIncome)
        {
            if (grammIncome > 0)
            {
                _grammCount += Convert.ToInt32(grammIncome);
                return base.AddToSum(grammIncome * GrammPrice);
            }
            else
            {
                return false;
            }
        }

        public override bool SubFromSum(double grammOutcome)
        {
            if (grammOutcome > 0)
            {
                _grammCount -= Convert.ToInt32(grammOutcome);
                return base.SubFromSum(grammOutcome * GrammPrice);
            }
            else
            {
                return false;
            }
        }
    }
}
