using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace MessageNotificationsWebApp.Models
{
    public class MessageFailReason
    {
        public HttpStatusCode Code { get; set; }
        public string Detail { get; set; }
        public bool PermanentFailure { get; set; }
    }
}