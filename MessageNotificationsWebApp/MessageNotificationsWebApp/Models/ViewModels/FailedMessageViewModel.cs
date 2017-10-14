using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageNotificationsWebApp.Models
{
    [Serializable]
    public class FailedMessageViewModel
    {
        public FailedMessageViewModel(FailedMessage failedMessage)
        {
            Id = failedMessage.Id;
            MessageId = failedMessage.MessageId;
            AccountId = failedMessage.AccountId;
            OccurredAt = failedMessage.OccurredAt;

            FailureReason = new MessageFailReasonViewModel
            {
                Code = failedMessage.FailureCode,
                Detail = failedMessage.FailureDetail,
                PermanentFailure = failedMessage.IsPermanentFailure
            };
        }

        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public Guid AccountId { get; set; }
        public DateTime OccurredAt { get; set; }
        public MessageFailReasonViewModel FailureReason { get; set; }
    }
}