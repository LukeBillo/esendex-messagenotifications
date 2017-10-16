using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MessageNotificationsWebApp.Models;
using MessageNotificationsWebApp.Data;
using MessageNotificationsWebApp.Models.ViewModels;

namespace MessageNotificationsWebApp.Controllers.API
{
    [RoutePrefix("api/InboundMessages")]
    public class InboundMessageNotificationController : ApiController
    {
        [Route("")]
        public IEnumerable<InboundMessageViewModel> Get()
        {
            using (var context = new MessageNotificationsContext())
            {
                context.Database.Connection.Open();

                var inboundMessages = context.InboundMessages.ToList();

                return inboundMessages.Select(inboundMessage => new InboundMessageViewModel(inboundMessage)).ToList();
            }
        }

        [Route("")]
        public HttpResponseMessage Post([FromBody]InboundMessageViewModel inboundMessage)
        {
            using (var context = new MessageNotificationsContext())
            {
                context.Database.Connection.Open();

                context.InboundMessages.Add(new InboundMessage(inboundMessage));
                context.SaveChanges();
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}