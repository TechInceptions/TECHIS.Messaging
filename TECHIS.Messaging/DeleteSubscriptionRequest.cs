using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    public class DeleteSubscriptionRequest
    {
        public string TopicName { get; set; }
        public List<string> SubscriptionNames { get; set; }
        public string Filter { get; set; }
        public long MaxMsgCountAllowed { get; set; }
        public DateTime? LastAccessBefore { get; set; }
    }
}
