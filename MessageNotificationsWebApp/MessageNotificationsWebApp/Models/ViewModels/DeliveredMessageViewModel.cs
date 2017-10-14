using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageNotificationsWebApp.Models.ViewModels
{
    [Serializable]
    public class DeliveredMessageViewModel
    {
        public DeliveredMessageViewModel(DeliveredMessage deliveredMessage)
        {
            Id = deliveredMessage.Id;
            MessageId = deliveredMessage.MessageId;
            AccountId = deliveredMessage.AccountId;
            OccurredAt = deliveredMessage.OccurredAt;
        }

        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public Guid AccountId { get; set; }
        public DateTime OccurredAt { get; set; }
    }
}