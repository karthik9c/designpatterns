using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    public abstract class PaymentMethod
    {
        IPaymentGateway gateway;
        protected PaymentMethod(IPaymentGateway paymentGateway) 
        {
            gateway = paymentGateway;
        }


        public abstract void MakePayment(double amount);
    }
}
