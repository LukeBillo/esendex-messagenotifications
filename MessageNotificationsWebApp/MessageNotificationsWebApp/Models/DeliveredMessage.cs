﻿using System;
using MessageNotificationsWebApp.Models.ViewModels;

namespace MessageNotificationsWebApp.Models
{
    [Serializable]
    public class DeliveredMessage
    {
        public DeliveredMessage()
        {
            Id = Guid.Empty;
            MessageId = Guid.Empty;
            AccountId = Guid.Empty;
            OccurredAt = DateTime.UtcNow;
        }

        public DeliveredMessage(DeliveredMessageViewModel deliveredMessage)
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