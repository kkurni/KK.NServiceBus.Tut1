using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using Ordering.Messages;

namespace Ordering.Subscriber
{
    public class OrderPlaceedHandler : IHandleMessages<OrderPlaceed>
    {
        public IBus Bus { get; set; }

        public void Handle(OrderPlaceed message)
        {
            Console.WriteLine(@"Handling: OrderPlaced for Order Id: {0}", message.OrderId);
        }
    }
}
