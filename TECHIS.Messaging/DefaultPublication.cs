using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    /// <summary>
    /// Default "Do nothing" implementation of <code>IPublication</code>
    /// </summary>
    public sealed class DefaultPublication<T> : IPublication<T>
    {
        public Task Publish(ISerializedMessageContainer<T> messageContainer)
        {
            return Task.CompletedTask;
        }

        public void Subscribe(string subscriptionName, string topicName, string sql92FilterExpression, Action<ISerializedMessageContainer<T>> onMessage, int maxConcurrentCalls = 1)
        {
            
        }

        public void SubscribeAsync(string subscriptionName, string topicName, string sql92FilterExpression, Func<ISerializedMessageContainer<T>, Task> onMessageAsync, int maxConcurrentCalls = 1)
        {

        }
    }
}
