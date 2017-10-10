using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MessageNotificationsWebApp.Models;

namespace MessageNotificationsWebApp.Controllers.API
{
    public class InboundMessageReceiver : ApiController
    {
        public IEnumerable<InboundMessage> Get()
        {
            using (var context = new MessageNotificationsContainer())
            {
                return context.InboundMessages.ToList();
            }
        }

        [HttpPost]
        public HttpResponseMessage Post(InboundMessage receivedMessage)
        {
            using (var context = new MessageNotificationsContainer())
            {
                context.InboundMessages.Add(receivedMessage);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}