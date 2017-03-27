using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    public interface IMessagePublisher<T>
    {
        Task PublishAsync(ISerializedMessageContainer<T> messageContainer);
        void Publish(ISerializedMessageContainer<T> messageContainer);
    }
}
