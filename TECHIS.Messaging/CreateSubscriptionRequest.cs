using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    public class CreateSubscriptionRequest
    {
        public string SubscriptionName { get; set; }
        public string[] SubscriptionNames { get; set; }
        public string TopicName { get; set; }
        public string Sql92FilterExpression { get; set; }
    }
}
