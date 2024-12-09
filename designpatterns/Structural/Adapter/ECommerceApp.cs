using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    public class ECommerceApp
    {
        IPayment _payment;
        public ECommerceApp(IPayment payment) 
        {
            _payment = payment;
        }

        public void Order(string amount)
        {
            _payment.MakePayment(amount);
        }
    }
}
