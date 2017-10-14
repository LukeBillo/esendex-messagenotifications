using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageNotificationsWebApp.Models.ViewModels
{
    [Serializable]
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

        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public Guid AccountId { get; set; }
        public string MessageText { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}