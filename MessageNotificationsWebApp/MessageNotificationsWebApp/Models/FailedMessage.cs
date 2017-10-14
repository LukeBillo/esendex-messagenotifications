using System;

namespace MessageNotificationsWebApp.Models
{
    [Serializable]
    public class FailedMessage
    {
        public FailedMessage()
        {
            Id = Guid.Empty;;
            MessageId = Guid.Empty;
            AccountId = Guid.Empty;
            OccurredAt = DateTime.UtcNow;
            FailureCode = 0;
            FailureDetail = string.Empty;
            IsPermanentFailure = false;
        }

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