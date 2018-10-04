using System;

namespace Lab4.Models
{
    public class GetDateModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}