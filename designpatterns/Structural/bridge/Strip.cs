using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    public class Strip : IPaymentGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Strip payment {amount}");
        }
    }
}
