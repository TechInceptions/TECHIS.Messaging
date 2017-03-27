using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    [Obsolete("Use 'TECHIS.Messaging.IMessageReceiption' instead")]
    public interface IMessageReceiver<T>
    {
        void onMessage(ISerializedMessageContainer<T> msg);
        Task onMessageAsync(ISerializedMessageContainer<T> msg);
    }
}
