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
    [RoutePrefix("api/DeliveredMessages")]
    public class DeliveredMessageNotificationController : ApiController
    {
        [Route("")]
        public IEnumerable<DeliveredMessageViewModel> Get()
        {
            using (var context = new MessageNotificationsContext())
            {
                var deliveredMessages = context.DeliveredMessages.ToList();

                return deliveredMessages.Select(deliveredMessage => new DeliveredMessageViewModel(deliveredMessage)).ToList();
            }
        }

        [Route("")]
        public HttpResponseMessage Post([FromBody]DeliveredMessageViewModel deliveredMessage)
        {
            using (var context = new MessageNotificationsContext())
            {
                context.DeliveredMessages.Add(new DeliveredMessage(deliveredMessage));
                context.SaveChanges();
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}