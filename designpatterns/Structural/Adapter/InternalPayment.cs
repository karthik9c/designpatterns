using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    public class InternalPayment : IPayment
    {
        public void MakePayment(string amount)
        {
            Console.WriteLine($"Internal Transaction successful {amount}");
        }
    }
}
