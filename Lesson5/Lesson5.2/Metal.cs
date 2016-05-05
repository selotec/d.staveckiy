using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class Metal : Bill
    {
        public string MetalType { set; get; }
        public int GrammCount { set; get; }
        public double GrammPrice { set; get; }
        public Metal(string metalType, int grammCount, double grammPrice, int id, string owner, double sum) : base(id, owner, sum)
        {
            MetalType = metalType;
            GrammCount = grammCount;
            GrammPrice = grammPrice;
            this.AddToSum(GrammCount);
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
}
