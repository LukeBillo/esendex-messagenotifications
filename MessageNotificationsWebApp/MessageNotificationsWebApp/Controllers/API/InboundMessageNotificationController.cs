﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MessageNotificationsWebApp.Models;
using MessageNotificationsWebApp.Data;
using MessageNotificationsWebApp.Models.ViewModels;
using Newtonsoft.Json;

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
                var inboundMessages = context.InboundMessages.ToList();

                if (inboundMessages.Count == 0)
                    return new List<InboundMessageViewModel>();

                return inboundMessages.Select(inboundMessage => new InboundMessageViewModel(inboundMessage)).ToList();
            }
        }

        [Route("")]
        public HttpResponseMessage Post([FromBody] object inboundMessage)
        {
            var temp = inboundMessage.ToString();
            var inboundMessageObject = JsonConvert.DeserializeObject<InboundMessage>(temp);

            using (var context = new MessageNotificationsContext())
            {
                context.InboundMessages.Add(new InboundMessage());
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}