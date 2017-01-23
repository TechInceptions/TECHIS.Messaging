using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    /// <summary>
    /// Default "Do nothing" implementation of <code>IMessageReceiver</code>
    /// </summary>
    public sealed class DefaultMessageReceiver<T> : IMessageReceiver<T>
    {
        public void onMessage(ISerializedMessageContainer<T> msg)
        {

        }

        public Task onMessageAsync(ISerializedMessageContainer<T> msg)
        {
            return Task.CompletedTask;
        }
    }
}
