using System;
using WaffleGenerator;

namespace Lab4.Models
{
    public class GetWaffleModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}