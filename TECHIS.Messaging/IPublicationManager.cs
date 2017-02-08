using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHIS.Messaging;

namespace TECHIS.Messaging
{
    [Obsolete("To manager Topics and Subscriptions, use IPublicationResourceManager") ]
    public interface IPublicationManager<TSerializedMessage>:IPublication<TSerializedMessage>
    {
        #region Public Methods 

        void CreateSubscription(string subscriptionName, string topicName, string sql92FilterExpression);

        #endregion
    }
}
