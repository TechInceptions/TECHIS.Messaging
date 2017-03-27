using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHIS.Messaging;

namespace TECHIS.Messaging
{
    public interface IMessageSubscriber<TSerializedMessage>
    {
        
        void Subscribe(string subscriptionName, string topicName, string sql92FilterExpression, Action<ISerializedMessageContainer<TSerializedMessage>> onMessage, int maxConcurrentCalls = 1);

        Task SubscribeAsync(string subscriptionName, string topicName, string sql92FilterExpression, Func<ISerializedMessageContainer<TSerializedMessage>, Task> onMessageAsync, int maxConcurrentCalls = 1);
        
    }
}
