using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    public interface IMessageReceiver<T>
    {
        void onMessage(ISerializedMessageContainer<T> msg);
        Task onMessageAsync(ISerializedMessageContainer<T> msg);
    }
}
