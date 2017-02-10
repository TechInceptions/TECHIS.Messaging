using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    public class ListSubscriptionRequest
    {
        public string TopicName { get; set; }
        public string Filter { get; set; }
    }
}
