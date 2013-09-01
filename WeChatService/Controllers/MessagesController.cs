using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WeChatService.Models;

namespace WeChatService.Controllers
{
    public class MessagesController : Controller
    {
        [HttpPost]
        [OutputCache(Duration = 0)]
        public ActionResult Post(String content)
        {
            return new JsonResult() { Data = new TextResponse() { Content = "Hello World" }, ContentType = "application/json" };
        }
    }
}