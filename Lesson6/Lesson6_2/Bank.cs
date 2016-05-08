using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    public class Bank
    {
        public bool Transfer(Bill from, Bill to)
        {
            if (to.AddToSum(from.CurrentSum))
            {
                return from.SubFromSum(from.CurrentSum);
            }
            return false;            
        }
    }
}
