using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Messaging
{
    public interface IBinaryMessageReceiver : IMessageReceiver<byte[]>
    {
    }
}
