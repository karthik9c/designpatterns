using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    public class HdfcPaymentAdapter : IPayment
    {
        readonly HDFCService _service;
        public HdfcPaymentAdapter(HDFCService hDFCService)
        {
            _service = hDFCService;
        }
        public void MakePayment(string amount)
        {
            _service.HandlePayment(Double.Parse(amount));
;       }
    }
}
