using System;
using System.Runtime.Serialization;

namespace MessageNotificationsWebApp.Models.ViewModels
{
    [DataContract(Name = "InboundMessage", Namespace = "")]
    public class InboundMessageViewModel
    {
        public InboundMessageViewModel(InboundMessage inboundMessage)
        {
            Id = inboundMessage.Id;
            MessageId = inboundMessage.MessageId;
            AccountId = inboundMessage.AccountId;
            MessageText = inboundMessage.MessageText;
            From = inboundMessage.Sender;
            To = inboundMessage.Recipient;
        }

        [DataMember(Name = "Id", Order = 1)]
        public Guid Id { get; set; }
        [DataMember(Name = "MessageId", Order = 2)]
        public Guid MessageId { get; set; }
        [DataMember(Name = "AccountId", Order = 3)]
        public Guid AccountId { get; set; }
        [DataMember(Name = "MessageText", Order = 4)]
        public string MessageText { get; set; }
        [DataMember(Name = "From", Order = 5)]
        public string From { get; set; }
        [DataMember(Name = "To", Order = 6)]
        public string To { get; set; }
    }
}