using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class Saving : Bill
    {
        public Saving(int id, string owner, double sum) : base(id, owner, sum)
        { }
    }
}
