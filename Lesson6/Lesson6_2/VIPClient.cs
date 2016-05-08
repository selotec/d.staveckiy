using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    public class VIPClient : BankClient
    {
        public VIPClient() : base(10)
        { }
    }
}
