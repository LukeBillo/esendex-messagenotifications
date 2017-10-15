using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;

namespace MessageNotificationsWebApp.Models
{
    [DataContract(Name = "FailureReason", Namespace = "")]
    public class MessageFailReasonViewModel
    {
        [DataMember(Name = "Code", Order = 1)]
        public int Code { get; set; }
        [DataMember(Name = "Detail", Order = 2)]
        public string Detail { get; set; }
        [DataMember(Name = "PermanentFailure", Order = 3)]
        public bool IsPermanentFailure { get; set; }
    }
}