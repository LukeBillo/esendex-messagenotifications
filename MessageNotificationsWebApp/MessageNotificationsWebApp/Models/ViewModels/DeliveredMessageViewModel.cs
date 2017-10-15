using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MessageNotificationsWebApp.Models.ViewModels
{
    [DataContract(Name = "MessageDelivered", Namespace = "")]
    public class DeliveredMessageViewModel
    {
        public DeliveredMessageViewModel(DeliveredMessage deliveredMessage)
        {
            Id = deliveredMessage.Id;
            MessageId = deliveredMessage.MessageId;
            AccountId = deliveredMessage.AccountId;
            OccurredAt = deliveredMessage.OccurredAt;
        }

        [DataMember(Name = "Id", Order = 1)]
        public Guid Id { get; set; }
        [DataMember(Name = "MessageId", Order = 2)]
        public Guid MessageId { get; set; }
        [DataMember(Name = "AccountId", Order = 3)]
        public Guid AccountId { get; set; }
        [DataMember(Name = "OccurredAt", Order = 4)]
        public DateTime OccurredAt { get; set; }
    }
}