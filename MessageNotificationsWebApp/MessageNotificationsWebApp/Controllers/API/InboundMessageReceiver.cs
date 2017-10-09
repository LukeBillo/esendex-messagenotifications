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
        public dynamic Get()
        {
            return new NotImplementedException();
        }

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