using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageNotificationsWebApp.Models
{
    public class FailedMessageViewModel
    {
        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public Guid AccountId { get; set; }
        public DateTime OccurredAt { get; set; }
        public MessageFailReasonViewModel FailureReason { get; set; }
    }
}