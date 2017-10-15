using System;
using System.Runtime.Serialization;

namespace MessageNotificationsWebApp.Models.ViewModels
{
    [DataContract(Name = "MessageFailed", Namespace = "")]
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
                IsPermanentFailure = failedMessage.IsPermanentFailure
            };
        }

        [DataMember(Name = "Id", Order = 1)]
        public Guid Id { get; set; }
        [DataMember(Name = "MessageId", Order = 2)]
        public Guid MessageId { get; set; }
        [DataMember(Name = "AccountId", Order = 3)]
        public Guid AccountId { get; set; }
        [DataMember(Name = "OccurredAt", Order = 4)]
        public DateTime OccurredAt { get; set; }
        [DataMember(Name = "FailureReason", Order = 5)]
        public MessageFailReasonViewModel FailureReason { get; set; }
    }
}