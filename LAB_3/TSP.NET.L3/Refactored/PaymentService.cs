using System;

namespace TSP.NET.L3.Refactored
{
    public class PaymentService
    {
        private IPaymentProcessor _paymentProcessor;

        public PaymentService(PaymentDetails paymentDetails, Action onPayChangeToMobilePhone)
        {
            InitPaymentProcessor(paymentDetails, onPayChangeToMobilePhone);
        }

        private void InitPaymentProcessor(PaymentDetails paymentDetails, Action onPayChangeToMobilePhone)
        {
            switch(paymentDetails.Method)
            {
                case PaymentMethod.Cash:
                    _paymentProcessor = new PaymentByCash(onPayChangeToMobilePhone);
                    break;

                case PaymentMethod.CreditCard:
                    _paymentProcessor = new PaymentByCard(paymentDetails);
                    break;
            }
        }

        public void Pay(Product product) => _paymentProcessor.Pay(product);
    }
}
