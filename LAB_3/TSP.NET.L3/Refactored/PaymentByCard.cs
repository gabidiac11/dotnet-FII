using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L3.Refactored
{
    public class PaymentByCard : IPaymentProcessor
    {
        private PaymentDetails _paymentDetails;

        public PaymentByCard(PaymentDetails paymentDetails)
        {
            _paymentDetails = paymentDetails;
        }

        public void Pay(Product product)
        {
            new ProcessingCenterGateway().Charge(product.Price, _paymentDetails);
        }
    }
}
