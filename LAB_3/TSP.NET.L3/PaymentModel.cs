using System;
using TSP.NET.L3.Refactored;

namespace TSP.NET.L3
{

    public class PaymentModel
    {
        public void BuyTicket(TicketDetails ticket,
                              PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            new PaymentService(payment, onPayChangeToMobilePhone).Pay(ticket);
        }
    }
}
