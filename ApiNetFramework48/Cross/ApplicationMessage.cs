using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    public class ApplicationMessage
    {
        public ApplicationMessage()
        {
        }
        public ApplicationMessage(string key, string message, ApplicationMessageType messageType = default(ApplicationMessageType))
        {
            Key = key;
            Message = message;
            MessageType = messageType;
        }

        public string Key { get; set; }

        public string Message { get; set; }

        public ApplicationMessageType MessageType { get; set; }

        public override string ToString() => Message;
    }
}
