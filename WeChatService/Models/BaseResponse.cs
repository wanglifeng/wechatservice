using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeChatService.Models
{
    public abstract class BaseResponseMessage
    {
        public int ErrorCode { get; set; }
        public String ErrorMessage { get; set; }

        public abstract MessageType Type { get; }
    }

    public enum MessageType
    {
        TEXT,
        LIST
    }
}