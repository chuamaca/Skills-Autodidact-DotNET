using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    public class ResponseDto
    {
        private static readonly IEnumerable<ApplicationMessage> DefaultMessages = Enumerable.Empty<ApplicationMessage>();

        public ResponseDto(IEnumerable<ApplicationMessage> messages = null)
        {
            Messages = new List<ApplicationMessage>(messages ?? DefaultMessages);
        }

        public bool IsValid => Messages.All(m => m.MessageType != ApplicationMessageType.Error);
        public bool HasWarnings => Messages.Any(m => m.MessageType == ApplicationMessageType.Warning);

        public List<ApplicationMessage> Messages { get; set; }



        public static ResponseDto Create(ApplicationMessage message)
        {
            if (message == null)
                return Create();

            return Create(messages: new ApplicationMessage[] { message });
        }

        public static ResponseDto Create(IEnumerable<ApplicationMessage> messages = null)
        {
            return new ResponseDto(messages);
        }


        public static ResponseDto<T> Create<T>(ApplicationMessage message)
        {
            var data = default(T);
            if (message == null)
                return Create(data);

            return Create(data: data, messages: new ApplicationMessage[] { message });
        }

        public static ResponseDto<T> Create<T>(T data)
        {
            return Create(data: data, messages: null);
        }

        public static ResponseDto<T> Create<T>(T data = default(T), IEnumerable<ApplicationMessage> messages = null)
        {
            return new ResponseDto<T>(data, messages);
        }
    }


    public class ResponseDto<T> : ResponseDto
    {
        public ResponseDto(T data = default(T), IEnumerable<ApplicationMessage> messages = null) : base(messages)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}
