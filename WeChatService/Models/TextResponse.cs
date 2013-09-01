using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeChatService.Models
{
    public class TextResponse : BaseResponseMessage
    {
        public override MessageType Type { get { return MessageType.TEXT; } }

        public String Content { get; set; }
    }
}