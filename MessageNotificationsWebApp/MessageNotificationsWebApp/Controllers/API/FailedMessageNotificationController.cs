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
    [RoutePrefix("api/FailedMessages")]
    public class FailedMessageNotificationController : ApiController
    {
        [Route("")]
        public IEnumerable<FailedMessageViewModel> Get()
        {
            using (var context = new MessageNotificationsContext())
            {
                var failedMessages = context.FailedMessages.ToList();

                return failedMessages.Select(failedMessage => new FailedMessageViewModel(failedMessage)).ToList();
            }
        }

        [Route("")]
        public HttpResponseMessage Post([FromBody]FailedMessageViewModel failedMessage)
        {
            using (var context = new MessageNotificationsContext())
            {
                context.FailedMessages.Add(new FailedMessage(failedMessage));
                context.SaveChanges();
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}