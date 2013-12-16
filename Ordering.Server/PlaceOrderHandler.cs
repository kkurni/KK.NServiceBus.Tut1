using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using Ordering.Messages;

namespace Ordering.Server
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public IBus Bus { get; set; }

        public void Handle(PlaceOrder message)
        {
            Console.WriteLine(@"Order for Product:{0} placed", message.Product);

             //throw new Exception("Uh oh - something went wrong....");

            Console.WriteLine(@"Publishing: OrderPlaceed for Order Id: {0}", message.Id);

            Bus.Publish<OrderPlaceed>(e => { e.OrderId = message.Id; });
        }
    }
}
