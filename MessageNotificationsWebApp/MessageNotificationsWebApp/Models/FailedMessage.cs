using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageNotificationsWebApp.Models
{
    public class FailedMessage
    {
        public FailedMessage(FailedMessageViewModel failedMessage)
        {
            Id = failedMessage.Id;
            MessageId = failedMessage.MessageId;
            AccountId = failedMessage.AccountId;
            OccurredAt = failedMessage.OccurredAt;
            FailureCode = failedMessage.FailureReason.Code;
            FailureDetail = failedMessage.FailureReason.Detail;
            IsPermanentFailure = failedMessage.FailureReason.PermanentFailure;
        }

        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public Guid AccountId { get; set; }
        public DateTime OccurredAt { get; set; }
        public int FailureCode { get; set; }
        public string FailureDetail { get; set; }
        public bool IsPermanentFailure { get; set; }
    }
}