using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace Ordering.Messages
{
    
    public class OrderPlaceed : IEvent
    {
        public Guid OrderId { get; set; }
    }
}
