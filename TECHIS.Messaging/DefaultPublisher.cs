using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    /// <summary>
    /// Default "Do nothing" implementation of <code>IPublisher</code>
    /// </summary>

    public sealed class DefaultPublisher<T> : IPublisher<T>
    {
        public Task Publish(ISerializedMessageContainer<T> messageContainer)
        {
            return Task.CompletedTask;
        }
    }
}
