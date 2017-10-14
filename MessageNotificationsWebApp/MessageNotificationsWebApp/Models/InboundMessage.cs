using System;
using MessageNotificationsWebApp.Models.ViewModels;

namespace MessageNotificationsWebApp.Models
{
    [Serializable]
    public class InboundMessage
    {
        public InboundMessage()
        {
            Id = Guid.Empty;
            MessageId = Guid.Empty;
            AccountId = Guid.Empty;
            MessageText = string.Empty;
            Sender = string.Empty;
            Recipient = string.Empty;
        }

        public InboundMessage(InboundMessageViewModel inboundMessage)
        {
            Id = inboundMessage.Id;
            MessageId = inboundMessage.MessageId;
            AccountId = inboundMessage.AccountId;
            MessageText = inboundMessage.MessageText;
            Sender = inboundMessage.From;
            Recipient = inboundMessage.To;
        }

        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public Guid AccountId { get; set; }
        public string MessageText { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
    }
}