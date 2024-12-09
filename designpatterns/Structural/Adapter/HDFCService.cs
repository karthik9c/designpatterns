using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    public class HDFCService
    {
        public bool HandlePayment(double payment) 
        {
            Console.WriteLine($"HDFC payment service {payment}");
            return true;
        }
    }
}
