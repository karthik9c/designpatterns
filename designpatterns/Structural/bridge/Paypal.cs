using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    public class Paypal : IPaymentGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Paypal payment {amount}");
        }
    }
}
