using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    public class CreditCardMethod : PaymentMethod
    {
        IPaymentGateway _paymentGateway;
        public CreditCardMethod(IPaymentGateway paymentGateway) : base(paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public override void MakePayment(double amount)
        {
            _paymentGateway.MakePayment(amount);
        }
    }
}
