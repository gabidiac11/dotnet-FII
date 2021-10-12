using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L3.Refactored
{
    public class PaymentByCash : IPaymentProcessor
    {
        private decimal _cashAccepted;
        private Action _onPayChangeToMobilePhone;

        public PaymentByCash(Action onPayChangeToMobilePhone)
        {
            _onPayChangeToMobilePhone = onPayChangeToMobilePhone;
        }

        public void Pay(Product product)
        {
            AcceptCash(product);
            DispenseChange(product);
        }

        private void AcceptCash(Product product)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)product.Price, (int)product.Price + 1000);
        }

        private void DispenseChange(Product product)
        {
            if (_cashAccepted > product.Price &&
                !TryToDispense(_cashAccepted - product.Price))
                _onPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; //or true :)
        }
    }
}
