using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    public interface IPaymentGateway
    {
        void MakePayment(double amount);
    }
}
