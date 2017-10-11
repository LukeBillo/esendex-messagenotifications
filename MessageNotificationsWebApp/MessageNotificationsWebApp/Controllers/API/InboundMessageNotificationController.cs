using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MessageNotificationsWebApp.Models;

namespace MessageNotificationsWebApp.Controllers.API
{
    [RoutePrefix("api/InboundMessages")]
    public class InboundMessageNotificationController : ApiController
    {
        [Route("")]
        public IEnumerable<InboundMessage> Get()
        {
            using (var context = new MessageNotificationsContainer())
            {
                return context.InboundMessages.DefaultIfEmpty().ToList();
            }
        }

        [Route("")]
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